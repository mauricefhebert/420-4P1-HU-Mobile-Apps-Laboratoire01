using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Exercice_2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            createForm();
        }

        public void createForm()
        {
            StackLayout stackLayout = new StackLayout();
            stackLayout.Margin = new Thickness(0, 0, 20, 0);
            //Nom
            Label lbl_nom = new Label();
            lbl_nom.Text = "Nom:";
            Entry ent_nom = new Entry();
            ent_nom.BackgroundColor = Color.LightGray;
            ent_nom.Keyboard = Keyboard.Default;
            ent_nom.StyleId = "nom";

            //Prenom
            Label lbl_prenom = new Label();
            lbl_prenom.Text = "Prenom:";
            Entry ent_prenom = new Entry();
            ent_prenom.BackgroundColor = Color.LightGray;
            ent_prenom.Keyboard = Keyboard.Default;
            ent_prenom.StyleId = "prenom";

            //Age
            Label lbl_age = new Label();
            lbl_age.Text = "Age:";
            Entry ent_age = new Entry();
            ent_age.BackgroundColor = Color.LightGray;
            ent_age.Keyboard = Keyboard.Default;
            ent_age.StyleId = "age";


            //Competences
            Label lbl_competence = new Label();
            lbl_competence.Text = "Competence:";
            Entry ent_competence = new Entry();
            ent_competence.BackgroundColor = Color.LightGray;
            ent_competence.Keyboard = Keyboard.Default;
            ent_competence.StyleId = "competence";

            //Telephone
            Label lbl_telephone = new Label();
            lbl_telephone.Text = "Telephone:";
            Entry ent_telephone = new Entry();
            ent_telephone.BackgroundColor = Color.LightGray;
            ent_telephone.Keyboard = Keyboard.Default;
            ent_telephone.StyleId = "telephone";

            //Create the grid
            Grid grid = new Grid();

            //Create and add the column
            ColumnDefinition col0 = new ColumnDefinition();
            ColumnDefinition col1 = new ColumnDefinition();
            grid.ColumnDefinitions.Add(col0);
            grid.ColumnDefinitions.Add(col1);

            //Button Confirmation
            Button btn_Confirmation = new Button();
            btn_Confirmation.SetValue(Grid.ColumnProperty, 0);
            btn_Confirmation.Text = "Confirmer";
            btn_Confirmation.BackgroundColor = Color.CadetBlue;


            //Button Annuler
            Button btn_Annuler = new Button();
            btn_Annuler.SetValue(Grid.ColumnProperty, 1);
            btn_Annuler.Text = "Annuler";
            btn_Annuler.BackgroundColor = Color.OrangeRed;

            grid.Children.Add(btn_Confirmation);
            grid.Children.Add(btn_Annuler);

            stackLayout.Children.Add(lbl_nom);
            stackLayout.Children.Add(ent_nom);
            stackLayout.Children.Add(lbl_prenom);
            stackLayout.Children.Add(ent_prenom);
            stackLayout.Children.Add(lbl_age);
            stackLayout.Children.Add(ent_age);
            stackLayout.Children.Add(lbl_competence);
            stackLayout.Children.Add(ent_competence);
            stackLayout.Children.Add(lbl_telephone);
            stackLayout.Children.Add(ent_telephone);
            stackLayout.Children.Add(grid);
            form.Children.Add(stackLayout);
        }
    }
}
