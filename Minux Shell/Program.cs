namespace Minux_Shell
{
    internal class Program
    {
        public static string[] SYSTEM_DIRECTORIES = { "~/minux", "~/shell", "~/var" };
        public static string CURRENT_PATH;

        static void Main(string[] args)
        {
            string username;

            // Shell initial functions
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
        _                  
  /\/\ (_)_ __  _   ___  __
 /    \| | '_ \| | | \ \/ /
/ /\/\ \ | | | | |_| |>  < 
\/    \/_|_| |_|\__,_/_/\_\
                           
   M I N U X  S H E L L
");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Enter your username: ");
            var input = Console.ReadLine();
            username = input.ToString();
            Console.Clear();
            CURRENT_PATH = SYSTEM_DIRECTORIES[0];
            SHELL(username);
        }
        public static void SHELL(string user)
        {
            Console.WriteLine(@"

            Welcome to Minux Shell!
For better performance tap F11 to fullscreen terminal.


");
            Console.WriteLine(CURRENT_PATH);
            for (; ; )
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(user);
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.Write(" at ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write(CURRENT_PATH);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(" > ");

                string input = Console.ReadLine();

                // Shell is ready to get commands.
                if (input == "")
                {
                    continue;
                }
                else if (input == "clr" || input == "cls" || input == "clear")
                {
                    Console.Clear();
                }
                else if (input == "echo")
                {
                    Console.Write("> ");
                    string echo_input = Console.ReadLine();

                    if (echo_input == "path")
                    {
                        echo(CURRENT_PATH);
                    }
                    else if (echo_input == "sys")
                    {
                        echo("Minux-1.0");
                    }
                    else
                    {
                        echo(echo_input);
                    }
                }
                else if (input == "cd")
                {
                    Console.Write("> ");
                    string cd_input = Console.ReadLine();

                    if (cd_input == SYSTEM_DIRECTORIES[0])
                    {
                        CURRENT_PATH = SYSTEM_DIRECTORIES[0];
                    }
                    else if (cd_input == SYSTEM_DIRECTORIES[1])
                    {
                        CURRENT_PATH = SYSTEM_DIRECTORIES[1];
                    }
                    else if (cd_input == SYSTEM_DIRECTORIES[2])
                    {
                        CURRENT_PATH = SYSTEM_DIRECTORIES[2];
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        echo("Path: " + cd_input + " not found at system.\n");
                    }

                }
                else if (input == "list")
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(SYSTEM_DIRECTORIES[0] + "   ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(SYSTEM_DIRECTORIES[1] + "   ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(SYSTEM_DIRECTORIES[2] + "\n\n");
                }

                // Command is incorrect
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(input + ": not recognized. use [help] for commands.\n");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
        }

        public static void echo(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}