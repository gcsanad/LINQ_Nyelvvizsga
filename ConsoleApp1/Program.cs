//1.Feladat
using ConsoleApp1;
using System.Text;
using System.Text.Unicode;

string[] sikeresek = File.ReadAllLines("sikeres.csv", Encoding.UTF8);
string[] sikertelen = File.ReadAllLines("sikertelen.csv", Encoding.UTF8);
List<Nyelvvizsga> osszesitve = new List<Nyelvvizsga>();
for (int index = 0; index < sikeresek.Length; index++)
{
    osszesitve.Add(new Nyelvvizsga(sikeresek[index], sikertelen[index]));
}

//2.Feladat
var legnepszerubbNyelvek = osszesitve.OrderByDescending(x => x.osszesitve).Take(3).ToList();
Console.WriteLine("2. feladat: A legnépszerűbb nyelvek:");
foreach (var elem in legnepszerubbNyelvek)
{
    Console.WriteLine(elem.nyelv);
}

//3.Feladat
Console.WriteLine("3. feladat");
Console.Write("Adjon meg egy évszámot!");
int evszam = Convert.ToInt32(Console.ReadLine());
if (evszam !> 2009 || evszam !< 2017)
{
    do
    {
        Console.Write("Hibás évszám, kérem adjon másikat!");
        evszam = Convert.ToInt32(Console.ReadLine());
    } while (evszam !> 2009 || evszam !< 2017);
}

//4.Feladat
