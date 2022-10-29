using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
    public interface IBookingSystem
    {
        List<IReservation> Reservations { get; set; }

        int SeatsAtTable { get; set; }

        void BookTable(IReservation r) { }
        void ListBookings();
        void CancelReservation();
        void SaveReservations();
        void LoadReservations();
    }
}
