using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H_W_Mod_3_2
{
    internal sealed class Contact : IComparable<Contact>
    {
        private string name;

        private string number;

       public Contact(string number, string name = "")
        {
            this.name = name;
            this.number = number;
        }

        public string Name
        {
            get { return this.name; }
        }

        public override string ToString()
        {
            string res = $"{this.name} {this.number}";
            return res;
        }

      public int CompareTo(Contact other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }
}
