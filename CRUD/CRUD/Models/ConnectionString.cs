namespace CRUD.Models
{
    public static class ConnectionString
    {
        private static string cName = "Data Source=KajalPatel-PC; Initial Catalog=Student;integrated security=true;MultipleActiveResultSets=True";
        public static string CName
        {
            get => cName;
        }
    }
}
