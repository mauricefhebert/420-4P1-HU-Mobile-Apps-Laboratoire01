using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Exercice_4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        //True = Celsius
        //False = Fahrenheit
        private bool Unit = true;

        private void Btn_Celsius_To_Fahrenheit(object sender, EventArgs e)
        {
            if(Unit && inp_temperature.Text != null)
            {
             Unit = false;
             double Celsius = (double.Parse(inp_temperature.Text) - 32) * 5 / 9;
            lbl_temperature.Text = $"{Celsius}°C";
            }
        }

        private void Btn_Fahrenheit_To_Celsius(object sender, EventArgs e)
        {
            if (!Unit && inp_temperature.Text != null)
            {
            Unit = true;
            double Fahrenheit = double.Parse(inp_temperature.Text) * 9 / 5 + 32;
            lbl_temperature.Text = $"{Fahrenheit}°F";
            }

        }
    }
}
