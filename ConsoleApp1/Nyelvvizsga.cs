using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Nyelvvizsga
    {
        public List<int> sikeres;
        public List<int> sikertelen;
        public string nyelv;
        public List<int> osszesitve;
        public Nyelvvizsga(string elsoSor, string masodikSor)
        {
            string[] elso = elsoSor.Split(';');
            string[] masodik = masodikSor.Split(';');
            nyelv = elso[0];
            sikeres = new List<int>();
            sikertelen = new List<int>();
            osszesitve = new List<int>();
            for (int index = 0; index < elso.Length; index++)
            {
                sikeres.Add(Convert.ToInt32(elso[index]));
                sikertelen.Add(Convert.ToInt32(masodik[index]));
                osszesitve.Add(sikeres[index - 1] + sikertelen[index - 1]);
            }
        }
    }
}
