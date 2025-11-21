using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AVOS.System64.Data.Users
{

    class UsersType
    {
        public enum UsersTypeCount
        {
            Usual = 0,
            Admin = 1,
            Root = 2,
            Tester = 3,
            Dev = 4

        }

        public static string Usual
        {
            get
            {
                return "usual";
            }
        }

        /// <summary>
        /// Standard
        /// </summary>
        /// <returns>standard</returns>
        public static string Admin
        {
            get
            {
                return "admin";
            }
        }

        public static string Root
        {
            get
            {
                return "root";
            }
        }

        public static string Tester
        {
            get
            {
                return "tester";
            }
        }

        public static string Dev
        {
            get
            {
                return "dev";
            }
        }

        /// <summary>
        /// User type
        /// </summary>
        public static string TypeUser
        {
            get
            {
                if (Kernel.userLevelLogged == Admin)
                {
                    return "#";
                }
                else
                {
                    return "$";
                }
            }
 
        }

        public static string TypeUser1
        {
            get
            {
                if (Kernel.userLevelLogged == Root)
                {
                    return "#!";
                }
                else
                {
                    return "$";
                }
            }

        }

        public static string TypeUser2
        {
            get
            {
                if (Kernel.userLevelLogged == Tester)
                {
                    return "#@";
                }
                else
                {
                    return "$";
                }
            }

        }

        public static string TypeUser3
        {
            get
            {
                if (Kernel.userLevelLogged == Dev)
                {
                    return "#&";
                }
                else
                {
                    return "$";
                }
            }

        }

    }
}
