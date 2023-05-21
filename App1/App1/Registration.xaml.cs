using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registration : ContentPage
    {
        public Registration()
        {
            InitializeComponent();
        }
        private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (check.IsChecked == true)
            {
                grid1.BackgroundColor = Color.Gray;
                label1.TextColor = Color.White;
                label2.TextColor = Color.White;
                label3.TextColor = Color.White;
                label4.TextColor = Color.White;
                label6.TextColor = Color.White;
                mail.BackgroundColor = Color.White;
                pass.BackgroundColor = Color.White;
                pass1.BackgroundColor = Color.White;
                mail.TextColor = Color.Black;
                pass.TextColor = Color.Black;
                pass1.TextColor = Color.Black;
                button1.TextColor = Color.Black;
                button1.BackgroundColor = Color.White;
            }
            else
            {
                grid1.BackgroundColor = Color.White;
                label1.TextColor = Color.Black;
                label2.TextColor = Color.Black;
                label3.TextColor = Color.Black;
                label4.TextColor = Color.Black;
                label6.TextColor = Color.Black;
                mail.BackgroundColor = Color.LightGray;
                pass.BackgroundColor = Color.LightGray;
                pass1.BackgroundColor = Color.LightGray;
                mail.TextColor = Color.Black;
                pass.TextColor = Color.Black;
                pass1.TextColor = Color.Black;;
                button1.TextColor = Color.Black;
                button1.BackgroundColor = Color.Gray;
            }
        }

        private async void Reg_Tapped(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        private async void button1_Clicked(object sender, EventArgs e)
        {
            if (pass.Text == pass1.Text)
            {
                App.Current.Properties.Add("mail", mail.Text);
                App.Current.Properties.Add("pass", pass.Text);
                await Navigation.PushAsync(new MainPage());
                DisplayAlert("Успешно", "Пользователь зарегистрирован", "Ок");
            }
            else
            {
                DisplayAlert("Ошибка", "Пароли не совпадают", "Ок");
            }
        }
    }
}