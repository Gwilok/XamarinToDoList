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
    public partial class ChangerUtilisateur : ContentPage
    {
        //private Profil profil;
        public ChangerUtilisateur()
        {
            InitializeComponent();
            //profil = new ProfilDal().Select(1);
            //if (profil != null)
            //{
            //    Nom.Text = profil.Nom;
            //    Prenom.Text = profil.Prenom;
            //    Age.Text = profil.Age.ToString();
            //}
        }


        //FUTURE FONCTION CONFIRMER
        //if (profil == null)
        //    profil = new Profil();
        //profil.Nom = Nom.Text;
        //profil.Prenom = Prenom.Text;
        //profil.Age = Convert.ToInt32(Age.Text);
        //new ProfilDal().Sauvegarder(profil);
    }
}