using IMCCalculator;
using System;
using Xamarin.Forms;

namespace XamarinApp
{
    public partial class MainPage : ContentPage
    {

        private void GenerateEmailButton_Clicked(object sender, EventArgs e)
        {
            string nomeCompleto = NomeCompleto.Text;
            string[] vetorNome = nomeCompleto.Split(' ');

            if (vetorNome.Length >= 2)
            {
                string sobrenome = vetorNome[1];
                string nome = vetorNome[0];

                string email = $"{sobrenome.ToLower()}.{nome.ToLower()}@ufn.edu.br";
                EmailLabel.Text = email;
            }
        }

        private async void GoToIMCPageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new IMCPage()));
        }


    }
}

