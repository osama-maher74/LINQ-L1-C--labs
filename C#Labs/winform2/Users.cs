using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__L5_WinForm2
{
    internal class Users
    {
        public string Email { get; set; }
        public string Pasword { get; set; }
        public override string ToString()
        {
            return $"Email={Email} Pas={Pasword}";
        }

    }
}
