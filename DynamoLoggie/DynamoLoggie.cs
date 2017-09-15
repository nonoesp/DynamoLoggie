using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.DesignScript.Runtime;
using LoggieLib;

namespace DynamoLoggie
{
    public class DynamoLoggie
    {
        private DynamoLoggie()
        {
            Loggie.Write("Hello, Loggie!");
        }

        [CanUpdatePeriodically(true)]
        public static string GetLog()
        {
            return Loggie.GetString();
        }

        public static void Write(string String)
        {
            Loggie.Write(String);
        }

        public static void ClearLog(bool Run)
        {
            if (Run)
            {
                Loggie.Clear();
            }
        }
    }
}
