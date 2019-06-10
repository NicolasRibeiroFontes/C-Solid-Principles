using System;

//using SRP.Problem;
using SRP.Solution;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting...");

            #region Problem

            //User user = new User();

            //user.Email = "nicolas.rfontes@gmail.com";
            //user.Name = "Nicolas Fontes";

            //bool returnSaveUser = user.SaveUser();
            //Console.WriteLine(returnSaveUser ? "Successfull to register User" : "Failed to register User");

            #endregion

            #region Solution

            User user = new User("Nicolas Fontes", "nicolas.rfontes@gmail.com");

            UserService userService = new UserService();
            bool returnSaveUser = userService.SaveUser(user);

            Console.WriteLine(returnSaveUser ? "Successfull to register User" : "Failed to register User");

            #endregion

            Console.ReadKey();
        }
    }
}
