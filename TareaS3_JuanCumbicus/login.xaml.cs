using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TareaS3_JuanCumbicus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class login : ContentPage
    {
        public login()
        {
            InitializeComponent();
        }

        private void btniniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = "estudiante2022";
            string contraseña = "uisrael2022";
            if (usuario == txtusuario.Text && contraseña == txtpassword.Text)
            {
                Navigation.PushAsync(new registro(usuario));
            }
            else
            {
                DisplayAlert("ALERTA", "USUARIO O CONTRASEÑA INCORRECTA", "CERRAR");
            }

        }
    }
}