using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentler.Admin.Common
{
    public class Stat
    {
        public string Label { get; set; }

        public int Total { get; set; }
    }

    public class Stat<T>
    {
        public string Name { get; set; }
        public T Total { get; set; }
        public int Percent { get; set; }
        public DateTime Date { get; set; }

        public Stat() { }

        public Stat(string name, T total, int percent)
        {
            this.Name = name;
            this.Total = total;
            this.Percent = percent;
        }
    }

    public class Stats<T>
    {
        public List<Stat<T>> Items { get; set; }
        public T Total { get; set; }

        public Stats()
        {
            this.Items = new List<Stat<T>>();
        }
    }
}
