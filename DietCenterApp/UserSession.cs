using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietCenterApp
{
    static class UserSession
    {
        public static string AccessToken { get; set; }
        public static string RefreshToken { get; set; }
        public static string TokenType { get; set; }
        public static string ExpiresIn { get; set; }
        public static List<string> Roles = new List<string>();
    }
}
