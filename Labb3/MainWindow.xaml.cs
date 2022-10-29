using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Globalization;
using Labb3;

namespace Labb3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private BookingSystem myBookingSystem;
        
        public MainWindow()
        {
            InitializeComponent();


            MyBookingSystem = new BookingSystem();
            lwBookingList.ItemsSource = myBookingSystem.Reservations;
            RefreshContent();
        }

        public BookingSystem MyBookingSystem 
        {
            get { return myBookingSystem; } 
            set { myBookingSystem = value; }
        }
       
        public void btnBoka_Click(object sender, RoutedEventArgs e)
        {
            string date = datePicker.DisplayDate.ToString("ddd d MMM", CultureInfo.CurrentCulture);
            string name = tbName.Text;
            string time = comboTime.Text;
            string table = comboTable.Text;
            int people = Int32.Parse(comboGuests.Text);


            Reservation reservation = new Reservation(name, people, date, time, table);
            MyBookingSystem.BookTable(reservation);
            RefreshContent();

        }

        public void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            if (MyBookingSystem.Reservations == null || lwBookingList.SelectedIndex == -1)
                MessageBox.Show("Markera en bokning för att ta bort den.");
            else
            {
                try
                {
                    myBookingSystem.Reservations.RemoveAt(lwBookingList.SelectedIndex);
                    RefreshContent();
                }
                catch(Exception ex) 
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void RefreshContent()
        {
            lwBookingList.ItemsSource = null;
            lwBookingList.ItemsSource = myBookingSystem.Reservations;

            
        }
    }
}
