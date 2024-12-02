using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketApp.Entity
{
    internal class Buyer
    {
        private int id;
        private String fullName;
        private String gmail;
        private String password;
        public int Id { get { return id; } set { id = value; } }
        public String FullName { get { return fullName; } set { fullName = value; } }   
        public String Gmail { get { return gmail; } set { gmail = value; } }    
        public String Password { get { return password; }   set { password = value; } }
    }
}
