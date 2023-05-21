using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);

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
                label5.TextColor = Color.White; 
                label6.TextColor = Color.White;
                mail.BackgroundColor = Color.White;
                pass.BackgroundColor = Color.White;
                pass1.BackgroundColor = Color.White;
                mail.TextColor = Color.Black;
                pass.TextColor = Color.Black;
                pass1.TextColor = Color.Black;
                picker.BackgroundColor = Color.White;
                picker.TextColor = Color.Black;
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
                label5.TextColor = Color.Black;
                label6.TextColor = Color.Black;
                mail.BackgroundColor = Color.LightGray;
                pass.BackgroundColor = Color.LightGray;
                pass1.BackgroundColor = Color.LightGray;
                mail.TextColor = Color.Black;
                pass.TextColor = Color.Black;
                pass1.TextColor = Color.Black;
                picker.BackgroundColor = Color.LightGray;
                picker.TextColor = Color.Black;
                button1.TextColor = Color.Black;
                button1.BackgroundColor = Color.Gray;
            }
        }

        private async void Reg_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registration());
        }

        private async void button1_Clicked(object sender, EventArgs e)
        {
            object name = "";
            object password = "";
            App.Current.Properties.TryGetValue("mail", out name);
            App.Current.Properties.TryGetValue("pass", out password);
            if (picker.SelectedIndex == 0)
            {
                if (mail.Text == (string)name && pass.Text == (string)password && pass.Text == pass1.Text)
                {
                    await Navigation.PushAsync(new Private());
                }
                else
                {
                    DisplayAlert("Ошибка", "Пароли не совпадают или данные неверны", "Ок");
                }
            }
            else
            {
                DisplayAlert("Ошибка", "Роли не реализованы", "Ок");
            }
        }
    }
}
