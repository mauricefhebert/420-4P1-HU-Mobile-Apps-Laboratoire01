using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Exercice_3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void CalculerPourboire()
        {
            if (inp_montant.Text != null || inp_montant.Text != string.Empty)
            {
                double montant = double.Parse(inp_montant.Text);
                double tps = montant * 0.05;
                double tvq = montant * 0.0975;
                double soustotal = montant + tps + tvq;
                double pourboire = double.Parse(inp_pourboire.Text);

                if (pourboire > 0)
                {
                    if (pourboireFormat.SelectedItem == "Pourcentage")
                    {
                        pourboire /= 100;
                        pourboire *= soustotal;
                    }
                }
                else pourboire = 0;


                double total = soustotal + pourboire;
                if (montant > 0)
                {
                    inp_tps.Text = $"{tps}$";
                    inp_tvq.Text = $"{tvq}$";
                    inp_soustotal.Text = $"{soustotal}$";
                    inp_pourboireDisplay.Text = $"{pourboire}$";
                    inp_total.Text = $"{total}$";
                }
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            CalculerPourboire();
        }
    }
}
