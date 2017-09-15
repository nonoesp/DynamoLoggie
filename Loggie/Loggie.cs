using System;
using System.Text;

namespace LoggieLib
{
    public class Loggie
    {
        // StringBuilder to build the log
        public static StringBuilder sb = new StringBuilder();

        private Loggie()
        {

        }

        // Preprend a new line to the log
        public static void Write(string String)
        {
            sb.Insert(0, Environment.NewLine);
            sb.Insert(0, String);
        }

        // Clear existing log
        public static void Clear()
        {
            sb = new StringBuilder();
        }

        // Get a string representation of the current log
        public static string GetString()
        {
            return sb.ToString();
        }
    }
}
