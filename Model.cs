using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace pp
{
   public class Model
    {
        public List<Car> cars = new List<Car>();
        private void Import(string filename)
        {
            cars = File.ReadAllLines(filename).Skip(1).Select(x => new Car(x)).ToList();
        }
        public Model()
        {
            Import("car.txt");
        }
        public List<string> afterYear(int year)
        {
            return cars.Where(x => x.BY > year).Select(x => x.TY).ToList();
        }
        public List<string> LO(int lo)
        {
            return cars.Where(x=> x.HP > lo).Select(x=> x.TY).ToList();
        }
        public List<string> MAXP (int MP)
        {
            return cars.Where(x=> x.Price < MP).Select(x=> x.TY).ToList();
        }
        public int DB(string M)
        {
            return cars.Where(x => x.BR == M).Count();
        }
        public bool Van(string M)
        {
            return cars.Any(x=> x.BR == M);
        }
        public bool VANL(int L)
        {
            return cars.Any(x=> x.HP > L);
        }
        public int MXP()
        {
            return cars.Max(x => x.Price);
        }
        public double AVGB(string brand)
        {
            return cars.Where(x => x.BR == brand).Average(x => x.HP);
        }
        public double ATKAGP()
        {
            return cars.Average(x=> x.Price);
        }
        public List<string> ASCP()
        {
            return cars.OrderBy(x => x.Price).Select(x => x.TY).ToList();
        }
        public List<string> DESCHP()
        {
            return cars.OrderByDescending(x => x.HP).Select(x => x.TY).ToList();
        }
        public List<string> MB(int ev1,int ev2)
        {
            return cars.Where(x=> x.BY > ev1 && x.BY < ev2).Select(x=> x.TY).ToList();
        }
        public List<string> MINHPMP(int minh1,int maxp)
        {
            return cars.Where(x=> x.HP >= minh1 && x.Price < maxp).Select(x=> x.TY).ToList();
        }
        public string Y()
        {
            return cars.OrderByDescending(x => x.BY).Select(x=> x.TY).First();
        }
        public List<string> Valami(int db)
        {
            return cars.OrderByDescending(x=> x.Price).Select(x=> x.TY).Take(db).ToList();
        }
        public List<string> Ize(string br)
        {
            return cars.Where(x=> x.BR == br).OrderByDescending(x=> x.HP).Select(x=> x.TY).ToList();
        }
        public int Bize(int n)
        {
            return cars.Where(x => x.BY > n).Count();
        }
        public double Mize(int minHP)
        {
            return cars.Where(x => x.HP >= minHP).Average(x => x.Price);
        }
        public string TZ(int p)
        {
            return cars.Where(x => x.Price > p).OrderBy(x => x.Price).Select(x => x.TY).First();
        }
        public string u (int y)
        {
            return cars.Where(x=> x.BY > y).OrderBy(x=> x.HP).Select(x=> x.TY).First();
        }
        public List<string> z()
        {
            return cars.Where(x=> x.Price < cars.Average(x=> x.Price)).OrderByDescending(x=> x.Price).Select(x=> x.TY).ToList();
        }
        public List<string> i()
        {
            return cars.Select(x=> x.BR).Distinct().ToList();
        }
        public int r()
        {
            return cars.Select(x=> x.BR).Distinct().Count();
        }
        public Dictionary<string,int> o()
        {
            return cars.GroupBy(x=> x.BR).ToDictionary(x=> x.Key, y=> y.Count())
        }

























    }
}
