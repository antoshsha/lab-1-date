using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
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

namespace lab_1_date
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

          
        }

        
        string West_Sign(DateTime date) {
            if ((date.Month == 1) && (date.Day < 20)) {
                return "Capricon";
            }
            if ((date.Month == 1) && (date.Day >= 20))
            {
                return "Aquarius";
            }
            if ((date.Month == 2) && (date.Day < 19))
            {
                return "Aquarius";
            }
            if ((date.Month == 2) && (date.Day >= 19))
            {
                return "Pisces";
            }
            if ((date.Month == 3) && (date.Day < 21))
            {
                return "Pisces";
            }
            if ((date.Month == 3) && (date.Day >= 21))
            {
                return "Aries";
            }
            if ((date.Month == 4) && (date.Day < 20))
            {
                return "Aries";
            }
            if ((date.Month == 4) && (date.Day >= 20))
            {
                return "Taurus";
            }
            if ((date.Month == 5) && (date.Day < 21))
            {
                return "Taurus";
            }
            if ((date.Month == 5) && (date.Day >= 21))
            {
                return "Gemini";
            }
            if ((date.Month == 6) && (date.Day < 21))
            {
                return "Gemini";
            }
            if ((date.Month == 6) && (date.Day >= 21))
            {
                return "Cancer";
            }
            if ((date.Month == 7) && (date.Day < 23))
            {
                return "Cancer";
            }
            if ((date.Month == 7) && (date.Day >= 23))
            {
                return "Leo";
            }
            if ((date.Month == 8) && (date.Day < 23))
            {
                return "Leo";
            }
            if ((date.Month == 8) && (date.Day >= 23))
            {
                return "Virgo";
            }
            if ((date.Month == 9) && (date.Day < 23))
            {
                return "Virgo";
            }
            if ((date.Month == 9) && (date.Day >= 23))
            {
                return "Libra";
            }
            if ((date.Month == 10) && (date.Day < 23))
            {
                return "Libra";
            }
            if ((date.Month == 10) && (date.Day >= 23))
            {
                return "Scorpio";
            }
            if ((date.Month == 11) && (date.Day < 22))
            {
                return "Scorpio";
            }
            if ((date.Month == 11) && (date.Day >= 22))
            {
                return "Sagittarius";
            }
            if ((date.Month == 12) && (date.Day < 22))
            {
                return "Sagittarius";
            }
            if ((date.Month == 12) && (date.Day >= 22))
            {
                return "Capricon";
            }
            else {
                return "something went wrong";
            }
        }

        string China_Sign(DateTime date) {
            if (date.Year % 12 == 0) {
                return "Monkey";
            }
            if (date.Year % 12 == 1)
            {
                return "Cock";
            }
            if (date.Year % 12 == 2)
            {
                return "Dog";
            }
            if (date.Year % 12 == 3)
            {
                return "Pig";
            }
            if (date.Year % 12 == 4)
            {
                return "Rat";
            }
            if (date.Year % 12 == 5)
            {
                return "Bull";

            }
            if (date.Year % 12 == 6)
            {
                return "Tiger";
            }
            if (date.Year % 12 == 7)
            {
                return "Rabbit";
            }
            if (date.Year % 12 == 8)
            {
                return "Dragon";
            }
            if (date.Year % 12 == 9)
            {
                return "Snake";
            }
            if (date.Year % 12 == 10)
            {
                return "Horse";
            }
            if (date.Year % 12 == 11)
            {
                return "Goat";
            }
            return "something went wrong";
        }
        private void dtpicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            
            birthday.Text = "";
            int age = DateTime.Now.Year - dtpicker.SelectedDate.Value.Year;
            
            if (DateTime.Now.Month < dtpicker.SelectedDate.Value.Month) {
                age -= 1;
            
            }
            if (DateTime.Now.Month == dtpicker.SelectedDate.Value.Month) {
                if (DateTime.Now.Day < dtpicker.SelectedDate.Value.Day) {
                    age -= 1;
                }
                if (DateTime.Now.Day == dtpicker.SelectedDate.Value.Day)
                {
                    birthday.Text = "happy bday!";
                }
               
            }
            AgeOfUser.Text = "Age: " + age.ToString();

            WestZodiakRes.Text = "Your western zodiac sign is: " + West_Sign(dtpicker.SelectedDate.Value);
            EastZodiakRes.Text = "Your chinese zodiac sign is: " + China_Sign(dtpicker.SelectedDate.Value);
            if ((age < 0) || (age > 135))
            {
                WestZodiakRes.Text = "Western sign: ";
                EastZodiakRes.Text = "Chinese sign: ";
                AgeOfUser.Text = "Age: ";

                birthday.Text = "";
                MsgBoxResult msgBoxResult = (MsgBoxResult)MessageBox.Show("you entered a fake date", "error");
            }
        }
    }
}
