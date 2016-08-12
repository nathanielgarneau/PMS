using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PMS.Xam.DAL;
using PMS.Xam.DAL.Model;

namespace PMS.DAL
{
    public static class DbContext
    {
       private static CodeFirstModel _instance;
       public static CodeFirstModel Instance => _instance ?? (_instance = new CodeFirstModel());

        #region sqlite 
        ////This was the sqlite implementation
        //private static SQLiteConnection _instance;
        //public static SQLiteConnection Instance => _instance ?? (_instance = Configure());
        // private static SQLiteConnection Configure()
        // {
        //     var  context = new SQLiteConnection(databasePath: "repository.db");
        //     Seed.InitialSeed(context);
        //     return context;
        // }
        #endregion

    }
}
