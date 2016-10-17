using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.LoginController;
using Login.Test;

namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLoginClick(object sender, EventArgs e)
        {
            String userName = txtboxUserName.Text;
            String passWord = txtboxPassWord.Text;
            int resLogin = LoginController.Login.CheckLogin(userName, passWord);
            if (resLogin == 1)
            {
                MessageBox.Show("Login Successfully!");

            }
            else
            {
                MessageBox.Show("Login Fail!");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }

        public void ShowMessage(String message)
        {
            MessageBox.Show(message);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            DatabaseTest testDb = new DatabaseTest();
            //testDb.TestConnect();
            //testDb.TestReadAccountTable();
            //testDb.TestReadTablesTable();
            testDb.TestUpdateTablesTable();

            ConfigurationTest testConfig = new ConfigurationTest();
            //testConfig.TestGetDatabaseName();             

            TableApiTest testTableApi = new TableApiTest();
            //testTableApi.TestCreateTable();   
        

        }
    }
}
