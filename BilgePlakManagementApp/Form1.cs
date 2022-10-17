using BilgePlakManagementApp.DAL.Context;
using BilgePlakManagementApp.DAL.Entities;
using Microsoft.VisualBasic.ApplicationServices;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

using System.Text;

namespace BilgePlakManagementApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void loginBtn_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            throw new NotImplementedException();
        }





        private void Form1_Load(object sender, EventArgs e)
        {
            Category cat = new Category();

            
        }


        private void registerBtn_Click(object sender, EventArgs e)
        {
            Register();
        }

        private void Register()
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            using (PlakDbContext DB = new PlakDbContext())
            {              
                //DB.Add();
            }
        }
        private string sha256_hash(string sifre) { 
            
            using (SHA256 hash = SHA256Managed.Create()) 
            { 
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }
        int upperCount = 0;
        int charCount = 0;
        int lowerCount = 0;
        int lenght = 0;
        List<string> requiredChars = new List<string> {"!",":","*","+" };
        List<string> upperChars = new List<string> { };

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            //for (int i = 0; i < txtPassword.Text.Length; i++)
            //{
            //    if (i )
            //    {

            //    }
            //}
        }
    }
}