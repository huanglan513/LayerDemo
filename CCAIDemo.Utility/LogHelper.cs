using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCAIDemo.Utility
{
    public class LogHelper
    {
        public static void LogError(Exception e)
        {
            using (System.IO.FileStream fs = new System.IO.FileStream(@"c:\testme.log",
                      System.IO.FileMode.Append, System.IO.FileAccess.Write))
            {
                using (System.IO.StreamWriter w = new System.IO.StreamWriter(fs, System.
                       Text.Encoding.UTF8))
                {
                    w.WriteLine(DateTime.Now.ToString()+e.ToString());
                }
            }
        }
    }
}
