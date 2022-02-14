using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RQ.Nuget.Test
{
    internal class NugetLog
    {
        /// <summary>
        /// Nuget的一些信息
        /// </summary>
        /// <returns></returns>
        public static string IsWho()
        {
            string str = $"this is a Nuget.dll, it's version is v1.3.0";
            return str;
            //return string.Empty;
        }
    }
}
