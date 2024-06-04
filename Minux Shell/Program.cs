namespace Minux_Shell
{
    internal class Program
    {
        public static string[] ROOT_DIR = { "~/minux", "~/shell", "~/var" };
        public static string[] ROOT_MINUX_DIR = { "~/minux/user", "~/minux/shelldata", "~/minux/bundles" };
        public static string[] ROOT_SHELL_DIR = { "~/shell/current", "~/shell/current/minuxshell" };
        public static string[] ROOT_VAR_DIR = { "~/var", "~/var/data", "~/var/info" };
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
            CURRENT_PATH = ROOT_DIR[0];
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

                    Console.WriteLine(echo_input);
                }

                // Command is incorrect
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(input + ": not recognized. use [help] for commands.");
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
        }
    }
}