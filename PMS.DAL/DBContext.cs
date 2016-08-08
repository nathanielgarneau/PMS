using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PMS.DAL.Model;
using SQLite;

namespace PMS.DAL
{
    public static class DbContext
    {
       private static SQLiteConnection _instance;
       public static SQLiteConnection Instance => _instance ?? (_instance = Configure());

        private static SQLiteConnection Configure()
        {
            var  context = new SQLiteConnection(databasePath: "repository.db");
            context.CreateTable<Setting>();
            Seed.InitialSeed(context);
            return context;
        }

       
    }
}
