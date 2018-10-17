using System;

namespace userDatabase {
    class Program {

       static string[] userID = new string[5];
       static string[] passwds = new string[5];

        static void Main(string[] args) {
            login:
            Console.WriteLine("================");
            Console.WriteLine("** USER LOGIN **");
            Console.WriteLine("================");
            Console.WriteLine();
            Console.Write("user: ");
            string userNameIn = Console.ReadLine();
            Console.Write("password: ");
            string passwordIn = Console.ReadLine();

            if(userNameIn == userID[0] && passwordIn == passwds[0]) {
                Console.WriteLine("Welcome, {0}.", userID[0]);
            }

            if(userNameIn == userID[1] && passwordIn == passwds[1]) {
                Console.WriteLine("welcome, {0}", userID[1]);
            } else {
                Console.WriteLine("Username or password incorrect.");
                goto login;
            }

            if(userNameIn == userID[2] && passwordIn == passwds[2]) {
                Console.WriteLine("Welcome, {0}", userID[2]);
            } else {
                Console.WriteLine("Username or password incorrect.");
                goto login;
            }

            if(userNameIn == userID[3] && passwordIn == passwds[3]) {
                Console.WriteLine("Welcome, {0}", userID[3]);
            } else {
                Console.WriteLine("Username or password incorrect.");
                goto login;
            }

            if(userNameIn == userID[4] && passwordIn == passwds[4]) {
                Console.WriteLine("Welcome, {0}", userID[4]);
            } else {
                Console.WriteLine("Username or password incorrect.");
                goto login;
            }

            //values for the user database
            userID[0] = "Jacob"; passwds[0] = "L1nux";
            userID[1] = "Linus"; passwds[1] = "r00t";
            userID[2] = "IBM"; passwds[2] = "wats0n";
            userID[3] = "Apple"; passwds[3] = "L1sa";
            userID[4] = "Microsoft"; passwds[4] = "billGates";


        }
    }
}
