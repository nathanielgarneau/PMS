using System;
using System.Diagnostics;


namespace PMS.Common
{
     public static class LoggingHelper
    {
        public static string GetCallingMethod()
        {
           // var st = new StackTrace();
          //  var sf = st.GetFrame(1);
          //  return sf.GetMethod().Name;
            return null;
        }
        
        public static void Log()//ILog logger, Exception exception)
        {
           // logger.Error($"{GetCallingMethod()}() failed with Exception.", exception);
        }

        public static void Log<T>()//ILog logger, Exception exception, params T[] items)
        {
           // logger.Error($"{GetCallingMethod()}({items}) failed with Exception.", exception);
        }
    }
}
