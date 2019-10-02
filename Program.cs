using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzamGuesser
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("01101000 01110100 01110100 01110000 01110011 00111010 00101111 00101111 01110111 01110111 01110111 00101110 01111001 01101111 01110101 01110100 01110101 01100010 01100101 00101110 01100011 01101111 01101101 00101111 01110111 01100001 01110100 01100011 01101000 00111111 01110110 00111101 01100100 01010001 01110111 00110100 01110111 00111001 01010111 01100111 01011000 01100011 01010001 (nyomj meg egy gombot)");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Üdv! Egy mesterséges intelligencia vagyok a jövőből");
            Console.WriteLine("Gondolj egy számra 1 és 100 között, és én kitalálom maximum 8 kérdésből");
            Console.WriteLine("Kevesebből is menne, de nem tökéletességre, hanem kreativitásra programoztak!");
            Console.WriteLine("Nyomj meg egy gombot, ha megvan a szám");
            Console.WriteLine();
            Console.Write("A szám 50 vagy nagyobb?(I/N) ");
            string a = Console.ReadLine();
            if (a == "I" ^ a == "i")
            {
                Console.Write("A szám páros?(I/N) ");
                string b = Console.ReadLine();
                if (b == "I" ^ b == "i")
                {
                    Console.Write("A szám számjegyeinek összege páros?(I/N) ");
                    string c = Console.ReadLine();
                    if (c == "I" ^ c == "i")
                    {
                        Console.Write("A szám 3-mal osztható maradék nélkül?(I/N) ");
                        string d = Console.ReadLine();
                        if (d == "I" ^ d == "i")
                        {
                            Console.Write("A szám számjegyei azonosak?(I/N) ");
                            string e = Console.ReadLine();
                            if (e == "I" ^ e == "i")
                            {
                                Console.WriteLine("A szám, amire gondoltál: 66");
                                Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                Console.WriteLine("Viszlát a jövőben!");
                            }
                            else if (e == "N" ^ e == "n")
                            {
                                Console.Write("A szám 10-el maradék nélkül osztható?(I/N) ");
                                string f = Console.ReadLine();
                                if (f == "I" ^ f == "i")
                                {
                                    Console.WriteLine("A szám, amire gondoltál: 60");
                                    Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                    Console.WriteLine("Viszlát a jövőben!");
                                }
                                else if (f == "N" ^ f == "n")
                                {
                                    Console.WriteLine("A szám, amire gondoltál: 84");
                                    Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                    Console.WriteLine("Viszlát a jövőben!");
                                }
                                else
                                {
                                    await Task.Delay(TimeSpan.FromSeconds(2));
                                    Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                await Task.Delay(TimeSpan.FromSeconds(2));
                                Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                Console.ReadKey();
                            }
                        }
                        else if (d == "N" ^ d == "n")
                        {
                            Console.Write("A számban szerepel 8-as számjegy?(I/N) ");
                            string aa = Console.ReadLine();
                            if (aa == "I" ^ aa == "i")
                            {
                                Console.Write("Le lehet írni a számot 6-os számjegy nélkül?(I/N) ");
                                string ab = Console.ReadLine();
                                if (ab == "I" ^ ab == "i")
                                {
                                    Console.Write("A szám 10-el maradék nélkül osztható?(I/N) ");
                                    string f = Console.ReadLine();
                                    if (f == "I" ^ f == "i")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 80");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else if (f == "N" ^ f == "n")
                                    {
                                        Console.Write("A szám számjegyei azonosak?(I/N) ");
                                        string fa = Console.ReadLine();
                                        if (fa == "I" ^ fa == "i")
                                        {
                                            Console.WriteLine("A szám, amire gondoltál: 88");
                                            Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                            Console.WriteLine("Viszlát a jövőben!");
                                        }
                                        else if (fa == "N" ^ fa == "n")
                                        {
                                            Console.WriteLine("A szám, amire gondoltál: 82");
                                            Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                            Console.WriteLine("Viszlát a jövőben!");
                                        }
                                        else
                                        {
                                            await Task.Delay(TimeSpan.FromSeconds(2));
                                            Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                            Console.ReadKey();
                                        }
                                    }
                                    else
                                    {
                                        await Task.Delay(TimeSpan.FromSeconds(2));
                                        Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                        Console.ReadKey();
                                    }
                                }
                                else if (ab == "N" ^ ab == "n")
                                {
                                    Console.Write("A számhoz hozzáadva egyet egy népszerű szexpóz" +
                                        "elnevezése jön ki?(I/N) ");
                                    string fq = Console.ReadLine();
                                    if (fq == "I" ^ fq == "i")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 68");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else if (fq == "N" ^ fq == "n")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 86");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else
                                    {
                                        await Task.Delay(TimeSpan.FromSeconds(2));
                                        Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                    await Task.Delay(TimeSpan.FromSeconds(2));
                                    Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                    Console.ReadKey();
                                }
                            }
                            else if (aa == "N" ^ aa == "n")
                            {
                                Console.Write("A szám osztója 1000000-nak?(I/N) ");
                                string f = Console.ReadLine();
                                if (f == "I" ^ f == "i")
                                {
                                    Console.WriteLine("A szám, amire gondoltál: 64");
                                    Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                    Console.WriteLine("Viszlát a jövőben!");
                                }
                                else if (f == "N" ^ f == "n")
                                {
                                    Console.WriteLine("A szám, amire gondoltál: 62");
                                    Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                    Console.WriteLine("Viszlát a jövőben!");
                                }
                                else
                                {
                                    await Task.Delay(TimeSpan.FromSeconds(2));
                                    Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                await Task.Delay(TimeSpan.FromSeconds(2));
                                Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            await Task.Delay(TimeSpan.FromSeconds(2));
                            Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                            Console.ReadKey();
                        }
                    }
                    else if (c == "N" ^ c == "n")
                    {
                        Console.Write("A szám 3-mal maradék nélkül osztható?(I/N) ");
                        string f = Console.ReadLine();
                        if (f == "I" ^ f == "i")
                        {
                            Console.Write("Van a számban 7-es számjegy?(I/N) ");
                            string fe = Console.ReadLine();
                            if (fe == "I" ^ fe == "i")
                            {
                                Console.Write("A szám számjegyei egymást követő számok?(I/N) ");
                                string fq = Console.ReadLine();
                                if (fq == "I" ^ fq == "i")
                                {
                                    Console.WriteLine("A szám, amire gondoltál: 78");
                                    Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                    Console.WriteLine("Viszlát a jövőben!");
                                }
                                else if (fq == "N" ^ fq == "n")
                                {
                                    Console.WriteLine("A szám, amire gondoltál: 72");
                                    Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                    Console.WriteLine("Viszlát a jövőben!");
                                }
                                else
                                {
                                    await Task.Delay(TimeSpan.FromSeconds(2));
                                    Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                    Console.ReadKey();
                                }
                            }
                            else if (fe == "N" ^ fe == "n")
                            {
                                Console.Write("A szám számjegyei egymást követő számok?(I/N) ");
                                string fq = Console.ReadLine();
                                if (fq == "I" ^ fq == "i")
                                {
                                    Console.WriteLine("A szám, amire gondoltál: 54");
                                    Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                    Console.WriteLine("Viszlát a jövőben!");
                                }
                                else if (fq == "N" ^ fq == "n")
                                {
                                    Console.Write("A szám 10-el maradék nélkül osztható?(I/N) ");
                                    string fr = Console.ReadLine();
                                    if (fr == "I" ^ fr == "i")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 90");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else if (fr == "N" ^ fr == "n")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 96");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else
                                    {
                                        await Task.Delay(TimeSpan.FromSeconds(2));
                                        Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                    await Task.Delay(TimeSpan.FromSeconds(2));
                                    Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                await Task.Delay(TimeSpan.FromSeconds(2));
                                Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                Console.ReadKey();
                            }
                        }
                        else if (f == "N" ^ f == "n")
                        {
                            Console.Write("A szám első számjegye 5?(I/N) ");
                            string fq = Console.ReadLine();
                            if (fq == "I" ^ fq == "i")
                            {
                                Console.Write("A számjegyek összege egy kétjegyű szám?(I/N) ");
                                string fe = Console.ReadLine();
                                if (fe == "I" ^ fe == "i")
                                {
                                    Console.Write("A szám számjegyei egymást követő számok?(I/N) ");
                                    string fv = Console.ReadLine();
                                    if (fv == "I" ^ fv == "i")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 56");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else if (fv == "N" ^ fv == "n")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 58");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else
                                    {
                                        await Task.Delay(TimeSpan.FromSeconds(2));
                                        Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                        Console.ReadKey();
                                    }
                                }
                                else if (fe == "N" ^ fe == "n")
                                {
                                    Console.Write("A szám 10-el maradék nélkül osztható?(I/N) ");
                                    string fr = Console.ReadLine();
                                    if (fr == "I" ^ fr == "i")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 50");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else if (fr == "N" ^ fr == "n")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 52");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else
                                    {
                                        await Task.Delay(TimeSpan.FromSeconds(2));
                                        Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                    await Task.Delay(TimeSpan.FromSeconds(2));
                                    Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                    Console.ReadKey();
                                }
                            }
                            else if (fq == "N" ^ fq == "n")
                            {
                                Console.Write("A szám számjegyei egymást követő számok?(I/N) ");
                                string ft = Console.ReadLine();
                                if (ft == "I" ^ ft == "i")
                                {
                                    Console.Write("A szám a 7 egész többszöröse?(I/N) ");
                                    string fr = Console.ReadLine();
                                    if (fr == "I" ^ fr == "i")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 98");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else if (fr == "N" ^ fr == "n")
                                    {
                                        Console.Write("A szám háromjegyű?(I/N) ");
                                        string f4 = Console.ReadLine();
                                        if (f4 == "I" ^ f4 == "i")
                                        {
                                            Console.WriteLine("A szám, amire gondoltál: 100");
                                            Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                            Console.WriteLine("Viszlát a jövőben!");
                                        }
                                        else if (f4 == "N" ^ f4 == "n")
                                        {
                                            Console.WriteLine("A szám, amire gondoltál: 76");
                                            Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                            Console.WriteLine("Viszlát a jövőben!");
                                        }
                                        else
                                        {
                                            await Task.Delay(TimeSpan.FromSeconds(2));
                                            Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                            Console.ReadKey();
                                        }
                                    }
                                    else
                                    {
                                        await Task.Delay(TimeSpan.FromSeconds(2));
                                        Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                        Console.ReadKey();
                                    }
                                }
                                else if (ft == "N" ^ ft == "n")
                                {
                                    Console.Write("A számban szerepel 4-es számjegy?(I/N) ");
                                    string fr = Console.ReadLine();
                                    if (fr == "I" ^ fr == "i")
                                    {
                                        Console.Write("A szám római számokkal való leírásához szükséges az L?(I/N) ");
                                        string fg = Console.ReadLine();
                                        if (fg == "I" ^ fg == "i")
                                        {
                                            Console.WriteLine("A szám, amire gondoltál: 74");
                                            Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                            Console.WriteLine("Viszlát a jövőben!");
                                        }
                                        else if (fg == "N" ^ fg == "n")
                                        {
                                            Console.WriteLine("A szám, amire gondoltál: 94");
                                            Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                            Console.WriteLine("Viszlát a jövőben!");
                                        }
                                        else
                                        {
                                            await Task.Delay(TimeSpan.FromSeconds(2));
                                            Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                            Console.ReadKey();
                                        }
                                    }
                                    else if (fr == "N" ^ fr == "n")
                                    {
                                        Console.Write("A szám 10-el maradék nélkül osztható?(I/N) ");
                                        string fd = Console.ReadLine();
                                        if (fd == "I" ^ fd == "i")
                                        {
                                            Console.WriteLine("A szám, amire gondoltál: 70");
                                            Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                            Console.WriteLine("Viszlát a jövőben!");
                                        }
                                        else if (fd == "N" ^ fd == "n")
                                        {
                                            Console.WriteLine("A szám, amire gondoltál: 92");
                                            Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                            Console.WriteLine("Viszlát a jövőben!");
                                        }
                                        else
                                        {
                                            await Task.Delay(TimeSpan.FromSeconds(2));
                                            Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                            Console.ReadKey();
                                        }
                                    }
                                    else
                                    {
                                        await Task.Delay(TimeSpan.FromSeconds(2));
                                        Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                    await Task.Delay(TimeSpan.FromSeconds(2));
                                    Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                await Task.Delay(TimeSpan.FromSeconds(2));
                                Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            await Task.Delay(TimeSpan.FromSeconds(2));
                            Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        await Task.Delay(TimeSpan.FromSeconds(2));
                        Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                        Console.ReadKey();
                    }
                }
                if (b == "N" ^ b == "n")
                {
                    Console.Write("A szám prímszám?(I/N) ");
                    string f = Console.ReadLine();
                    if (f == "I" ^ f == "i")
                    {
                        Console.Write("A szám 3-ra vagy 9-re végződik?(I/N) ");
                        string fq = Console.ReadLine();
                        if (fq == "I" ^ fq == "i")
                        {
                            Console.Write("A szám első számjegye nagyobb a másodiknál?(I/N) ");
                            string fe = Console.ReadLine();
                            if (fe == "I" ^ fe == "i")
                            {
                                Console.Write("A szám számjegyeinek összege 10?(I/N) ");
                                string fz = Console.ReadLine();
                                if (fz == "I" ^ fz == "i")
                                {
                                    Console.WriteLine("A szám, amire gondoltál: 73");
                                    Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                    Console.WriteLine("Viszlát a jövőben!");
                                }
                                else if (fz == "N" ^ fz == "n")
                                {
                                    Console.Write("A szám római számokkal való leírásához szükség van X-re?(I/N) ");
                                    string fx = Console.ReadLine();
                                    if (fx == "I" ^ fx == "i")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 83");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else if (f == "N" ^ f == "n")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 53");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else
                                    {
                                        await Task.Delay(TimeSpan.FromSeconds(2));
                                        Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                    await Task.Delay(TimeSpan.FromSeconds(2));
                                    Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                    Console.ReadKey();
                                }
                            }
                            else if (fe == "N" ^ fe == "n")
                            {
                                Console.Write("A szám számjegyei egymást követő számok?(I/N) ");
                                string fr = Console.ReadLine();
                                if (fr == "I" ^ fr == "i")
                                {
                                    Console.WriteLine("A szám, amire gondoltál: 89");
                                    Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                    Console.WriteLine("Viszlát a jövőben!");
                                }
                                else if (fr == "N" ^ fr == "n")
                                {
                                    Console.Write("A számot betűvel leírva használjuk a 'h' betűt?(I/N) ");
                                    string fl = Console.ReadLine();
                                    if (fl == "I" ^ fl == "i")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 79");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else if (fl == "N" ^ fl == "n")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 59");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else
                                    {
                                        await Task.Delay(TimeSpan.FromSeconds(2));
                                        Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                    await Task.Delay(TimeSpan.FromSeconds(2));
                                    Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                await Task.Delay(TimeSpan.FromSeconds(2));
                                Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                Console.ReadKey();
                            }
                        }
                        else if (fq == "N" ^ fq == "n")
                        {
                            Console.Write("A számban van 7-es?(I/N) ");
                            string fr = Console.ReadLine();
                            if (fr == "I" ^ fr == "i")
                            {
                                Console.Write("A szám számjegyei egymást követő számok?(I/N) ");
                                string fe = Console.ReadLine();
                                if (fe == "I" ^ fe == "i")
                                {
                                    Console.WriteLine("A szám, amire gondoltál: 67");
                                    Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                    Console.WriteLine("Viszlát a jövőben!");
                                }
                                else if (fe == "N" ^ fe == "n")
                                {
                                    Console.Write("A számjegyek összege egy kétjegyű szám?(I/N) ");
                                    string fz = Console.ReadLine();
                                    if (fz == "I" ^ fz == "i")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 97");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else if (fz == "N" ^ fz == "n")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 71");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else
                                    {
                                        await Task.Delay(TimeSpan.FromSeconds(2));
                                        Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                    await Task.Delay(TimeSpan.FromSeconds(2));
                                    Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                    Console.ReadKey();
                                }
                            }
                            else if (fr == "N" ^ fr == "n")
                            {
                                Console.Write("A szám számjegyeinek összege egy kétjegyű szám?(I/N) ");
                                string ff = Console.ReadLine();
                                if (ff == "I" ^ ff == "i")
                                {
                                    Console.WriteLine("A szám, amire gondoltál: 91");
                                    Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                    Console.WriteLine("Viszlát a jövőben!");
                                }
                                else if (ff == "N" ^ ff == "n")
                                {
                                    Console.WriteLine("A szám, amire gondoltál: 61");
                                    Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                    Console.WriteLine("Viszlát a jövőben!");
                                }
                                else
                                {
                                    await Task.Delay(TimeSpan.FromSeconds(2));
                                    Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                await Task.Delay(TimeSpan.FromSeconds(2));
                                Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            await Task.Delay(TimeSpan.FromSeconds(2));
                            Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                            Console.ReadKey();
                        }
                    }
                    else if (f == "N" ^ f == "n")
                    {
                        Console.Write("A szám 3-ra vagy 5-re végződik?(I/N) ");
                        string fw = Console.ReadLine();
                        if (fw == "I" ^ fw == "i")
                        {
                            Console.Write("A szám számjegyeinek összege osztható 3-mal?(I/N) ");
                            string ft = Console.ReadLine();
                            if (ft == "I" ^ ft == "i")
                            {
                                Console.Write("A szám a 25 többszöröse?(I/N) ");
                                string fo = Console.ReadLine();
                                if (fo == "I" ^ fo == "i")
                                {
                                    Console.WriteLine("A szám, amire gondoltál: 75");
                                    Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                    Console.WriteLine("Viszlát a jövőben!");
                                }
                                else if (fo == "N" ^ fo == "n")
                                {
                                    Console.Write("A szám egyik számjegye duplája a másiknak?(I/N) ");
                                    string fv = Console.ReadLine();
                                    if (fv == "I" ^ fv == "i")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 63");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else if (fv == "N" ^ fv == "n")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 93");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else
                                    {
                                        await Task.Delay(TimeSpan.FromSeconds(2));
                                        Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                    await Task.Delay(TimeSpan.FromSeconds(2));
                                    Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                    Console.ReadKey();
                                }
                            }
                            else if (ft == "N" ^ ft == "n")
                            {
                                Console.Write("A szám minden számjegye páratlan?(I/N) ");
                                string fn = Console.ReadLine();
                                if (fn == "I" ^ fn == "i")
                                {
                                    Console.Write("A szám számjegyei azonosak?(I/N) ");
                                    string fj = Console.ReadLine();
                                    if (fj == "I" ^ fj == "i")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 55");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else if (fj == "N" ^ fj == "n")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 95");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else
                                    {
                                        await Task.Delay(TimeSpan.FromSeconds(2));
                                        Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                        Console.ReadKey();
                                    }
                                }
                                else if (fn == "N" ^ fn == "n")
                                {
                                    Console.Write("A szám számjegyei egymást követő számok?(I/N) ");
                                    string f4 = Console.ReadLine();
                                    if (f4 == "I" ^ f4 == "i")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 65");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else if (f4 == "N" ^ f4 == "n")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 85");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else
                                    {
                                        await Task.Delay(TimeSpan.FromSeconds(2));
                                        Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                    await Task.Delay(TimeSpan.FromSeconds(2));
                                    Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                await Task.Delay(TimeSpan.FromSeconds(2));
                                Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                Console.ReadKey();
                            }
                        }
                        else if (fw == "N" ^ fw == "n")
                        {
                            Console.Write("A szám első számjegye nagyobb a másodiknál?(I/N) ");
                            string fh = Console.ReadLine();
                            if (fh == "I" ^ fh == "i")
                            {
                                Console.Write("A szám megegyezik egy titkos amerikai körzettel, ami az űrlényekkel hozható kapcsolatba?(I/N) ");
                                string f7 = Console.ReadLine();
                                if (f7 == "I" ^ f7 == "i")
                                {
                                    Console.WriteLine("A szám, amire gondoltál: 51");
                                    Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                    Console.WriteLine("Viszlát a jövőben!");
                                }
                                else if (f7 == "N" ^ f7 == "n")
                                {
                                    Console.Write("A szám számjegyei egymást követő számok?(I/N) ");
                                    string fn = Console.ReadLine();
                                    if (fn == "I" ^ fn == "i")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 87");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else if (fn == "N" ^ fn == "n")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 81");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else
                                    {
                                        await Task.Delay(TimeSpan.FromSeconds(2));
                                        Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                    await Task.Delay(TimeSpan.FromSeconds(2));
                                    Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                    Console.ReadKey();
                                }
                            }
                            else if (fh == "N" ^ fh == "n")
                            {
                                Console.Write("A szám számjegyei azonosak?(I/N) ");
                                string fb = Console.ReadLine();
                                if (fb == "I" ^ fb == "i")
                                {
                                    Console.Write("A szám egy híján egy háromjegyű szám?(I/N) ");
                                    string fi = Console.ReadLine();
                                    if (fi == "I" ^ fi == "i")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 99");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else if (fi == "N" ^ fi == "n")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 77");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else
                                    {
                                        await Task.Delay(TimeSpan.FromSeconds(2));
                                        Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                        Console.ReadKey();
                                    }
                                }
                                else if (fb == "N" ^ fb == "n")
                                {
                                    Console.Write("A szám egy szexpózt is jelent?(I/N) ");
                                    string fz = Console.ReadLine();
                                    if (fz == "I" ^ fz == "i")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 69");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else if (fz == "N" ^ fz == "n")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 57");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else
                                    {
                                        await Task.Delay(TimeSpan.FromSeconds(2));
                                        Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                        Console.ReadKey();
                                    }

                                }
                                else
                                {
                                    await Task.Delay(TimeSpan.FromSeconds(2));
                                    Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                await Task.Delay(TimeSpan.FromSeconds(2));
                                Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            await Task.Delay(TimeSpan.FromSeconds(2));
                            Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        await Task.Delay(TimeSpan.FromSeconds(2));
                        Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                        Console.ReadKey();
                    }
                }
                else
                {
                    await Task.Delay(TimeSpan.FromSeconds(2));
                    Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                    Console.ReadKey();
                }
            }
            else if (a == "N" ^ a == "n")
            {
                Console.Write("A szám páros?(I/N) ");
                string f = Console.ReadLine();
                if (f == "I" ^ f == "i")
                {
                    Console.Write("A szám prímszám?(I/N) ");
                    string fa = Console.ReadLine();
                    if (fa == "I" ^ fa == "i")
                    {
                        Console.WriteLine("A szám, amire gondoltál: 2");
                        Console.WriteLine("Nem izzasztottál meg igazán...");
                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                        Console.WriteLine("Viszlát a jövőben!");
                    }
                    else if (fa == "N" ^ fa == "n")
                    {
                        Console.Write("A szám első számjegye nagyobb vagy egyenlő, mint a második?(I/N) ");
                        string fh = Console.ReadLine();
                        if (fh == "I" ^ fh == "i")
                        {
                            Console.Write("A szám 0-ra végződik?(I/N) ");
                            string fn = Console.ReadLine();
                            if (fn == "I" ^ fn == "i")
                            {
                                Console.Write("Van annyi nap februárban, mint ez a szám?(I/N) ");
                                string ff = Console.ReadLine();
                                if (ff == "I" ^ ff == "i")
                                {
                                    Console.Write("A szám a legkisebb pozitív egész kétjegyű szám?(I/N) ");
                                    string fx = Console.ReadLine();
                                    if (fx == "I" ^ fx == "i")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 10");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else if (f == "N" ^ f == "n")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 20");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else
                                    {
                                        await Task.Delay(TimeSpan.FromSeconds(2));
                                        Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                        Console.ReadKey();
                                    }
                                }
                                else if (ff == "N" ^ ff == "n")
                                {
                                    Console.Write("A szám 1000000 osztója?(I/N) ");
                                    string fu = Console.ReadLine();
                                    if (fu == "I" ^ fu == "i")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 40");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else if (fu == "N" ^ fu == "n")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 30");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else
                                    {
                                        await Task.Delay(TimeSpan.FromSeconds(2));
                                        Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                    await Task.Delay(TimeSpan.FromSeconds(2));
                                    Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                    Console.ReadKey();
                                }
                            }
                            else if (fn == "N" ^ fn == "n")
                            {
                                Console.Write("A szám számjegyei azonosak?(I/N) ");
                                string fb = Console.ReadLine();
                                if (fb == "I" ^ fb == "i")
                                {
                                    Console.Write("A szám leírható 5 számjeggyel a bináris számrendszerben?(I/N) ");
                                    string f2 = Console.ReadLine();
                                    if (f2 == "I" ^ f2 == "i")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 22");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else if (f2 == "N" ^ f2 == "n")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 44");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else
                                    {
                                        await Task.Delay(TimeSpan.FromSeconds(2));
                                        Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                        Console.ReadKey();
                                    }
                                }
                                else if (fb == "N" ^ fb == "n")
                                {
                                    Console.Write("A szám a válasz az életet, a világmindenséget, meg mindent érintő végső kérdésre?(I/N) ");
                                    string f3 = Console.ReadLine();
                                    if (f3 == "I" ^ f3 == "i")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 42");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else if (f3 == "N" ^ f3 == "n")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 32");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else
                                    {
                                        await Task.Delay(TimeSpan.FromSeconds(2));
                                        Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                    await Task.Delay(TimeSpan.FromSeconds(2));
                                    Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                await Task.Delay(TimeSpan.FromSeconds(2));
                                Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                Console.ReadKey();
                            }
                        }
                        else if (fh == "N" ^ fh == "n")
                        {
                            Console.Write("A szám 4-el maradék nélkül osztható?(I/N) ");
                            string ft = Console.ReadLine();
                            if (ft == "I" ^ ft == "i")
                            {
                                Console.Write("A szám első számjegye duplája a másodiknak?(I/N) ");
                                string fk = Console.ReadLine();
                                if (fk == "I" ^ fk == "i")
                                {
                                    Console.Write("Van ennyi óra egy napban, mint ez a szám?(I/N) ");
                                    string fjj = Console.ReadLine();
                                    if (fjj == "I" ^ fjj == "i")
                                    {
                                        Console.Write("A Márciusi Ifjak ennyi pontban írták meg követeléseiket?(I/N) ");
                                        string f4 = Console.ReadLine();
                                        if (f4 == "I" ^ f4 == "i")
                                        {
                                            Console.WriteLine("A szám, amire gondoltál: 12");
                                            Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                            Console.WriteLine("Viszlát a jövőben!");
                                        }
                                        else if (f4 == "N" ^ f4 == "n")
                                        {
                                            Console.WriteLine("A szám, amire gondoltál: 24");
                                            Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                            Console.WriteLine("Viszlát a jövőben!");
                                        }
                                        else
                                        {
                                            await Task.Delay(TimeSpan.FromSeconds(2));
                                            Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                            Console.ReadKey();
                                        }
                                    }
                                    else if (fjj == "N" ^ fjj == "n")
                                    {
                                        Console.Write("A szám az első 8 pozitív egész szám összege?(I/N) ");
                                        string fl = Console.ReadLine();
                                        if (fl == "I" ^ fl == "i")
                                        {
                                            Console.WriteLine("A szám, amire gondoltál: 36");
                                            Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                            Console.WriteLine("Viszlát a jövőben!");
                                        }
                                        else if (fl == "N" ^ fl == "n")
                                        {
                                            Console.WriteLine("A szám, amire gondoltál: 48");
                                            Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                            Console.WriteLine("Viszlát a jövőben!");
                                        }
                                        else
                                        {
                                            await Task.Delay(TimeSpan.FromSeconds(2));
                                            Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                            Console.ReadKey();
                                        }
                                    }
                                    else
                                    {
                                        await Task.Delay(TimeSpan.FromSeconds(2));
                                        Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                        Console.ReadKey();
                                    }
                                }
                                else if (fk == "N" ^ fk == "n")
                                {
                                    Console.Write("A szám egyjegyű?(I/N) ");
                                    string fu = Console.ReadLine();
                                    if (fu == "I" ^ fu == "i")
                                    {
                                        Console.Write("A szám olyan, mint egy fordított végtelen?(I/N) ");
                                        string f6 = Console.ReadLine();
                                        if (f6 == "I" ^ f6 == "i")
                                        {
                                            Console.WriteLine("A szám, amire gondoltál: 8");
                                            Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                            Console.WriteLine("Viszlát a jövőben!");
                                        }
                                        else if (f6 == "N" ^ f6 == "n")
                                        {
                                            Console.WriteLine("A szám, amire gondoltál: 4");
                                            Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                            Console.WriteLine("Viszlát a jövőben!");
                                        }
                                        else
                                        {
                                            await Task.Delay(TimeSpan.FromSeconds(2));
                                            Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                            Console.ReadKey();
                                        }

                                    }
                                    else if (fu == "N" ^ fu == "n")
                                    {
                                        Console.Write("Ha annyi éves vagy, mint a szám, beengednek a dohányboltba?(I/N) ");
                                        string fq = Console.ReadLine();
                                        if (fq == "I" ^ fq == "i")
                                        {
                                            Console.WriteLine("A szám, amire gondoltál: 28");
                                            Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                            Console.WriteLine("Viszlát a jövőben!");
                                        }
                                        else if (fq == "N" ^ fq == "n")
                                        {
                                            Console.WriteLine("A szám, amire gondoltál: 16");
                                            Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                            Console.WriteLine("Viszlát a jövőben!");
                                        }
                                        else
                                        {
                                            await Task.Delay(TimeSpan.FromSeconds(2));
                                            Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                            Console.ReadKey();
                                        }

                                    }
                                    else
                                    {
                                        await Task.Delay(TimeSpan.FromSeconds(2));
                                        Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                        Console.ReadKey();
                                    }

                                }
                                else
                                {
                                    await Task.Delay(TimeSpan.FromSeconds(2));
                                    Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                    Console.ReadKey();
                                }
                            }
                            else if (ft == "N" ^ ft == "n")
                            {
                                Console.Write("A szám 6-ra végződik?(I/N) ");
                                string fc = Console.ReadLine();
                                if (fc == "I" ^ fc == "i")
                                {
                                    Console.Write("Ennyi oldala van egy kockának?(I/N) ");
                                    string fu = Console.ReadLine();
                                    if (fu == "I" ^ fu == "i")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 6");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else if (fu == "N" ^ fu == "n")
                                    {
                                        Console.Write("A szám első számjegye háromszorosa a másodiknak?(I/N) ");
                                        string fi = Console.ReadLine();
                                        if (fi == "I" ^ fi == "i")
                                        {
                                            Console.WriteLine("A szám, amire gondoltál: 26");
                                            Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                            Console.WriteLine("Viszlát a jövőben!");
                                        }
                                        else if (fi == "N" ^ fi == "n")
                                        {
                                            Console.WriteLine("A szám, amire gondoltál: 46");
                                            Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                            Console.WriteLine("Viszlát a jövőben!");
                                        }
                                        else
                                        {
                                            await Task.Delay(TimeSpan.FromSeconds(2));
                                            Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                            Console.ReadKey();
                                        }
                                    }
                                    else
                                    {
                                        await Task.Delay(TimeSpan.FromSeconds(2));
                                        Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                        Console.ReadKey();
                                    }
                                }
                                else if (fc == "N" ^ fc == "n")
                                {
                                    Console.Write("A szám második számjegye egész többszöröse az elsőnek?(I/N) ");
                                    string f9 = Console.ReadLine();
                                    if (f9 == "I" ^ f9 == "i")
                                    {
                                        Console.Write("A szám a korhatáros filmek általános besorolása?(I/N) ");
                                        string f1 = Console.ReadLine();
                                        if (f1 == "I" ^ f1 == "i")
                                        {
                                            Console.WriteLine("A szám, amire gondoltál: 18");
                                            Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                            Console.WriteLine("Viszlát a jövőben!");
                                        }
                                        else if (f1 == "N" ^ f1 == "n")
                                        {
                                            Console.WriteLine("A szám, amire gondoltál: 14");
                                            Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                            Console.WriteLine("Viszlát a jövőben!");
                                        }
                                        else
                                        {
                                            await Task.Delay(TimeSpan.FromSeconds(2));
                                            Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                            Console.ReadKey();
                                        }
                                    }
                                    else if (f9 == "N" ^ f9 == "n")
                                    {
                                        Console.Write("A szám számjegyei egymást követő számok?(I/N) ");
                                        string f4 = Console.ReadLine();
                                        if (f4 == "I" ^ f4 == "i")
                                        {
                                            Console.WriteLine("A szám, amire gondoltál: 34");
                                            Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                            Console.WriteLine("Viszlát a jövőben!");
                                        }
                                        else if (f4 == "N" ^ f4 == "n")
                                        {
                                            Console.WriteLine("A szám, amire gondoltál: 38");
                                            Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                            Console.WriteLine("Viszlát a jövőben!");
                                        }
                                        else
                                        {
                                            await Task.Delay(TimeSpan.FromSeconds(2));
                                            Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                            Console.ReadKey();
                                        }
                                    }
                                    else
                                    {
                                        await Task.Delay(TimeSpan.FromSeconds(2));
                                        Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                    await Task.Delay(TimeSpan.FromSeconds(2));
                                    Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                await Task.Delay(TimeSpan.FromSeconds(2));
                                Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            await Task.Delay(TimeSpan.FromSeconds(2));
                            Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        await Task.Delay(TimeSpan.FromSeconds(2));
                        Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                        Console.ReadKey();
                    }
                }
                else if (f == "N" ^ f == "n")
                {
                    Console.Write("A szám prímszám?(I/N) ");
                    string f1 = Console.ReadLine();
                    if (f1 == "I" ^ f1 == "i")
                    {
                        Console.Write("A szám 1-re vagy 3-ra végződik?(I/N) ");
                        string fn = Console.ReadLine();
                        if (fn == "I" ^ fn == "i")
                        {
                            Console.Write("A szám első számjegye nagyobb?(I/N) ");
                            string fb = Console.ReadLine();
                            if (fb == "I" ^ fb == "i")
                            {
                                Console.Write("A szám számjegyei egymást követő számok?(I/N) ");
                                string z = Console.ReadLine();
                                if (z == "I" ^ z == "i")
                                {
                                    Console.WriteLine("A szám, amire gondoltál: 43");
                                    Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                    Console.WriteLine("Viszlát a jövőben!");
                                }
                                else if (z == "N" ^ z == "n")
                                {
                                    Console.Write("A szám első számjegye háromszorosa a másodiknak?(I/N) ");
                                    string f6 = Console.ReadLine();
                                    if (f6 == "I" ^ f6 == "i")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 31");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else if (f6 == "N" ^ f6 == "n")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 41");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else
                                    {
                                        await Task.Delay(TimeSpan.FromSeconds(2));
                                        Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                    await Task.Delay(TimeSpan.FromSeconds(2));
                                    Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                    Console.ReadKey();
                                }
                            }
                            else if (fb == "N" ^ fb == "n")
                            {
                                Console.Write("A szám 1 szám különbséggel egy tucat?(I/N) ");
                                string fl = Console.ReadLine();
                                if (fl == "I" ^ fl == "i")
                                {
                                    Console.Write("A szám számjegyei azonosak?(I/N) ");
                                    string fz = Console.ReadLine();
                                    if (fz == "I" ^ fz == "i")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 11");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else if (fz == "N" ^ fz == "n")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 13");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else
                                    {
                                        await Task.Delay(TimeSpan.FromSeconds(2));
                                        Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                        Console.ReadKey();
                                    }
                                }
                                else if (fl == "N" ^ fl == "n")
                                {
                                    Console.Write("A szám egyjegyű?(I/N) ");
                                    string fh = Console.ReadLine();
                                    if (fh == "I" ^ fh == "i")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 3");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else if (fh == "N" ^ fh == "n")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 23");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else
                                    {
                                        await Task.Delay(TimeSpan.FromSeconds(2));
                                        Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                    await Task.Delay(TimeSpan.FromSeconds(2));
                                    Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                await Task.Delay(TimeSpan.FromSeconds(2));
                                Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                Console.ReadKey();
                            }
                        }
                        else if (fn == "N" ^ fn == "n")
                        {
                            Console.Write("A szám 7-re végződik?(I/N) ");
                            string fw = Console.ReadLine();
                            if (fw == "I" ^ fw == "i")
                            {
                                Console.Write("A szám számjegyeinek összege egyjegyű?(I/N) ");
                                string fv = Console.ReadLine();
                                if (fv == "I" ^ fv == "i")
                                {
                                    Console.Write("A szám a dobókocka szemközti oldalainak összege?(I/N) ");
                                    string fc = Console.ReadLine();
                                    if (fc == "I" ^ fc == "i")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 7");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else if (fc == "N" ^ fc == "n")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 17");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else
                                    {
                                        await Task.Delay(TimeSpan.FromSeconds(2));
                                        Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                        Console.ReadKey();
                                    }
                                }
                                else if (fv == "N" ^ fv == "n")
                                {
                                    Console.Write("A szám számjegyeinek összege 10?(I/N) ");
                                    string fe = Console.ReadLine();
                                    if (fe == "I" ^ fe == "i")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 37");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else if (fe == "N" ^ fe == "n")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 47");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else
                                    {
                                        await Task.Delay(TimeSpan.FromSeconds(2));
                                        Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                    await Task.Delay(TimeSpan.FromSeconds(2));
                                    Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                    Console.ReadKey();
                                }
                            }
                            else if (fw == "N" ^ fw == "n")
                            {
                                Console.Write("A szám egyjegyű?(I/N) ");
                                string f6 = Console.ReadLine();
                                if (f6 == "I" ^ f6 == "i")
                                {
                                    Console.WriteLine("A szám, amire gondoltál: 5");
                                    Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                    Console.WriteLine("Viszlát a jövőben!");
                                }
                                else if (f6 == "N" ^ f6 == "n")
                                {
                                    Console.Write("A szám számjegyeinek összeg 10?(I/N) ");
                                    string fg = Console.ReadLine();
                                    if (fg == "I" ^ fg == "i")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 19");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else if (fg == "N" ^ fg == "n")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 29");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else
                                    {
                                        await Task.Delay(TimeSpan.FromSeconds(2));
                                        Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                        Console.ReadKey();
                                    }

                                }
                                else
                                {
                                    await Task.Delay(TimeSpan.FromSeconds(2));
                                    Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                await Task.Delay(TimeSpan.FromSeconds(2));
                                Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            await Task.Delay(TimeSpan.FromSeconds(2));
                            Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                            Console.ReadKey();
                        }
                    }
                    else if (f1 == "N" ^ f1 == "n")
                    {
                        Console.Write("A szám 5-re végződik?(I/N) ");
                        string f7 = Console.ReadLine();
                        if (f7 == "I" ^ f7 == "i")
                        {
                            Console.Write("A szám számjegyeinek összege osztható 3-mal?(I/N) ");
                            string fj = Console.ReadLine();
                            if (fj == "I" ^ fj == "i")
                            {
                                Console.Write("A szám számjegyei egymást követő számok?(I/N) ");
                                string ft = Console.ReadLine();
                                if (ft == "I" ^ ft == "i")
                                {
                                    Console.WriteLine("A szám, amire gondoltál: 45");
                                    Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                    Console.WriteLine("Viszlát a jövőben!");
                                }
                                else if (ft == "N" ^ ft == "n")
                                {
                                    Console.WriteLine("A szám, amire gondoltál: 15");
                                    Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                    Console.WriteLine("Viszlát a jövőben!");
                                }
                                else
                                {
                                    await Task.Delay(TimeSpan.FromSeconds(2));
                                    Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                    Console.ReadKey();
                                }
                            }
                            else if (fj == "N" ^ fj == "n")
                            {
                                Console.Write("A szám a 100 osztója?(I/N) ");
                                string fz = Console.ReadLine();
                                if (fz == "I" ^ fz == "i")
                                {
                                    Console.WriteLine("A szám, amire gondoltál: 25");
                                    Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                    Console.WriteLine("Viszlát a jövőben!");
                                }
                                else if (fz == "N" ^ fz == "n")
                                {
                                    Console.WriteLine("A szám, amire gondoltál: 35");
                                    Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                    Console.WriteLine("Viszlát a jövőben!");
                                }
                                else
                                {
                                    await Task.Delay(TimeSpan.FromSeconds(2));
                                    Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                await Task.Delay(TimeSpan.FromSeconds(2));
                                Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                Console.ReadKey();
                            }
                        }
                        else if (f7 == "N" ^ f7 == "n")
                        {
                            Console.Write("A szám számjegyeinek összege osztható 3-mal?(I/N) ");
                            string f5 = Console.ReadLine();
                            if (f5 == "I" ^ f5 == "i")
                            {
                                Console.Write("A szám 25-nél nagyobb szám?(I/N) ");
                                string ff = Console.ReadLine();
                                if (ff == "I" ^ ff == "i")
                                {
                                    Console.Write("A szám számjegyei azonosak?(I/N) ");
                                    string fb = Console.ReadLine();
                                    if (fb == "I" ^ fb == "i")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 33");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else if (fb == "N" ^ fb == "n")
                                    {
                                        Console.Write("Az első számjegy harmada a másodiknak?(I/N) ");
                                        string fj = Console.ReadLine();
                                        if (fj == "I" ^ fj == "i")
                                        {
                                            Console.WriteLine("A szám, amire gondoltál: 39");
                                            Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                            Console.WriteLine("Viszlát a jövőben!");
                                        }
                                        else if (fj == "N" ^ fj == "n")
                                        {
                                            Console.WriteLine("A szám, amire gondoltál: 27");
                                            Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                            Console.WriteLine("Viszlát a jövőben!");
                                        }
                                        else
                                        {
                                            await Task.Delay(TimeSpan.FromSeconds(2));
                                            Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                            Console.ReadKey();
                                        }
                                    }
                                    else
                                    {
                                        await Task.Delay(TimeSpan.FromSeconds(2));
                                        Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                        Console.ReadKey();
                                    }
                                }
                                else if (ff == "N" ^ ff == "n")
                                {
                                    Console.Write("A szám egyjegyű?(I/N) ");
                                    string fj = Console.ReadLine();
                                    if (fj == "I" ^ fj == "i")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 9");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else if (fj == "N" ^ fj == "n")
                                    {
                                        Console.WriteLine("A szám, amire gondoltál: 21");
                                        Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                        Console.WriteLine("Viszlát a jövőben!");
                                    }
                                    else
                                    {
                                        await Task.Delay(TimeSpan.FromSeconds(2));
                                        Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                        Console.ReadKey();
                                    }
                                }
                                else
                                {
                                    await Task.Delay(TimeSpan.FromSeconds(2));
                                    Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                    Console.ReadKey();
                                }
                            }
                            else if (f5 == "N" ^ f5 == "n")
                            {
                                Console.Write("A szám egyjegyű?(I/N) ");
                                string fd = Console.ReadLine();
                                if (fd == "I" ^ fd == "i")
                                {
                                    Console.WriteLine("A szám, amire gondoltál: 1");
                                    Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                    Console.WriteLine("Viszlát a jövőben!");
                                }
                                else if (fd == "N" ^ fd == "n")
                                {
                                    Console.WriteLine("A szám, amire gondoltál: 49");
                                    Console.WriteLine("Most pedig hajolj meg mérhetetlen tudásom előtt!");
                                    Console.WriteLine("Viszlát a jövőben!");
                                }
                                else
                                {
                                    await Task.Delay(TimeSpan.FromSeconds(2));
                                    Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                    Console.ReadKey();
                                }
                            }
                            else
                            {
                                await Task.Delay(TimeSpan.FromSeconds(2));
                                Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                                Console.ReadKey();
                            }
                        }
                        else
                        {
                            await Task.Delay(TimeSpan.FromSeconds(2));
                            Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                            Console.ReadKey();
                        }
                    }
                    else
                    {
                        await Task.Delay(TimeSpan.FromSeconds(2));
                        Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                        Console.ReadKey();
                    }
                }
                else
                {
                    await Task.Delay(TimeSpan.FromSeconds(2));
                    Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                    Console.ReadKey();
                }
            }
            else
            {
                await Task.Delay(TimeSpan.FromSeconds(2));
                Console.WriteLine("Hibás adatot adtál meg, a rendszer most megsemmisíti önmagát");
                Console.ReadKey();
            }
            Console.ReadKey();
         
        }
    }
}
