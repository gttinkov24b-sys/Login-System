namespace login
{
    internal class login
    {
        static void Main(string[] args)
        {
            string name = null;
            var pass = "p123";
            bool ValidLogin = false;

            while(!ValidLogin)
            {
                Console.Write("What will your Username Be:");
                name = Console.ReadLine();
                System.Threading.Thread.Sleep(100);
                Console.Clear();
                Console.Write("What will your Password Be:");
                pass = Console.ReadLine();
                System.Threading.Thread.Sleep(100);
                Console.Clear();
                int duljina = name.Length;
                int duljina2 = pass.Length;
                if (duljina < 3 && duljina2 < 5)
                {
                    Console.WriteLine("Password or name Too short Try Again!");
                    System.Threading.Thread.Sleep(2500);
                    Console.Clear();
                    ValidLogin = false;
                }
                else
                {
                    Console.Clear();
                    ValidLogin = true;
                }
            }
            bool ChceckAgain = false;

            while(!ChceckAgain)
            {
                Console.WriteLine("You will have to re-register to verify that you are a human!");
                System.Threading.Thread.Sleep(2500);
                Console.Clear();
                Console.Write("What was your Username:");
                string name2 = Console.ReadLine();
                System.Threading.Thread.Sleep(100);
                Console.Clear();
                Console.Write("What was your Password:");
                var pass2 = Console.ReadLine();
                System.Threading.Thread.Sleep(100);
                Console.Clear();
                if (name == name2 && pass == pass2)
                {
                    Console.WriteLine($"Welcome to this app {name} Hope you have a wunderbar time!");
                    ChceckAgain = true;
                    System.Threading.Thread.Sleep(2600);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Incorrect Name and/or Password Try again");
                    System.Threading.Thread.Sleep(2500);
                    Console.Clear();
                }
            
            }
            var pn = "nun";
            var email = "nun";
                Console.WriteLine("Would you like to set up a phone number or email?(y/n)");
                string izbor = Console.ReadLine();
            if (izbor == "y")
            {
                Console.Write("E-mail, password or Both:");
                string decision = Console.ReadLine();
                if (decision == "E-mail" || decision == "e-mail" || decision == "Email" || decision == "email" )
                {
                    Console.Write("What will tour E-mail be set to?");
                    email = Console.ReadLine();
                    System.Threading.Thread.Sleep(100);
                    Console.Clear();

                    Console.WriteLine($"You just entered the email: {email}");

                }
                if (decision == "phone number" || decision == "Phone Number" || decision == "phone Number" || decision == "Phone number" )
                {
                    bool pnlenh = false;
                    while(!pnlenh)
                    {
                        Console.Write("What will tour Phone Number be set to?");
                        pn = Console.ReadLine();
                        System.Threading.Thread.Sleep(100);
                        Console.Clear();
                        int pndl = pn.Length;
                        if (pndl <= 15 && pndl >= 4)
                        {
                            Console.WriteLine($"You just entered the phone number of: {pn}");
                            pnlenh = true;
                            System.Threading.Thread.Sleep(100);
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Phone number too short or too long");
                            System.Threading.Thread.Sleep(1100);
                            Console.Clear();
                        }
                    }
                }
                if (decision == "Both" || decision == "both")
                {
                    System.Threading.Thread.Sleep(100);
                    Console.Clear();
                    Console.Write("What will tour E-mail be set to?");
                    email = Console.ReadLine();
                    System.Threading.Thread.Sleep(100);
                    Console.Clear();
                    bool pnlenh2 = false;
                    while (!pnlenh2)
                    {
                        Console.Write("What will your Phone Number be set to?");
                        pn = Console.ReadLine();
                        System.Threading.Thread.Sleep(100);
                        Console.Clear();
                        int pndl = pn.Length;
                        if (pndl <= 15 && pndl >= 4)
                        {
                            pnlenh2 = true;
                            System.Threading.Thread.Sleep(100);
                            Console.Clear();
                        }
                        else
                        {
                            Console.WriteLine("Phone number too short or too long");
                            System.Threading.Thread.Sleep(1100);
                            Console.Clear();
                        }
                    }
                    Console.WriteLine($"You just entered the email {email} and the phone number of: {pn}");
                }
                System.Threading.Thread.Sleep(5000);
                Console.Clear();
            }
                Console.WriteLine("OK, Have a nice time in here!");
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine(">Horse Walks in");
                System.Threading.Thread.Sleep(100);
                Console.Clear();
        }
    }
}

