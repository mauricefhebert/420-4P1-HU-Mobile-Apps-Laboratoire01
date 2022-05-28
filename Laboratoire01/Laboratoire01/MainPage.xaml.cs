using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Laboratoire01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void ResetForm()
        {
            foreach (var entryBox in form.Children)
            {
                if (entryBox is Entry)
                {
                    if ((entryBox as Entry).Text != null || (entryBox as Entry).Text != string.Empty)
                        (entryBox as Entry).Text = string.Empty;
                }
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string message = $"Est-ce que les informations suivantes semblant correct?\nNom: {Nom.Text}\nPrenom: {Prenom.Text}\nAge: {Age.Text}\nCompetence: {Competences.Text}\nTelephone: {Telephone.Text}";
            var result = DisplayAlert("Information", message, "Ok", "Annuler");
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            ResetForm();
        }
    }
}
