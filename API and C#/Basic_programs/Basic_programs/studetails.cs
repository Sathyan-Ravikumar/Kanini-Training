using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_programs
{ 
    internal  class studetails
    {
        private int rno;
        private string name;
        public studetails(int rno, string name)
        {
            this.Rno = rno;
            this.Name = name;
            
        }

        public int Rno { get => rno; set => rno = value; }
        public string Name { get => name; set => name = value; }

        public virtual void show()
        {
            Console.WriteLine("Hello");
        }
    }
    
}
