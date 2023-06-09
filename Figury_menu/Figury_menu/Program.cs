using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Figury_menu
{
    class Figury
    {
        private string typ_figury { get; set; }
        private static int liczba_figur = 0;
        private static int liczba_kwadratow = 0;
        private static int liczba_prostokatow = 0;
        private static int liczba_trojkatow = 0;
        private static int liczba_rombow = 0;
        private static int liczba_rownoleglobokow = 0;
        private static int liczba_trapezow = 0;
        private static int liczba_kol = 0;
        //private static IDictionary<int, string> Lista = new Dictionary<int,string>();
        //private static IDictionary<int, string> ListaV2 = new Dictionary<int,string>();
        //private static int ilość;
        //private static object wybór;
        //private static Figury[] figury;
        private static Kwadrat kwadrat;
        private static Prostokąt prostokąt;
        private static Trójkąt trójkąt;
        private static Równoległobok równoległobok;
        private static Romb romb;
        private static Trapez trapez;
        private static Koło koło;
        private static string typ = "";
        //private static int id_wybranego = 0;
        private static string nazwa_wybranego = "";
        //private static Figury[] wybranaFigura;


        public static void Informacje()
        {
            Console.WriteLine($"liczba figur: {liczba_figur}");
            Console.WriteLine($"liczba kwadratów: {liczba_kwadratow}");
            Console.WriteLine($"liczba prostokątów: {liczba_prostokatow}");
            Console.WriteLine($"liczba trójkątów: {liczba_trojkatow}");
            Console.WriteLine($"liczba rombów: {liczba_rombow}");
            Console.WriteLine($"liczba równoległoboków: {liczba_rownoleglobokow}");
            Console.WriteLine($"liczba trapezów: {liczba_trapezow}");
            Console.WriteLine($"liczba kół: {liczba_kol}");
            Console.WriteLine();
        }
        

        
        public Figury(string typ)
        {
            this.typ_figury = typ;
            liczba_figur += 1;
            switch (typ)
            {
                case "kwadrat":
                    liczba_kwadratow += 1;
                    break;
                case "prostokąt":
                    liczba_prostokatow += 1;
                    break;
                case "trójkąt":
                    liczba_trojkatow += 1;
                    break;
                case "romb":
                    liczba_rombow += 1;
                    break;
                case "równoległobok":
                    liczba_rownoleglobokow += 1;
                    break;
                case "trapez":
                    liczba_trapezow += 1;
                    break;
                case "koło":
                    liczba_kol += 1;
                    break;
            }
        }
        public static void Menu()
        {
            bool war = true;
            bool war_p = true;
            //int ile;
            bool tworzenie = true;
            while (war)
            {
                Console.WriteLine("1 - Utwórz figurę:\n\n\t'kwadrat'\n\t'prostokąt'\n\t'trójkąt'\n\t'równoległobok'\n\t'romb'\n\t'trapez'\n\t'koło'");
                Console.WriteLine();
                //Console.WriteLine("B - Wybierz figurę");
                //Console.WriteLine();
                Console.WriteLine("2 - Oblicz obwód figury");
                Console.WriteLine();
                Console.WriteLine("3 - Oblicz pole figury");
                Console.WriteLine();
                Console.WriteLine("4 - Pokaż informacje dotyczące ilości utworzonych figur");
                Console.WriteLine();
                Console.WriteLine("5 - Koniec programu");
                Console.WriteLine();
                Console.Write("Wybór: ");
                string wybór = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();
                switch (wybór)
                {
                    case "1":
                                   while (war_p)
                        {
                            /*  kwadraty = new Kwadrat[1];
                                    prostokąty = new Prostokąt[1];
                                    trójkąty = new Trójkąt[1];
                                    równoległoboki = new Równoległobok[1];
                                    romby = new Romb[1];
                                    trapezy = new Trapez[1];
                                    koła = new Koło[1]; */
                            Console.WriteLine("Podaj nazwę figury:");
                            //string nazwa_f = Console.ReadLine();
                            nazwa_wybranego = Console.ReadLine();
                            Console.WriteLine("Podaj typ figury:");
                            //string typ_f = Console.ReadLine();
                            typ = Console.ReadLine();
                            switch (typ)
                            {
                                case "kwadrat":
                                    Console.WriteLine("Podaj a:");
                                    double a_kw = double.Parse(Console.ReadLine());
                                    //Lista.Add(0, nazwa_wybranego);
                                    //ListaV2.Add(0, (string)typ);
                                    kwadrat = new Kwadrat(a_kw);
                                    war_p = false;
                                    Console.WriteLine();
                                    break;
                                case "prostokąt":
                                    Console.WriteLine("Podaj a:");
                                    double a_p = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Podaj b:");
                                    double b_p = double.Parse(Console.ReadLine());
                                    //Lista.Add(0, nazwa_wybranego);
                                    //ListaV2.Add(0, (string)typ);
                                    prostokąt = new Prostokąt(a_p, b_p);
                                    war_p = false;
                                    Console.WriteLine();
                                    break;
                                case "trójkąt":
                                    Console.WriteLine("Podaj a:");
                                    double a_t = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Podaj h:");
                                    double h_t = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Podaj b:");
                                    double b_t = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Podaj c:");
                                    double c_t = double.Parse(Console.ReadLine());
                                    //Lista.Add(0, nazwa_wybranego);
                                    //ListaV2.Add(0, (string)typ);
                                    trójkąt = new Trójkąt(a_t, h_t, b_t, c_t);
                                    war_p = false;
                                    Console.WriteLine();
                                    break;
                                case "równoległobok":
                                    Console.WriteLine("Podaj a:");
                                    double a_r = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Podaj h:");
                                    double h_r = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Podaj b:");
                                    double b_r = double.Parse(Console.ReadLine());
                                    //Lista.Add(0, nazwa_wybranego);
                                    //ListaV2.Add(0, (string)typ);
                                    równoległobok = new Równoległobok(a_r, h_r, b_r);
                                    war_p = false;
                                    Console.WriteLine();
                                    break;
                                case "romb":
                                    Console.WriteLine("Podaj a:");
                                    double a_ro = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Podaj e:");
                                    double e_ro = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Podaj f:");
                                    double f_ro = double.Parse(Console.ReadLine());
                                    //Lista.Add(0, nazwa_wybranego);
                                    //ListaV2.Add(0, (string)typ);
                                    romb = new Romb(a_ro, e_ro, f_ro);
                                    war_p = false;
                                    Console.WriteLine();
                                    break;
                                case "trapez":
                                    Console.WriteLine("Podaj a:");
                                    double a_tr = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Podaj b:");
                                    double b_tr = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Podaj y:");
                                    double y_tr = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Podaj x:");
                                    double x_tr = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Podaj h:");
                                    double h_tr = double.Parse(Console.ReadLine());
                                    //Lista.Add(0, nazwa_wybranego);
                                    //ListaV2.Add(0, (string)typ);
                                    trapez = new Trapez(a_tr, b_tr, y_tr, x_tr, h_tr);
                                    war_p = false;
                                    Console.WriteLine();
                                    break;
                                case "koło":
                                    Console.WriteLine("Podaj r:");
                                    double r = double.Parse(Console.ReadLine());
                                    //Lista.Add(0, nazwa_wybranego);
                                    //ListaV2.Add(0, (string)typ);
                                    koło = new Koło(r);
                                    war_p = false;
                                    Console.WriteLine();
                                    break;
                                default:
                                    Console.WriteLine("Błąd!!!\nNiewłaściwy typ figury!");
                                    Console.ReadKey();
                                    break;




                            
                        }
                                
                                  
                                    }
                        Console.WriteLine();
                        tworzenie = false;
                        war_p = true;
                        
                        
                        break;
                    /*case "B":
                        if(tworzenie == false)
                        {
                            
                            Console.WriteLine("Wybierz Figurę:");
                            Console.WriteLine();
                            for (int i = 0; i < ilość; i++)
                                {
                                    Console.WriteLine($"\t{Lista[i]}");
                                }
                            Console.WriteLine() ;
                            Console.Write("Wybór: ");
                            nazwa_wybranego = Console.ReadLine();
                            Console.WriteLine();
                            for (int i = 0; i < ilość; i++)
                            {
                                if(nazwa_wybranego == Lista[i])
                                {
                                    id_wybranego = i;
                                    typ = ListaV2[i];
                                    Console.WriteLine(id_wybranego);
                                    switch (typ)
                                    {
                                        case "kwadrat":
                                            wybranaFigura[i] = kwadraty[i];
                                            break;
                                        case "prostokąt":
                                            wybranaFigura[i] = prostokąty[i];
                                            break;
                                        case "trójkąt":
                                            wybranaFigura[i] = trójkąty[i];
                                            break;
                                        case "równoległobok":
                                            wybranaFigura[i] = równoległoboki[i];
                                            break;
                                        case "romb":
                                            wybranaFigura[i] = romby[i];
                                            break;
                                        case "trapez":
                                            wybranaFigura[i] = trapezy[i];

                                            break;
                                        case "koło":
                                            wybranaFigura[i] = koła[i];
                                            break;

                                        default:
                                            Console.WriteLine("Nie wybrano odpowiedniej figury!");
                                            Console.WriteLine();
                                            Console.ReadLine();
                                            break;
                                    }
                                }
                            }
                            

                        }
                        

                        else
                        {
                            Console.WriteLine("Błąd!!!\nNie znaleziono figur!");
                            Console.WriteLine();
                            Console.ReadKey();
                        }
                        
                        break;*/
                    case "2":
                        if (tworzenie == false)
                        {
                            switch (typ)
                            {
                                case "kwadrat":
                                    Console.WriteLine("Obwód {0} wynosi: {1}", nazwa_wybranego, kwadrat.obw()); ;
                                    Console.WriteLine();
                                    Console.ReadKey();
                                    break;
                                case "prostokąt":
                                    Console.WriteLine("Obwód {0} wynosi: {1}", nazwa_wybranego, prostokąt.obw());
                                    Console.WriteLine();
                                    Console.ReadKey();
                                    break;
                                case "trójkąt":
                                    Console.WriteLine("Obwód {0} wynosi: {1}", nazwa_wybranego, trójkąt.obw());
                                    Console.WriteLine();
                                    Console.ReadKey();
                                    break;
                                case "równoległobok":
                                    Console.WriteLine("Obwód {0} wynosi: {1}", nazwa_wybranego, równoległobok.obw());
                                    Console.WriteLine();
                                    Console.ReadKey();
                                    break;
                                case "romb":
                                    Console.WriteLine("Obwód {0} wynosi: {1}", nazwa_wybranego, romb.obw());
                                    Console.WriteLine();
                                    Console.ReadKey();
                                    break;
                                case "trapez":
                                    
                                    Console.WriteLine("Obwód {0} wynosi: {1}", nazwa_wybranego, trapez.obw());
                                    Console.WriteLine();
                                    Console.ReadKey();

                                    break;
                                case "koło":
                                    Console.WriteLine("Obwód {0} wynosi: {1}", nazwa_wybranego, koło.obw());
                                    Console.WriteLine();
                                    Console.ReadKey();
                                    break;

                                default:
                                    Console.WriteLine("Nie wybrano odpowiedniej figury!");
                                    Console.WriteLine();
                                    Console.ReadLine();
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Błąd!!!\nNajpierw utwórz figury!");
                            Console.WriteLine();
                            Console.ReadKey();
                        }
                        break;
                    case "3":
                        if (tworzenie == false)
                        {
                            switch (typ)
                            {
                                case "kwadrat":
                                    
                                    Console.WriteLine("Pole {0} wynosi: {1}", nazwa_wybranego, kwadrat.pole());
                                    Console.WriteLine();
                                    Console.ReadKey();
                                    break;
                                case "prostokąt":
                                    Console.WriteLine("Pole {0} wynosi: {1}", nazwa_wybranego, prostokąt.pole());
                                    Console.WriteLine();
                                    Console.ReadKey();
                                    break;
                                case "trójkąt":
                                    Console.WriteLine("Pole {0} wynosi: {1}", nazwa_wybranego, trójkąt.pole());
                                    Console.WriteLine();
                                    Console.ReadKey();
                                    break;
                                case "równoległobok":
                                    Console.WriteLine("Pole {0} wynosi: {1}", nazwa_wybranego, równoległobok.pole());
                                    Console.WriteLine();
                                    Console.ReadKey();
                                    break;
                                case "romb":
                                    Console.WriteLine("Pole {0} wynosi: {1}", nazwa_wybranego, romb.pole());
                                    Console.WriteLine();
                                    Console.ReadKey();
                                    break;
                                case "trapez":
                                    Console.WriteLine("Pole {0} wynosi: {1}", nazwa_wybranego, trapez.pole());
                                    Console.WriteLine();
                                    Console.ReadKey();

                                    break;
                                case "koło":
                                    Console.WriteLine("Pole {0} wynosi: {1}", nazwa_wybranego, koło.pole());
                                    Console.WriteLine();
                                    Console.ReadKey();
                                    break;

                                default:
                                    Console.WriteLine("Nie wybrano odpowiedniej figury!");
                                    Console.WriteLine();
                                    Console.ReadLine();
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Błąd!!!\nNajpierw utwórz figury!");
                            Console.WriteLine();
                            Console.ReadKey();
                        }
                        break;

                    case "4":
                        Figury.Informacje();
                        Console.WriteLine();
                        Console.ReadKey ();
                        break;
                    case "5":
                        war = false;
                        break;
                }
            }
        }  
    }
    class Kwadrat : Figury
    {
        private double a;
        public double obw()
        {
            return 4 * a;
        }
        public double pole()
        {
            return Math.Pow(a, 2);
        }
        public Kwadrat(double a) : base("kwadrat")
        {
            this.a = a;
        }
    }
    class Prostokąt : Figury
    {
        private double a;
        private double b;
        public Prostokąt(double a, double b) : base("prostokąt")
        {
            this.a = a;
            this.b = b;
        }
        public double obw()
        {
            return (2*a)+(2*b);
        }
        public double pole()
        {
            return b*a;
        }
    }
    class Trójkąt : Figury
    {
        private double a;
        private double h;
        private double b;
        private double c;
        public Trójkąt(double a, double h, double b, double c) : base("trójkąt")
        {
            this.a = a;
            this.h = h;
            this.b = b;
            this.c = c;
        }
        public double obw()
        {
            return a +c+b;
        }
        public double pole()
        {
            return 0.5*a*h;
        }
    }
    class Romb : Figury
    {
        private double a;
        private double e;
        private double f;
        public Romb(double a, double e, double f) : base("romb")
        {
            this.a = a;
            this.e = e;
            this.f = f;
        }
        public double obw()
        {
            return 4*a;
        }
        public double pole()
        {
            return 0.5 * e * f;
        }
    }
    class Równoległobok : Figury
    {
        private double a;
        private double h;
        private double b;
        public Równoległobok(double a, double h, double b) : base("równoległobok")
        {
            this.a = a;
            this.h = h;
            this.b = b;
        }
        public double obw()
        {
            return 2*(a+b);
        }
        public double pole()
        { return a*h;}
    }
    class Trapez : Figury
    {
        private double a;
        private double b;
        private double y;
        private double x;
        private double h;
        public Trapez(double a, double b, double y, double x, double h) : base("trapez")
        {
            this.a = a;
            this.b = b;
            this.y = y;
            this.x = x;
            this.h = h;
        }
        public double obw()
        { return a+b+y+x; }
        public double pole()
        { return 0.5*(a+b)*h;}
    }
    class Koło : Figury
    {
        private double r;
        public Koło(double r) : base("koło")
        {
            this.r = r;
        }
        public double srednica()
        { return 2 * r; }
        public double obw()
        { return 2 * Math.PI * r; }
        public double pole()
        { return Math.PI * Math.Pow(r, 2); }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Figury.Menu();
            Console.ReadKey();
        }
    }
}
