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
    public partial class registro : ContentPage
    {
        public registro(string usuario)
        {
            InitializeComponent();
            lbUsuario.Text = usuario;
        }

        private void btnCalcularNF_Clicked(object sender, EventArgs e)
        {
            double nota1 = Convert.ToDouble(txtNotaUno.Text)*0.3;
            double nota2 = Convert.ToDouble(txtNotaDos.Text)*0.2;
            double parcial1 = nota1 + nota2;

            double nota4 = Convert.ToDouble(txtNotaCuatro.Text)*0.3;
            double nota5 = Convert.ToDouble(txtNotaCinco.Text)*0.2;
            double parcial2 = nota4 + nota5;

            double notafinal = parcial1 + parcial2;

            if (notafinal >= 7)
            {
                txtEstado.Text = "APROBADO";
            }
            if (notafinal < 7)
            {
                txtEstado.Text = "SUPLEMENTARIA";
            }
            if (notafinal >= 0 && notafinal <= 5)
            {
                txtEstado.Text = "REPROBADO";
            }
            txtNota.Text = notafinal.ToString();

        }

        private void txtNotaUno_TextChanged(object sender, TextChangedEventArgs e)
        {
            double nota1 = Convert.ToDouble(txtNotaUno.Text);
            double nota2 = Convert.ToDouble(txtNotaDos.Text);
            double parcial1 = Convert.ToDouble(txtParcialUno.Text);
            double parcial2 = Convert.ToDouble(txtParcialDos.Text);
            try
            {
                if (nota1 < 0 || nota1 > 10)
                {
                    DisplayAlert("Error", "Numero fuera de rango", "Cerrar");
                }
                if (nota2 < 0 || nota2 > 10)
                {
                    DisplayAlert("Error", "Numero fuera de rango", "Cerrar");
                }
                if (parcial1 < 0 || parcial1 > 10)
                {
                    DisplayAlert("Error", "Numero fuera de rango", "Cerrar");
                }
                if (parcial2 < 0 || parcial2 > 10)
                {
                    DisplayAlert("Error", "Numero fuera de rango", "Cerrar");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
    }
}