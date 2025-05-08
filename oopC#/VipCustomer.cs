using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopC_
{
    internal class VipCustomer: Customer //eredita da Customer
    {
        private string NamePrefix { get; set; } //proprietà aggiuntiva
        private decimal NegativeThreshold { get; set; }
        public VipCustomer(string name, string surname, DateTime dob, string address, string email, decimal threshold) : base(name, surname, dob, address, email) //costruttore con parametri presi da padre
        {
            NamePrefix = "Sua Eccellenza"; //proprietà aggiuntiva
            NegativeThreshold = threshold; //prende il valore del parametro
        }
        public VipCustomer(string name, string surname, int year, int month, int day, string address, string email, decimal threshold) : base(name, surname, year, month, day, address, email)
        {
            NamePrefix = "Sua Eccellenza";
            NegativeThreshold = threshold; 
        }

        public override string ToString() //override del metodo ToString
        {
            return NamePrefix + " " + base.ToString(); //richiama il metodo ToString della classe padre
        }

        public override string Wellcome() //override del metodo Wellcome
        {
            return base.Wellcome() + " " + NamePrefix; //richiama il metodo Wellcome della classe padre
        }

        public override string PrintAddress() //override del metodo PrintAddress
        {
            return NamePrefix + " " + base.PrintAddress(); //richiama il metodo PrintAddress della classe padre
        }

    }
}
