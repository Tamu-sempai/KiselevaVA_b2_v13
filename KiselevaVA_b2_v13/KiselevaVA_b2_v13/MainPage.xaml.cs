using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace KiselevaVA_b2_v13
{
    public partial class MainPage :ContentPage
    {
        public  MainPage ()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private async void Button_Clicked (object sender, EventArgs e)
        {
            string login = "ects";
            string password = "ects2023";
            if(!String.IsNullOrEmpty(loginText.Text) && !String.IsNullOrEmpty(passwordText.Text))
            {
                if(loginText.Text == login && passwordText.Text == password)
                {
                    await Navigation.PushAsync(new SecondActivityPage());
                } else
                {
                    await DisplayAlert("Ошибка", "Логин ил пароль введены не верно!", "ОК");
                }
            } else
            {
                await DisplayAlert("Ошибка", "Не все поля заполнены!", "ОК");
            }
        }
    }
}
