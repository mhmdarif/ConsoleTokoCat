using CatClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTokoCat
{
    public class loginPage : Ilogin, IRegister
    {
        public void login()
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            
        }

        public void register()
        {
            throw new NotImplementedException();
        }
    }
}
