using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Principal;
using Isima.TD.RunAs.Security;

namespace Isima.TD.RunAs
{
    public class ImpersonatedSecurityContext
    {
        private string domain;
        private string username;
        private string password;

        public ImpersonatedSecurityContext(string inUsername, string inDomain, string inPassword)
        {
            domain = inDomain;
            username = inUsername;
            password = inPassword;
        }


        public void Connexion()
        {
            try
            {
                IntPtr hToken = IntPtr.Zero;
                IntPtr hTokenDuplicate = IntPtr.Zero;

                if (NativeMethods.LogonUser(username, domain, password, (uint)NativeMethods.LogonType.LOGON32_LOGON_INTERACTIVE, (uint)NativeMethods.LogonProvider.LOGON32_PROVIDER_DEFAULT, out hToken))
                {
                    if (NativeMethods.DuplicateToken(hToken, 2, ref hTokenDuplicate))
                    {
                        WindowsIdentity windowsIdentity = new WindowsIdentity(hTokenDuplicate);
                        using (WindowsImpersonationContext impersonationContext = windowsIdentity.Impersonate())
                        {
                            Console.WriteLine("Le contexte de sécurité a été changé pour {0}", WindowsIdentity.GetCurrent().Name);

                            impersonationContext.Undo();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Authentication failed for {0}\\{1}.", domain, username);
                }

                if (hToken != IntPtr.Zero) NativeMethods.CloseHandle(hToken);
                if (hTokenDuplicate != IntPtr.Zero) NativeMethods.CloseHandle(hTokenDuplicate);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("An error occurred: {0}", ex);
            }
        }
    }
}
