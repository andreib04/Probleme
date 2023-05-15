using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace set2
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Introduceti numarul problemei: ");
            int a = int.Parse(Console.ReadLine());
            if (a == 1) P01();
            if (a == 2) P02();
            if (a == 3) P03();
            if(a==4) P04();
            if(a==5) P05();
            if(a==6) P06();
            if(a==7)P07();
            if(a==8)P08();
            if(a==9) P09();
            if(a==10)P10();
            if (a == 11) P11();
            if (a == 12) P12();
            if (a == 13) P13();
            if(a==14) P14();
            if (a == 15) P15();
            if(a == 16) P16();
            if (a == 17) P17();
        } 

        

        private static void P01()
        {
            Console.WriteLine("Se da o secventa de n numere. Sa se determine cate din ele sunt pare. ");
            Console.Write("Cate numere doriti sa aiba secventa: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduceti {n} numere, fiecare numar pe alt rand:");
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x % 2 == 0)
                    counter++;
            }
            Console.WriteLine($"In secventa sunt {counter} numere pare!");
            Main();
        }
        private static void P02()
        {
            Console.WriteLine("Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. ");
            Console.Write("Cate numere doriti sa aiba secventa: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduceti {n} numere, fiecare pe alt rand: ");
            int z = 0, neg = 0, p = 0;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x == 0)
                    z++;
                if (x > 0)
                    p++;
                if (x < 0)
                    neg++;
            }
            Console.WriteLine($"In secventa sunt {z} numere 0, {p} numere pozitive si {neg} numere negative!");
            Main();
        }

        private static void P03()
        {
            Console.WriteLine("Calculati suma si produsul numerelor de la 1 la n.");

            Console.Write("Introduceti numarul = ");
            int n = int.Parse(Console.ReadLine());
            int gauss = n * (n + 1) / 2;
            Console.WriteLine($"Suma numerelor de la 1 la {n} este {gauss}");
            decimal produs = 1;
            for (int i = 1; i <= n; i++)
            {
                produs *= i;
            }
            Console.WriteLine($"Produsul numerelor de la 1 la {n} este {produs}");
            Main();
        }
       
        private static void P04()
        {
            Console.WriteLine("Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1. ");
            Console.Write("Cate numere doriti sa aiba secventa = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduceti {n} numere, fiecare pe alt rand: ");
            Console.Write("Introduceti m = ");
            int m = int.Parse(Console.ReadLine());
            int aux = 0;
            for(int i = 0; i< n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x == m)
                    aux = i;
            }
            if(aux == 0)
                Console.WriteLine($"Numarul {m} nu este in secventa(-1)");
            else
                Console.WriteLine($"{m} este pe pozitia {aux} ");
            Main();
        }

        private static void P05()
        {
            Console.WriteLine("Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. Se considera ca primul element din secventa este pe pozitia 0. ");
            Console.WriteLine("Cate numere doriti sa aiba secventa = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduceti {n} numere, fiecare pe alt rand: ");
            int counter = 0;
            for(int i = 0; i< n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x == i)
                    counter++;
            }
            Console.WriteLine($"{counter} numere sunt egale cu pozitia pe care apar in secventa");
            Main();
        }

        private static void P06()
        {
            Console.WriteLine("Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. ");
            Console.WriteLine("Cate numere doriti sa aiba secventa = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduceti {n} numere, fiecare pe alt rand: ");

            int aux = 0;
            int y = int.Parse(Console.ReadLine());
            for(int i = 1; i< n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (y > x)
                    aux = 1;
                y = x;
            }
            if(aux == 1)
                Console.WriteLine("Numerele din secventa nu sunt in ordine crescatoare!");
            else
                Console.WriteLine("Numerele din secventa sunt in ordine crescatoare!");
            Main();
        }
        private static void P07()
        {
            Console.WriteLine("Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. ");
            int n, max, min;
            Console.WriteLine("Cate numere doriti sa aiba secventa = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduceti {n} numere, fiecare pe alt rand: ");

            max= int.Parse(Console.ReadLine());
            min = max;
            for(int i = 1; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x < min)
                    min = x;
                if (x > max)
                    max = x;
            }
            Console.WriteLine($"Cel mai mare numar din secventa este {max}");
            Console.WriteLine($"Cel mai mic numar din secventa este {min}");
            Main();
        }

        private static void P08()
        {
            Console.WriteLine("Determianti al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). Exemplu: 0, 1, 1, 2, 3, 5, 8 ...");
            Console.WriteLine("Introduceti n = ");
            int n = int.Parse(Console.ReadLine());
            ulong nr0, nr1, nr2;
            nr0 = 0;
            nr1 = 1;
            nr2 = 1;
            
            for(int i =3; i<=n; i++)
            {
                nr2 = nr1 + nr0;
                nr0 = nr1;
                nr1 = nr2;
            }
            Console.WriteLine($"{nr2} este al {n} numar din sirul lui Fibonacci!");
            Main();
        }

        private static void P09()
        {
            Console.WriteLine("Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. ");
            Console.WriteLine("Cate numere doriti sa aiba secventa = ");
            int n, c = 0, d = 0;
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduceti {n} numere, fiecare pe alt rand: ");

            int y = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x > y)
                    d = 1;
                if (x < y)
                    c = 1;
                y = x;
            }
            if (d == 0)
                Console.WriteLine("Secventa este monoton descrescatoare!");
            else
            {
                if (c == 0)
                    Console.WriteLine("Secventa este monoton crescatoare!");
                else
                    Console.WriteLine("Secventa nu este monotona!");
            }
            Main();
        }

        private static void P10()
        {
            Console.WriteLine("Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa.");
            Console.WriteLine("Cate numere doriti sa aiba secventa = ");
            int s = 1, m, j;
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduceti {n} numere, fiecare pe alt rand: ");

            for(int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                m = 1;
                for(j = i+1; j<n; j++)
                {
                    int y = int.Parse(Console.ReadLine());
                    if (x == y)
                        m++;
                    else
                        break;
                }
                if (m > s)
                    s = m;
                i = j;
            }
            Console.WriteLine($"Numarul maxim de numere consecutive egale este {s}");
            Main();
        }

        private static void P11()
        {
            Console.WriteLine("Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. ");
            Console.WriteLine("Cate numere doriti sa aiba secventa = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduceti {n} numere, fiecare pe alt rand: ");

            float suma = 0;
            for(int i = 0; i<n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                suma += (float)1 / x;
            }
            Console.WriteLine($"Suma inverselor este {suma}");
            Main();
        }

        private static void P12()
        {
            Console.WriteLine("Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3. ");
            int n, counter = 0, x=0;
            Console.Write("Cate numere doriti sa aiba secventa = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduceti {n} numere, fiecare pe alt rand: ");

            int y = int.Parse(Console.ReadLine());
            for(int i = 1; i<n; i++)
            {
                 x = int.Parse(Console.ReadLine());
                if (x == 0 && y != 0)
                    counter++;
                y = x;
            }
            if (x != 0)
                counter++;
            Console.WriteLine($"In secventa sunt {counter} cuvinte!");
            Main();
        }

        private static void P13()
        {
            Console.WriteLine("O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive (rotire cu o pozitie spre stanga = toate elementele se muta cu o pozitie spre stanga si primul element devine ultimul). Determinati daca o secventa de n numere este o secventa crescatoare rotita. ");
            Console.WriteLine("Cate numere doriti sa aiba secventa = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduceti {n} numere, fiecare pe alt rand: ");
            int x=0;
            int count = 0;
            int y = int.Parse(Console.ReadLine());
            int aux = y;
            for(int i = 1; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (y > x)
                    count++;
                y = x;
            }
            if (aux < x)
                count++;
            if (count <= 1)
                Console.WriteLine("Sirul este o secventa crescatoare rotita");
            else
                Console.WriteLine("Sirul nu este o secventa crescatoare rotita");
            Main();
        }

        private static void P14()
        {
            Console.WriteLine("O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive. Determinati daca o secventa de n numere este o secventa monotona rotita. ");
            Console.WriteLine("Cate numere doriti sa aiba secventa = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduceti {n} numere, fiecare pe alt rand: ");

            int d = 0, c = 0, x = 0;
            int y = int.Parse(Console.ReadLine());
            int aux = y;
            for(int i = 1; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (y < x)
                    d++;
                if (y > x)
                    c++;
                y = x;
            }

            if (aux < x)
                c++;
            if (aux > x)
                d++;
            if (d <= 1) Console.WriteLine("Sirul este o secventa monotona descrescatoare rotita");
            else
            {
                if (c <= 1) Console.WriteLine("Sirul este o secventa monotona crescatoare rotita");
                else Console.WriteLine("Sirul nu este o secventa monotona rotita");
            }
            Main();
        }

        private static void P15()
        {
            Console.WriteLine("O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator. De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere. Sa se determine daca este bitonica. ");
            Console.WriteLine("Cate numere doriti sa aiba secventa = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduceti {n} numere, fiecare pe alt rand: ");

            int y = int.Parse(Console.ReadLine());
            int aux = 0;
            for (int i = 1; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (aux % 2 == 0)
                {
                    if (y > x)
                        aux++;
                }
                else
                {
                    if (y < x)
                        aux++;
                }
                y = x;
            }
            if (aux > 1 || aux == 0)
                Console.WriteLine("Sirul nu este o secventa bitonica");
            else
                Console.WriteLine("Sirul este o secventa bitonica");
            Main();
        }

        private static void P16()
        {
            Console.WriteLine("O <secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive (rotire = primul element devine ultimul). Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita. ");
            int n;
            Console.Write("Cate numere doriti sa aiba secventa = ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduceti {n} numere, fiecare pe alt rand: ");

            int aux = 0, y, x, rest = 0;
            y = int.Parse(Console.ReadLine());
            x = int.Parse(Console.ReadLine());
            if (y > x)
                rest = 1;
            y = x;
            for (int i = 2; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (aux % 2 == rest)
                {
                    if (y > x)
                        aux++;
                }
                else
                {
                    if (y < x)
                        aux++;
                }
                y = x;
            }
            if (aux < 3)
                Console.WriteLine("Sirul este o secventa bitonioca rotita");
            else
                Console.WriteLine("Sirul nu este o secventa bitonioca rotita");
            Main();
        }

        private static void P17()
        {
            Console.WriteLine("Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa. Determinati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, determinati nivelul maxim de incuibare a parantezelor. De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta. ");
            Console.WriteLine("Cate numere doriti sa aiba secventa = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Introduceti {n} numere, fiecare pe alt rand: ");

            int incuibare = 0;
            int max = 0;

            for(int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x == 0)
                    incuibare++;
                else
                    incuibare--;
                if (incuibare > max)
                    max = incuibare;
                if (incuibare < 0)
                    break;
            }
            if(incuibare != 0)
                Console.WriteLine("Secventa nu este corecta");
            else
                Console.WriteLine($"Secventa este corecta si are nivelul maxim de incuibare {max}");
            Main();
        }

    }
}
