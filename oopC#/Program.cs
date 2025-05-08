namespace oopC_ 
{
    internal class Program //classe principale
    {
        static void Main(string[] args) //programma principale
        {
            DateTime dob1 = new DateTime(2000, 12, 3); 
            var c1 = new Customer("pippo", "de pippis", dob1, "via vannucci 3, 16123, genova, Italy", "pippopippi@topoliniaonline.it" ); //questo è un cliente
            c1.Mdp = PaymentMethod.Cash; //metodo di pagamento

            var c2 = new Customer("clarabella", "de pippis", 2003, 05, 25, "via vannucci 4, 16123, genova, Italy", "clara@topoliniaonline.it"); //usa per dob il costruttore con i parametri

            var c3 = new Customer("orazio", "de pippis", new DateTime (2002, 03, 30), "via vannucci 3, 16123, genova, Italy", "orazio@topoliniaonline.it");

            var v1 = new VipCustomer("topolino", "mouse", 1990, 1, 30, "via gramsci 4, 16123, genova, italy", "spippolo@topoliniaonline.it", 10000);
            
            var e1 = new Employee("paperino", "paolino", 1980, 3, 23, "genova1"); 


           

            List<VipCustomer> vipCustomer = [];

            vipCustomer.Add(v1);

            List<Customer> customers = new List<Customer>(); //crea una lista di clienti

            customers.Add(c1);
            customers.Add(c3);
            customers.Add(v1);

            foreach (var customer in customers) //ciclo for each per stampare i clienti
            {
                Console.WriteLine(customer.PrintAddress()); //stampa il cliente
            }

            List<Person> persons = new List<Person>(); //crea una lista di persone

            persons.Add(c1);
            persons.Add(c3);
            persons.Add(v1);
            persons.Add(e1);

          

        }
    }
}
