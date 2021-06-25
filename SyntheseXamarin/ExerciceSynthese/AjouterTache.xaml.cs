using ExerciceSynthese.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExerciceSynthese
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AjouterTache : ContentPage
    {
        public AjouterTache()
        {
            InitializeComponent();
        }

        private void btnRetour_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private void btnConfirmer_Clicked(object sender, EventArgs e)
        {
            Tache tache = new Tache();
            tache.Description = edtDescription.Text;
            tache.Title = entTache.Text;
            tache.Date = dtpDate.Date;
            tache.Etat = false;
            new Dal.TacheDal().Sauvegarder(tache);
            Navigation.PopModalAsync();
        }
    }
}