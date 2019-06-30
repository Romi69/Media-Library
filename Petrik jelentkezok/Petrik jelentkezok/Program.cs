using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petrik_jelentkezok
{
    class Program
    {        
        static void Main(string[] args)
        {
            List<Forras> forras = new List<Forras>();
            List<Vegleges> vegleges = new List<Vegleges>();

            #region --- Végleges lista ---
            using (StreamReader sr = new StreamReader("veglegesSorrend.csv", Encoding.GetEncoding(1250)))
            {
                string line;
                Vegleges student = null;
                sr.ReadLine();

                while((line = sr.ReadLine()) != null)
                {
                    string[] fields = line.Split(';');

                    student = new Vegleges();
                    student.ID = int.Parse(fields[0]);
                    student.StudentId = fields[1];
                    student.Tagozat = int.Parse(fields[2]);
                    student.TagozatNev = fields[3];
                    student.Osztaly = fields[4];

                    vegleges.Add(student);
                }
            }
            #endregion

            #region --- Ideiglenes lista ---
            using (StreamReader sr = new StreamReader("PetrikSorrend.csv"))
            {
                string line;
                Forras student = null;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] fields = line.Split(';');

                    if (fields[1].StartsWith("A"))
                    {
                        student = new Forras();
                        student.ID = int.Parse(fields[3]);
                    }
                    else if (fields[1].StartsWith("B"))
                    {
                        student.StudentId = fields[3];
                    }
                    else if (fields[1].StartsWith("C"))
                    {
                        student.Unknown = int.Parse(fields[3]);
                    }
                    else if (fields[1].StartsWith("D"))
                    {
                        student.Class1Nr = fields[2] != "s" ? int.Parse(fields[3]) : -1;
                    }
                    else if (fields[1].StartsWith("E"))
                    {
                        student.Class2Nr = fields[2] != "s" ? int.Parse(fields[3]) : -1;
                    }
                    else if (fields[1].StartsWith("F"))
                    {
                        student.Class3Nr = fields[2] != "s" ? int.Parse(fields[3]) : -1;
                    }
                    else if (fields[1].StartsWith("G"))
                    {
                        student.Class4Nr = fields[2] != "s" ? int.Parse(fields[3]) : -1;
                    }
                    else if (fields[1].StartsWith("H"))
                    {
                        student.Class5Nr = fields[2] != "s" ? int.Parse(fields[3]) : -1;
                        forras.Add(student);
                    }
                }
            }
            #endregion

            int kv = forras.Count(x => x.Class1Nr != -1);
            int v = forras.Count(x => x.Class2Nr != -1);
            int k = forras.Count(x => x.Class3Nr != -1);
            int ki = forras.Count(x => x.Class4Nr != -1);
            int i = forras.Count(x => x.Class5Nr != -1);

            Console.WriteLine($" Kéttannyelvű vegyész: {kv}\n Vegyész: {v}\n Környezetvédő: {k}\n Nyelvi előkészítő informatika: {ki}\n Informatika: {i}");
            Console.WriteLine();

            int cnt = 0;
            var sorrend = forras.OrderBy(x => x.Class1Nr).Where(x => x.Class1Nr != -1);
            foreach (var item in sorrend)
            {
                cnt += (item.Class4Nr != -1 && item.Class4Nr <=45) || (item.Class5Nr != -1 && item.Class5Nr <=45) ? 0 : 1;
                Console.WriteLine($"{item.StudentId}:\t{item.Class1Nr},\t{item.Class2Nr},\t{item.Class3Nr},\t{item.Class4Nr},\t{item.Class5Nr}\t{cnt}");
            }


            Console.WriteLine("\n---------------------------------\n");
            Forras Barni = forras.Where(x => x.StudentId == "72453917313").FirstOrDefault();
            Console.WriteLine($"{Barni.StudentId}:\t{Barni.Class1Nr},\t{Barni.Class2Nr},\t{Barni.Class3Nr},\t{Barni.Class4Nr},\t{Barni.Class5Nr}");
            Console.WriteLine("\n---------------------------------\n");
            //72453917313
            foreach (Vegleges student in vegleges)
            {
                var found = forras.Where(x => x.StudentId == student.StudentId).FirstOrDefault();
                if(found != null)
                {
                    switch(student.Tagozat)
                    {
                        case 91: student.Pozicio = found.Class1Nr; break;
                        case 92: student.Pozicio = found.Class2Nr; break;
                        case 93: student.Pozicio = found.Class3Nr; break;
                        case 94: student.Pozicio = found.Class4Nr; break;
                        case 95: student.Pozicio = found.Class5Nr; break;
                    }
                }
            }

            var rendezett = vegleges.OrderBy(x => x.Tagozat).ThenBy(y=> y.Pozicio);
            int count = 1;
            foreach (Vegleges item in rendezett)
            {
                if (item.Pozicio == -1 || item.Pozicio == 207)
                {
                    var x = forras.Where(y => y.StudentId == item.StudentId).FirstOrDefault();
                    Console.WriteLine($"{count++}. {item.StudentId}\t{item.TagozatNev}\t{item.Pozicio} --- {x.Class1Nr}  {x.Class2Nr}  {x.Class3Nr}  {x.Class4Nr}  {x.Class5Nr}  ");
                }
                else
                {
                    Console.WriteLine($"{count++}. {item.StudentId}\t{item.TagozatNev}\t{item.Pozicio}");
                }
            }

            Console.ReadLine();
        }
    }
    
    public class Forras
    {
        public int ID { get; set; }
        public string StudentId { get; set; }
        public int Unknown { get; set; }
        public int Class1Nr { get; set; }
        public int Class2Nr { get; set; }
        public int Class3Nr { get; set; }
        public int Class4Nr { get; set; }
        public int Class5Nr { get; set; }
    }

    public class Vegleges
    {
        public int ID { get; set; }
        public string StudentId { get; set; }
        public int Tagozat { get; set; }
        public string TagozatNev { get; set; }
        public string Osztaly { get; set; }
        public int Pozicio { get; set; }
    }
}
