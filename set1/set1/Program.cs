using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace set1
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Introduceti numarul problemei: ");
            int p = int.Parse(Console.ReadLine());
            if (p == 1) P01();
            if (p == 2) P02();
            if (p == 3) P03();
            if (p == 4) P04();
            if (p == 5) P05();
            if (p == 6) P06();
            if (p == 7) P07();
            if (p == 8) P08();
            if (p == 9) P09();
            if (p == 10) P10();
            if (p == 11) P11();
            if (p == 12) P12();
            if (p == 13) P13();
            if (p == 14) P14();
            if (p == 15) P15();
            if (p == 16) P16();
            if (p == 17) P17();
            if (p == 18) P18();
            if (p == 19) P19();
            if (p == 20) P20();
            if (p == 21) P21();

        }

        static void P01()
        {
            Console.WriteLine("Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. ");
            Console.WriteLine("Introduceti primul numar: ");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea numar: ");
            float b = float.Parse(Console.ReadLine());
            float x = -b / a;
            Console.WriteLine($"{x} = ");
            Console.ReadKey();
            Main();
        }

        static void P02()
        {
            Console.WriteLine("Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile. ");
            Console.Write("Introduceti o valoare pentru a = ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Introduceti o valoare pentru b = ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("Introduceti o valoare pentru c = ");
            float c = float.Parse(Console.ReadLine());
            float x1, x2;
            float delta = b * b - 4 * a * c;
            
                if (delta >= 0)
                {
                    x1 = (-b + (float)Math.Sqrt(delta)) / 2 * a;
                    x2 = (-b - (float)Math.Sqrt(delta)) / 2 * a;
                    Console.WriteLine(x1 + " " + "si" + " " + x2);
                }
                else
                {
                    Console.WriteLine("Ecuatia nu are solutii");
                }
                Console.ReadKey();
            Main();
        }

        static void P03()
        {
            Console.WriteLine("Determinati daca n se divide cu k, unde n si k sunt date de intrare. ");
            Console.Write("Introduceti o valoare pentru n = ");
            float n = float.Parse(Console.ReadLine());
            Console.Write("Introduceti o valoare pentru k = ");
            float k = float.Parse(Console.ReadLine());

            if (n % k == 0)

                Console.WriteLine($"{n} se divide cu {k}");

            else
                Console.WriteLine($"{n} nu se divide cu {k}");
            Console.ReadKey();
            Main();
        }

        static void P04()
        {
            Console.WriteLine("Detreminati daca un an y este an bisect. ");
            Console.Write("Introduceti un an: ");
            int y = int.Parse(Console.ReadLine());
            if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
            {
                Console.WriteLine($"{y} este an bisect");
            }
            else
                Console.WriteLine($"{y} nu este an bisect");
            Console.ReadKey();
            Main();
        }

        static void P05()
        {
            Console.WriteLine("Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. ");
            Console.WriteLine("Introduceti numarul: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("A cata cifra doriti sa o afisati, de la dreapta la stanga: ");
            int k = int.Parse(Console.ReadLine());

            int aux = 1;
            for (int i = 1; i < k; i++)
            {
                aux = aux * 10;
            }
            Console.WriteLine($"Cifra este {n / aux % 10}");
            Console.ReadKey();
            Main();
        }

        static void P06()
        {
            Console.WriteLine("Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. ");
            Console.Write("Introduceti o valoare pozitiva pentru a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti o valoare pozitiva pentru b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Introduceti o valoare pozitiva pentru c = ");
            int c = int.Parse(Console.ReadLine());
            if (a < b + c && b < a + c && c < b + c)
            {
                Console.WriteLine("a, b, c POT fi lungimile laturilor unui triunghi");
            }
            else
                Console.WriteLine("a, b, c NU pot fi lungimile laturilor unui triunghi");
            Console.ReadKey();
            Main();
        }

        static void P07()
        {
            Console.WriteLine("(Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor. ");
            Console.Write("Introduceti o valoare pentru x = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Introduceti o valoare pentru y = ");
            int y = int.Parse(Console.ReadLine());
            int aux;
            aux = x;
            x = y;
            y = aux;
            Console.WriteLine($"x = {x} si y= {y}");
            Console.ReadKey();
            Main();
        }

        static void P08()
        {
            Console.WriteLine("(Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare. ");
            Console.Write("Introduceti o valoare pentru a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti o valoare pentru b = ");
            int b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"a = {a} si b = {b}");
            Console.ReadKey();
            Main();
        }

        static void P09()
        {
            Console.WriteLine("Afisati toti divizorii numarului n. ");
            Console.Write("Introduceti o valoare lui n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Divizorii lui {n} sunt: ");
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    Console.Write($"{i} ");

                }
            }
            Console.ReadKey();
            Main();
        }

        static void P10()
        {
            Console.WriteLine("Test de primalitate: determinati daca un numar n este prim.");
            Console.WriteLine("Introduceti un numar n = ");
            int n;
            n = int.Parse(Console.ReadLine());

            if (n < 2)
            {
                Console.WriteLine("Nu e prim");

            }
            if (n == 2)
            {
                Console.WriteLine("E prim");

            }

            for (int d = 2; d * d <= n; d++)
            {
                if (n % d == 0)
                {
                    Console.WriteLine("Nu e prim");
                }
            }
            Console.WriteLine("E prim");
            Console.ReadKey();
            Main();
        }

        static void P11()
        {
            Console.WriteLine("Afisati in ordine inversa cifrele unui numar n.");
            Console.WriteLine("Introduceti un numar: ");
            int n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                Console.Write(n % 10);
                n = n / 10;
            }
            Console.ReadKey();
            Main();
        }

        static void P12()
        {
            Console.WriteLine("Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]. ");
            Console.WriteLine("Introduceti o valoare pentru a = ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti o valoare pentru b = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti o valoare pentru n = ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = a; i <= b; i++)
            {
                if (i % n == 0)
                {
                    count++;
                }
            }
            Console.WriteLine($"In intervalul [a,b] sunt {count} numere!");
            Console.ReadKey();
            Main();
        }

        static void P13()
        {
            Console.WriteLine("Determianti cati ani bisecti sunt intre anii y1 si y2.");
            Console.WriteLine("Introduceti primul an = ");
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea an = ");
            int y2 = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = y1; i <= y2; i++)
                if ((i % 4 == 0 && i % 100 != 0) || i % 400 == 0)
                    count++;
            Console.WriteLine("Intre " + y1 + " si " + y2 + " sunt " + count + " ani bisecti!");
            Console.ReadKey();
            Main();
        }

        static void P14()
        {
            Console.WriteLine("Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321.");
            Console.WriteLine("Introduceti un numar: ");
            int n = int.Parse(Console.ReadLine());
            int b = 0;
            for (int i = n; i > 0; i /= 10)
            {
                b = b * 10 + i % 10;
            }
            if (n == b)
            {
                Console.WriteLine($"{n} este palindrom");
            }
            else
            {
                Console.WriteLine($"{n} nu este palindrom");
            }
            Console.ReadKey();
            Main();
        }

        static void P15()
        {
            Console.WriteLine("Se dau 3 numere. Sa se afiseze in ordine crescatoare. ");
            Console.WriteLine("Introduceti primul numar = ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea numar = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al treilea numar = ");
            int c = int.Parse(Console.ReadLine());
            int aux = 0;
            if (a > b) { aux = a; a = b; b = aux; }
            if (a > c) { aux = a; a = c; c = aux; }
            if (b > c) { aux = b; b = c; c = aux; }
            Console.WriteLine(a + " " + b + " " + c);
            Main();
        }

        static void P16()
        {
            Console.WriteLine("Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)");
            Console.WriteLine("Introduceti primul numar = ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea numar = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al treilea numar = ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al patrulea numar = ");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al cincilea numar = ");
            int e = int.Parse(Console.ReadLine());
            int aux;
            if (a > b) { aux = a; a = b; b = aux; }
            if (a > c) { aux = a; a = c; c = aux; }
            if (a > d) { aux = a; a = d; d = aux; }
            if (a > e) { aux = a; a = e; e = aux; }
            if (b > c) { aux = b; b = c; c = aux; }
            if (b > d) { aux = b; b = d; d = aux; }
            if (b > e) { aux = b; b = e; e = aux; }
            if (c > d) { aux = c; c = d; d = aux; }
            if (c > e) { aux = c; c = e; e = aux; }
            if (d > e) { aux = d; d = e; e = aux; }
            Console.WriteLine(a + " " + b + " " + c + " " + d + " " + e);
            Console.ReadKey();
            Main();
        }

        static void P17()
        {
            Console.WriteLine(" Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid. ");
            Console.WriteLine("Introduceti prima valoare = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti a doua valoare = ");
            int m = int.Parse(Console.ReadLine());
            int x, y;
            x = n;
            y = m;
            while (x != y)
            {
                if (x > y)
                {
                    x = x - y;
                }
                else
                    y = y - x;
            }
            Console.WriteLine($"{x} este cel mai mare divizor comun!");

            x = n;
            y = m;
            while (x != y)
            {
                if (x < y)

                    x = x + n;

                else

                    y = y + m;

            }
            Console.WriteLine($"{x} este cel mai mic multiplu comun!");
            Main();
        }

        static void P18()
        {
            Console.WriteLine("Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1176 afisati 2^3 x 3^1 x 7^2. ");
            int n = int.Parse(Console.ReadLine());
            int p;
            for (int i = 2; i < n; i++)
            {
                p = 0;
                while (n % i == 0)
                {
                    n = n / i;
                    p++;
                }
                if (p != 0)
                    Console.Write($"{i}^{p} x ");

            }
            Main();
        }

        static void P19()
        {
            Console.WriteLine("Determinati daca un numar e format doar cu 2 cifre care se pot repeta. De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt. ");
            int n, a, b = 10, aux = 0;
            n = int.Parse(Console.ReadLine());
            a = n % 10;
            n /= 10;
            while (n > 0)
            {
                if (a == n % 10)
                    n /= 10;
                else
                {
                    b = n % 10;
                    break;
                }
            }
            n /= 10;
            while (n > 0)
            {
                if (n % 10 != a && n % 10 != b)
                {
                    aux = 1;
                    break;
                }
                else
                    n /= 10;
            }

            if (aux == 1)
                Console.WriteLine("Numarul este format din mai mult de 2 cifre");
            else
                Console.WriteLine("Numarul este format din 2 cifre");
            Console.ReadKey();
            Main();
        }

        static void P20()
        {
            Console.WriteLine("Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). Exemplu: 13/30 = 0.4(3).");
            Console.WriteLine("Introduceti primul un numar: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti al doilea numar: ");
            int n = int.Parse(Console.ReadLine());

            int parteInt, parteFract;
            parteInt = m / n;
            parteFract = m % n;
            Console.Write($"{parteInt},");
            int cifra, rest;
            List<int> resturi = new List<int>();
            List<int> cifre = new List<int>();
            resturi.Add(parteFract);
            bool periodic = false;
            do
            {
                cifra = parteFract * 10 / n;
                cifre.Add(cifra);

                rest = parteFract * 10 % n;
                if (!resturi.Contains(rest))
                {
                    resturi.Add(rest);
                }
                else
                {
                    periodic = true;
                    break;
                }
                parteFract = rest;
            } while (rest != 0);

            if (!periodic)
            {
                foreach (var item in cifre)
                {
                    Console.Write(item);
                }
            }
            else
            {
                for (int i = 0; i < resturi.Count; i++)
                {
                    if (resturi[i] == rest)
                    {
                        Console.Write("(");
                    }
                    Console.Write(cifre[i]);
                }
                Console.WriteLine(")");
            }
            Main();
        }

        static void P21()
        {
            Console.WriteLine("Ghiciti un numar intre 1 si 1024 prin intrebari de forma \"numarul este mai mare sau egal decat x?\".");
            Random random = new Random();

            int valoare = random.Next(1, 1024);

            int ghici = 0;

            string rsp1 = "da";
            string rsp2;
            string rsp3 = "nu";

            Console.WriteLine("Ghiciti un numar intre 1 si 1024!");
            for (int i = 1; i <= valoare; i++)
            {
                while (ghici != valoare)
                {
                    ghici = int.Parse(Console.ReadLine());
                    if (ghici < valoare)
                    {
                        Console.WriteLine($"Numarul este mai mare decat {ghici}!");
                    }
                    if (ghici > valoare)
                    {
                        Console.WriteLine($"Numarul este mai mic decat {ghici}!");
                    }
                    if (ghici == valoare)
                    {
                        Console.WriteLine($"Felicitari, ati ghicit numarul {ghici}!");
                    }
                }
            }
            while (ghici == valoare)
            {
                Console.WriteLine("Daca doriti sa mai jucati introduceti textul ~da~, in caz contrar introduceti textul ~nu~!");
                rsp2 = Console.ReadLine();
                if (rsp2 == rsp1)
                {
                    P21();
                    continue;
                }
                if (rsp2 == rsp3)
                {
                    break;
                }
            }
            Console.ReadLine();
            Main();
        }

       

    }
}

   

