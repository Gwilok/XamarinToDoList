using ExerciceSynthese.Dal;
using ExerciceSynthese.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExerciceSynthese
{
	public partial class MainPage : ContentPage
	{
        public string TitreTache { get; set; }
        public string Tache { get; set; }


        public MainPage()
		{
            InitializeComponent();

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            List<Tache> taches = new List<Tache>();
            //Icic listTaches est une ListView, et je viens lui donner ma liste de tâches
            taches = new TacheDal().SelectAll();
            listeTaches.ItemsSource = taches;
            lblDate.Text = DateTime.Today.ToString();
        }
        private void btnCreerTache_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new AjouterTache());
        }

        private void btnProfil_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ChangerUtilisateur());
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            Tache tache = (Tache)((Switch)sender).BindingContext;
            tache.Etat = e.Value;
            new TacheDal().Sauvegarder(tache);
        }

        private void listeTaches_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Tache tache = (Tache)e.Item;
            Navigation.PushModalAsync(new ModifierTache((Tache)e.Item));
        }
    }
}
