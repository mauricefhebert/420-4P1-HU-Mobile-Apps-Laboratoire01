using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Exercice_5
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Button_Event_Handler();
        }
        public string UserInputDisplay = "";
        double sum = 0;

        public void Button_Event_Handler()
        {
            foreach (var btn in calculator.Children)
            {
                if (btn.GetType() == typeof(Button))
                {
                    ((Button)btn).Clicked += Display;
                }
            }
        }

        private void Display(object sender, EventArgs e)
        {
            string[] strings = { "(", ")", "C", "=", "⌫" };
            foreach (string s in strings)
            {
                if (((Button)sender).Text.Contains(s)) return;
            }

            if (!Char.IsDigit(char.Parse(((Button)sender).Text)))
            {
                if (sum > 0)
                {
                    UserInputDisplay += sum.ToString();
                }
                UserInputDisplay += $" {((Button)sender).Text} ";
            }
            else
            {
                UserInputDisplay += ((Button)sender).Text;
            }
            UserDisplay.Text = UserInputDisplay;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            string[] value = UserInputDisplay.Split(' ');

            for (int i = 0; i < value.Length; i++)
            {
                if (sum > 0)
                {
                    UserInputDisplay = "";
                }
                if (value[i] == "+") sum = double.Parse(value[i - 1]) + double.Parse(value[i + 1]);
            }
            UserDisplay.Text = sum.ToString();
        }

        private void Button_Clear(object sender, EventArgs e)
        {
            UserInputDisplay = "";
            UserDisplay.Text = UserInputDisplay;
        }

        private void Button_Delete(object sender, EventArgs e)
        {
            if (UserInputDisplay.Length <= 0) return;

            UserInputDisplay = UserInputDisplay.Remove(UserInputDisplay.Length - 1);
            UserDisplay.Text = UserInputDisplay;
        }
    }
}
