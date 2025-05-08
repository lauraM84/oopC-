using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopC_
{
    internal class Employee: Person //classe dipendente, eredita da person
    {
        
        public string Branch { get; set; }
        public decimal Ral { get; set; }
        public string Level { get; set; }

        public Employee(string name, string surname, int year, int month, int day, string branch): base(name, surname, year, month, day)
        {
            Branch = branch; //proprietà aggiuntiva obbligatoria
        }

        public override string ToString() //override del metodo ToString
        {
            return "impiegato" + " " + base.ToString(); //richiama il metodo ToString della classe padre
        }

        public override string Wellcome()
        {
            return "lavora, schiavo!";
        }
    }
}
