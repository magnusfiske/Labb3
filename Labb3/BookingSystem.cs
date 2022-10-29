using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Xml.Linq;
using Labb3;

namespace Labb3
{
    public class BookingSystem : IBookingSystem
    {

        public BookingSystem()
        {
            Reservations = new List<IReservation>();
            
        }

        public List<IReservation> Reservations { get; set; }
        public int SeatsAtTable { get; set; }

        public void BookTable(IReservation reservation)
        {

            Reservations.Add(reservation);
        }

        public void CancelReservation()
        {
            
        }

        public void ListBookings()
        {
            
        }

        public void LoadReservations()
        {
            
        }

        public void SaveReservations()
        {
            
        }

        //public string PrintReservation()
        //{

        //}
    }
}
