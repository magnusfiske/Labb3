using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
    public class Reservation : IReservation
    {
        //private string? name;
        //private int people;
        //private DateTime dateAndTime;
        //private string? table;

        public Reservation(string name, int people, string date, string time, string table)
        {
            Name = name;
            People = people;
            Date = date;
            Time = time;
            Table = table;
        }

        public string Name { get; set; }
        public int People { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Table { get; set; }
    }
}
