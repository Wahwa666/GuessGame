using PanGamesFunction.DB;
using PanGamesFunction.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanGamesGuessNumber
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private string adressLocalRegistration = ConfigurationManager.AppSettings.Get("adressLocalRegistration");
        //private string functionKeyRegistration = ConfigurationManager.AppSettings.Get("functionKeyRegistration");
        private void regostrationLabel_Click(object sender, EventArgs e)
        {
            if ((loginTxtBox.Text == "") || (passwordRepeatTextBox.Text == "") || (passwordTxtBox.Text == ""))
            {
                MessageBox.Show("Не все поля заполнены");
            }else
            {
                RegistrationFunctionResponse result = new RegistrationFunctionResponse();
                HttpClient client = new HttpClient();
                var response = client.GetAsync(adressLocalRegistration + loginTxtBox.Text + "/" + passwordTxtBox.Text + "/" + passwordRepeatTextBox.Text).GetAwaiter().GetResult();
                response.EnsureSuccessStatusCode();
                string responseBody = response.Content.ReadAsStringAsync().Result;
                result = JsonSerializer.Deserialize<RegistrationFunctionResponse>(responseBody);
                MessageBox.Show(result.message);
                if (result.successfulRegistration == true)
                {
                    this.Hide();
                    UserInfo user = new UserInfo();
                    AuthForm authForm = new AuthForm();
                    authForm.Show();
                }
            }


        }
    }
}
