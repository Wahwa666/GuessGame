using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic.Logging;
using System.Text.Json;
using PanGamesFunction;
using PanGamesFunction.DB;
using System.Xml;
using System;
using System.Net.Http;
using static System.Windows.Forms.AxHost;
using System.Configuration;
using Microsoft.VisualBasic.ApplicationServices;
using PanGamesFunction.Response;

namespace PanGamesGuessNumber
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }
        private string adressLocalAutn = ConfigurationManager.AppSettings.Get("adressLocalAutn");
        //private string functionAuthCode = ConfigurationManager.AppSettings.Get("functionKeyAuth");

        private void authorizationLabel_Click(object sender, EventArgs e)
        {
            if ((loginTxtBox.Text == "") || (passwordTxtBox.Text == ""))
            {
                MessageBox.Show("Поле логин или пароль пустое");
            }
            else
            {
                HttpClient client = new HttpClient();
                var response = client.GetAsync(adressLocalAutn + loginTxtBox.Text + "/" + passwordTxtBox.Text).GetAwaiter().GetResult();
                response.EnsureSuccessStatusCode();
                string responseBody = response.Content.ReadAsStringAsync().Result;
                AuthorizationFunctionResponse result = new AuthorizationFunctionResponse();
                result = JsonSerializer.Deserialize<AuthorizationFunctionResponse>(responseBody);
                if (result.correctInformation == false)
                {
                    MessageBox.Show(result.message);
                }
                else
                {
                    this.Hide();
                    MainForm mainForm = new MainForm(result.userResponse);
                    mainForm.Show();
                }
            }
        }

        private void registrationLabel_Click(object sender, EventArgs e)
        {
            if ((loginTxtBox.Text == "") || (passwordTxtBox.Text == ""))
            {
                MessageBox.Show("Поле логин или пароль пустое");
            }
            else
            {
                this.Hide();
                UserInfo user = new UserInfo();
                RegistrationForm registrationForm = new RegistrationForm();
                registrationForm.Show();
            }
        }
    }
}