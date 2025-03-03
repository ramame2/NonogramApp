using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json; // Zorg ervoor dat deze namespace is toegevoegd
using System.Windows.Forms;
using BCrypt.Net;

namespace NonogramApp.Views
{
    public partial class LoginForm : Form
    {
        private readonly string usersFile = "users.json"; // JSON bestand met gebruikers

        public LoginForm()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (ValidateUser(username, password))
            {
                MessageBox.Show("Succesvol ingelogd!", "Inloggen", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open hoofdmenu
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ongeldige gebruikersnaam of wachtwoord.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e) // Zorg ervoor dat deze methode is gedefinieerd
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vul alstublieft zowel gebruikersnaam als wachtwoord in.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RegisterUser(username, password);
        }

        private void RegisterUser(string username, string password)
        {
            List<User> users = LoadUsers();

            // Controleer of de gebruiker al bestaat
            if (users.Exists(u => u.Username == username))
            {
                MessageBox.Show("Deze gebruikersnaam is al in gebruik.", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Voeg de nieuwe gebruiker toe
            users.Add(new User { Username = username, Password = BCrypt.Net.BCrypt.HashPassword(password) });

            // Sla de gebruikers op in users.json
            SaveUsers(users);
            MessageBox.Show("Gebruiker succesvol geregistreerd!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private List<User> LoadUsers()
        {
            if (!File.Exists(usersFile))
            {
                return new List<User>();
            }

            var json = File.ReadAllText(usersFile);
            return JsonSerializer.Deserialize<List<User>>(json);
        }

        private void SaveUsers(List<User> users)
        {
            var json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(usersFile, json);
        }

        private bool ValidateUser(string username, string password)
        {
            if (!File.Exists(usersFile))
            {
                MessageBox.Show("Gebruikersbestand ontbreekt!", "Fout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string json = File.ReadAllText(usersFile);
            List<User> users = JsonSerializer.Deserialize<List<User>>(json);

            foreach (var user in users)
            {
                if (user.Username == username && BCrypt.Net.BCrypt.Verify(password, user.Password))
                {
                    return true;
                }
            }
            return false;
        }
    }

    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; } // Gehasht wachtwoord
    }
}