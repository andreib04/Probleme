using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace vendingmachine
{
    internal class VendingMachine
    {
        static void Main(string[] args)
        {
            VendingMachine vm = new VendingMachine();

            Console.WriteLine("VENDING MACHINE\n");

            Console.WriteLine("Produsul costa 20 de centi");

            Console.WriteLine("Pentru nickel(5 centi) tastati 1");
            Console.WriteLine("Pentru dime(10 centi) tastati 2");
            Console.WriteLine("Pentru quarter(25 centi) tastati 3\n");

            Console.WriteLine("Ce moneda doriti sa introduceti: ");
            int n = int.Parse(Console.ReadLine());

            int rest;
            
                      
            if (n == 1)
            {
                vm.addNickel();
                Console.WriteLine("Ati introdus 5 centi \n" +
                    "Mai aveti nevoie de 15 centi pentru a cumpara produsul");
                    
            }
            else if(n == 2)
            {
                vm.addDime();
                Console.WriteLine("Ati introdus 10 centi \n" +
                    "Mai aveti nevoie de 10 centi pentru a cumpara produsul");
                    
                    
            }
            else if(n == 3)
            {
                vm.addQuarter();
                Console.WriteLine("Ati introdus 25 de centi");
                rest = vm.elibProd();
                Console.WriteLine("Rest: " + rest + " centi");
                    
            }

        }

        private const int pretul_produsului = 20;

        private int sumaCurenta;

        public void vendingmachine()
        {
            sumaCurenta = 0;
        }

        public void addNickel()
        {
            sumaCurenta += 5;
        }

        public void addDime()
        {
            sumaCurenta += 10;
        }

        public void addQuarter()
        {
            sumaCurenta += 25;
        }

        public int elibProd()
        {
            int rest = sumaCurenta - pretul_produsului;

            sumaCurenta = 0;

            return rest;
        }
    }
}
