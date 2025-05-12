using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace oopC_
{
    internal class Customer: Person // classe cliente eredita da Person
    {

        public  string Name { get; set; } 
        public  string Surname { get; set; }
        public string? Gender { get; set; }
        public  DateTime Dob { get; set; }*/
        public  string Address { get; set; }
        public string? Phone { get; set; }
        public  string Email { get; set; }
        public PaymentMethod? Mdp { get; set; }

        /*public Customer() //costruttore vuoto
        {
        }*/

        public Customer(string name, string surname, DateTime dob, string address, string email): base(name, surname, dob.Year, dob.Month, dob.Day)  //prende parametri da padre
        {           
            Address = address;           
            Email = email;           
        }

        public Customer(string name, string surname, int year, int month, int day, string address, string email): base (name, surname, year, month, day )//costruttore con parametri
        {        
            Address = address;
            Email = email;
        }

        public override string ToString() //override del metodo ToString
        {
            return "cliente" + " " + base.ToString(); //richiama il metodo ToString della classe padre
        }

        public override string Wellcome()
        {
            return "benvenuto";
        }

        public virtual string PrintAddress() //metodo virtuale, può essere sovrascritto
        {
            return Name + " " + Surname + "\n" + Address.Replace(", ", "\n"); //trova una virgola va a capo
            
        }
    }

    public enum PaymentMethod //metodo di pagamento, enum è una enumerazione
    {
        Iban,
        Cdc,
        Cash
    }
}

