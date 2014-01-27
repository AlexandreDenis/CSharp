using System;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleIdentity
{
    class Program
    {
        /*Exemple controle d'accès*/
        /*static void Main(string[] args)
        {
            AppDomain.CurrentDomain.SetPrincipalPolicy(
            PrincipalPolicy.WindowsPrincipal);
            WindowsPrincipal principal =
            (WindowsPrincipal)Thread.CurrentPrincipal;
            WindowsIdentity identity = (WindowsIdentity)principal.Identity;
            Console.WriteLine("IdentityType: " + identity.ToString());
            Console.WriteLine("Name: {0}", identity.Name);
            Console.WriteLine("'Users'?: {0} ",
            principal.IsInRole(WindowsBuiltInRole.User));
            Console.WriteLine("'Administrators'? {0}",
            principal.IsInRole(WindowsBuiltInRole.Administrator));
            Console.WriteLine("Authenticated: {0}", identity.IsAuthenticated);
            Console.WriteLine("AuthType: {0}", identity.AuthenticationType);
            Console.WriteLine("Anonymous? {0}", identity.IsAnonymous);
            Console.WriteLine("Token: {0}", identity.Token);
            Console.ReadLine();
        }
         * */

        /*Exemple délégué asynchrone*/
        /*
        public delegate int TakesAWhileDelegate(int data, int ms);
        static void Main()
        {
            TakesAWhileDelegate d1 = TakesAWhile;
            IAsyncResult ar = d1.BeginInvoke(1, 3000, null, null);
            while (true)
            {
                Console.Write(".");
                if (ar.AsyncWaitHandle.WaitOne(50, false))
                {
                    Console.WriteLine("Can get the result now");
                    break;
                }
            }
            int result = d1.EndInvoke(ar);
            Console.WriteLine("result: {0}", result);
            Console.ReadLine();
        }

        private static int TakesAWhile(int data, int ms)
        {
            Thread.Sleep(5000);
            return 5;
        }*/

        /*Exemple Thread*/
        static void Main()
        {
            //var t1 = new Thread(ThreadMain);
           // t1.Start();
            //Console.WriteLine("This is the main thread.");
            ParallelForeach();
            Console.ReadLine();
        }

       /* static void ThreadMain()
        {
            Console.WriteLine("Running in a thread.");
        }*/

        static void ParallelForeach()
        {
            string[] data = {"zero", "one", "two",
"three", "four", "five", "six", "seven",
"eight", "nine", "ten", "eleven", "twelve"};
            ParallelLoopResult result =
            Parallel.ForEach<string>(data, s =>
            {
                Console.WriteLine(s);
            });
            Parallel.ForEach<string>(data,
            (s, pls, l) =>
            {
                Console.WriteLine("{0} {1}", s, l);
            });
        }
    }
}

/*Exemple controle d'accès à une ressource extérieure*/
/*using System.Security.AccessControl;
using System.Security.Principal;
namespace ListFileACEs
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
                return;
            string filename = args[0];
            using (FileStream stream = File.Open(filename, FileMode.Open))
            {
                FileSecurity securityDescriptor = stream.GetAccessControl();
                AuthorizationRuleCollection rules = securityDescriptor.GetAccessRules(
                true, true, typeof(NTAccount));
                foreach (AuthorizationRule rule in rules)
                {
                    var fileRule = rule as FileSystemAccessRule;
                    Console.WriteLine("Access type: {0}", fileRule.AccessControlType);
                    Console.WriteLine("Rights: {0}", fileRule.FileSystemRights);
                    Console.WriteLine("Identity: {0}", fileRule.IdentityReference.Value);
                    Console.WriteLine();
                }
            }
            Console.ReadLine();
        }
    }
}*/
