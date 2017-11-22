using System.Collections.Generic;
using System;




namespace DataBaseTest2
{
    class Program
    {

        static UserRepository repo = new UserRepository();
        static void Main(string[] args)
        {
            //IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            //.AddJsonFile("appsettings.json")
            //.Build();


            //string conn = configuration.GetConnectionString("connectionString").Replace("%CONTENTROOTPATH%", Directory.GetCurrentDirectory());
            //string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\App_Data\\DatabaseUsers2.mdf;Integrated Security=True;Connect Timeout=30";
            //Console.WriteLine(conn);
            //User user = null;
            //int id = 1;
            //using (IDbConnection db = new SqlConnection(conn))
            //{
            //    user = db.Query<User>("SELECT * FROM Users WHERE Id = @id", new { id }).FirstOrDefault();
            //}

            //Console.WriteLine(user.Name);

            Console.WriteLine("\nOurHeroes:");
            List<User> users = repo.GetUsers();

            foreach (User user in users)
            {
                Console.WriteLine(String.Format("{0} is {1} years old", user.Name, user.Age));
            }

            Console.ReadKey();
        }
    }
}
