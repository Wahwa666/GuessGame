using PanGamesFunction;
using PanGamesFunction.DB;
using PanGamesFunction.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanGamesGuessNumber
{
    public partial class MainForm : Form
    {
        public MainForm(UserInfo user)
        {
            this.user.Login = user.Login;
            this.user.Password = user.Password;
            this.user.GamesCount = user.GamesCount;
            InitializeComponent();
        }
        private string adressLocalStartGame = ConfigurationManager.AppSettings.Get("adressLocalStartGame");
        //private string functionKeyGame = ConfigurationManager.AppSettings.Get("functionKeyGame");
        private string adressLocalGame = ConfigurationManager.AppSettings.Get("adressLocalGame");
        //private string functionKeyStartGame = ConfigurationManager.AppSettings.Get("functionKeyStartGame");

        private UserInfo user = new UserInfo();
        private void startLabel_Click(object sender, EventArgs e)
        {
            guessNumberTextBox.Visible = true;
            GuessLabel.Visible = true;
            HttpClient client = new HttpClient();
            var response = client.GetAsync(adressLocalStartGame + user.Login + "/" + user.Password).GetAwaiter().GetResult();
            response.EnsureSuccessStatusCode();
            string responseBody = response.Content.ReadAsStringAsync().Result;
            user = JsonSerializer.Deserialize<UserInfo>(responseBody);
            GamesCountLabel.Text = user.GamesCount.ToString();
            MessageBox.Show("Число загадано");
        }

        private void GuessLabel_Click(object sender, EventArgs e)
        {
            ResponseGame result = new ResponseGame();
            if (guessNumberTextBox.Text == "")
            {
                MessageBox.Show("Введите число");
            }else
            {
                HttpClient client = new HttpClient();
                var response = client.GetAsync(adressLocalGame + guessNumberTextBox.Text + "/" + user.Login).GetAwaiter().GetResult();
                response.EnsureSuccessStatusCode();
                string responseBody = response.Content.ReadAsStringAsync().Result;
                result = JsonSerializer.Deserialize<ResponseGame>(responseBody);
                if  (result.numberGuessed == true)
                {
                    guessNumberTextBox.Visible = false;
                    GuessLabel.Visible = false;
                    MessageBox.Show(result.message);
                }
                else
                    MessageBox.Show(result.message);
            }
        }
    }
}
