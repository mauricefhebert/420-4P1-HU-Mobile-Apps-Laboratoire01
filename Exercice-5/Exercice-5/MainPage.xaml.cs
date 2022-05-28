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
            //Add Event to the button on application launch
            Button_Event_Handler();
        }

        //Hold that user calculation interface
        public string UserInputDisplay = "";

        //Add event to all the button
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

        //Handle the display of the user calculation interface
        private void Display(object sender, EventArgs e)
        {
            //If the character is container in the array they will not be displayed in the interface, otherwise they will
            string[] strings = { "(", ")", "C", "=", "⌫" };
            foreach (string s in strings)
            {
                if (((Button)sender).Text.Contains(s)) return;
            }

            //If the button clicker is not a digit i will append space before and after the character, otherwise i will not
            if (!Char.IsDigit(char.Parse(((Button)sender).Text)))
            {
                UserInputDisplay += $" {((Button)sender).Text} ";
            }
            else
            {
                UserInputDisplay += ((Button)sender).Text;
            }
            //Update the user calculator interface
            UserDisplay.Text = UserInputDisplay;
        }

        //Handle the equal button
        private void Button_Equal(object sender, EventArgs e)
        {
            string[] value = UserInputDisplay.Split(' ');

            for (int i = 0; i < value.Length; i++)
            {
                
            }
        }

        //Clear the user calculator interface
        private void Button_Clear(object sender, EventArgs e)
        {
            UserInputDisplay = "";
            UserDisplay.Text = UserInputDisplay;
        }

        //Backspace one characters from the user calculator interface
        private void Button_Delete(object sender, EventArgs e)
        {
            if (UserInputDisplay.Length <= 0) return;
            UserInputDisplay = UserInputDisplay.Remove(UserInputDisplay.Length - 1);
            UserDisplay.Text = UserInputDisplay;
        }
    }
}
