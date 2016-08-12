using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMS.DAL
{
    public static class DbContext
    {
       private static CodeFirstModel _instance;
       public static CodeFirstModel Instance => _instance ?? (_instance = new CodeFirstModel());
        
    }
}
