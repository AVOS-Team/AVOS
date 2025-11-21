using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVOS.System64.ProgrammingLanguages.JSONParser
{
    public class JsonValue
    {
        public enum JsonType { Object, Array, String, Number, Bool, Null }

        public JsonType Type;
        public Dictionary<string, JsonValue> ObjectValue;
        public List<JsonValue> ArrayValue;
        public string StringValue;
        public double NumberValue;
        public bool BoolValue;

        public bool IsObject => Type == JsonType.Object;
        public bool IsArray => Type == JsonType.Array;
        public bool IsString => Type == JsonType.String;
        public bool IsNumber => Type == JsonType.Number;
        public bool IsBool => Type == JsonType.Bool;
        public bool IsNull => Type == JsonType.Null;

        public Dictionary<string, JsonValue> AsObject() => ObjectValue;
        public List<JsonValue> AsArray() => ArrayValue;
        public string AsString() => StringValue;
        public double AsNumber() => NumberValue;
        public bool AsBool() => BoolValue;

        public static JsonValue Null() => new JsonValue { Type = JsonType.Null };
    }

    public static class JsonParser
    {
        private static string text;
        private static int index;

        public static JsonValue Parse(string input)
        {
            text = input;
            index = 0;
            SkipWhitespace();
            return ParseValue();
        }

        private static JsonValue ParseValue()
        {
            SkipWhitespace();
            if (index >= text.Length) return JsonValue.Null();

            char c = text[index];
            if (c == '{') return ParseObject();
            if (c == '[') return ParseArray();
            if (c == '"') return ParseString();
            if (char.IsDigit(c) || c == '-') return ParseNumber();
            if (Match("true")) return new JsonValue { Type = JsonValue.JsonType.Bool, BoolValue = true };
            if (Match("false")) return new JsonValue { Type = JsonValue.JsonType.Bool, BoolValue = false };
            if (Match("null")) return JsonValue.Null();

            return JsonValue.Null();
        }

        private static JsonValue ParseObject()
        {
            var obj = new Dictionary<string, JsonValue>();
            index++; // skip '{'
            SkipWhitespace();

            while (index < text.Length && text[index] != '}')
            {
                var key = ParseString().StringValue;
                SkipWhitespace();
                if (index < text.Length && text[index] == ':') index++;
                SkipWhitespace();

                var value = ParseValue();
                obj[key] = value;

                SkipWhitespace();
                if (index < text.Length && text[index] == ',') index++;
                SkipWhitespace();
            }
            if (index < text.Length && text[index] == '}') index++;
            return new JsonValue { Type = JsonValue.JsonType.Object, ObjectValue = obj };
        }

        private static JsonValue ParseArray()
        {
            var arr = new List<JsonValue>();
            index++; // skip '['
            SkipWhitespace();

            while (index < text.Length && text[index] != ']')
            {
                arr.Add(ParseValue());
                SkipWhitespace();
                if (index < text.Length && text[index] == ',') index++;
                SkipWhitespace();
            }
            if (index < text.Length && text[index] == ']') index++;
            return new JsonValue { Type = JsonValue.JsonType.Array, ArrayValue = arr };
        }

        private static JsonValue ParseString()
        {
            index++; // skip "
            int start = index;
            while (index < text.Length && text[index] != '"') index++;
            string str = text.Substring(start, index - start);
            if (index < text.Length) index++; // skip "
            return new JsonValue { Type = JsonValue.JsonType.String, StringValue = str };
        }

        private static JsonValue ParseNumber()
        {
            int start = index;
            while (index < text.Length && (char.IsDigit(text[index]) || text[index] == '.' || text[index] == '-'))
                index++;
            double num = double.Parse(text.Substring(start, index - start));
            return new JsonValue { Type = JsonValue.JsonType.Number, NumberValue = num };
        }

        private static void SkipWhitespace()
        {
            while (index < text.Length && char.IsWhiteSpace(text[index])) index++;
        }

        private static bool Match(string word)
        {
            if (text.Substring(index).StartsWith(word))
            {
                index += word.Length;
                return true;
            }
            return false;
        }
    }
}
