namespace PMS.DAL
{
    public static class DbContext
    {
        private static CodeFirstModel _instance;
        public static CodeFirstModel Instance => _instance ?? (_instance = new CodeFirstModel());
    }
}