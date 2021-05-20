using MySql.Data.MySqlClient;
using ProiectII.Database;
using System;
using System.Windows.Forms;

namespace ProiectII
{
    public partial class LoginForm : Form
    {
        private Form1 main;
        public LoginForm()
        {
            InitializeComponent();


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            IsInDataBase(txtUsername.Text, txtPassword.Text);

        }
        private void IsInDataBase(string Username, string Password)
        {

            User login = new User(Username, Password);
            var dbCon = DBConnection.Instance();
            dbCon.Server = "localhost";
            dbCon.DatabaseName = "proiectii";
            dbCon.UserName = "root";
            dbCon.Password = "Qweasdzxc123Halo02";
            if (dbCon.IsConnect())
            {
                //suppose col0 and col1 are defined as VARCHAR in the DB
                string query = "SELECT * FROM proiectii.users;";
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader.GetString(0));
                    string name = reader.GetString(1);
                    string pass = reader.GetString(2);
                    User user = new User(name, pass);
                    if (user.IsEqual(login))
                    {
                        dbCon.Close();
                        main = new Form1(true);
                        main.Show();
                        this.Hide();
                        return;

                    }
                }
                dbCon.Close();
            }
            /*
            using (proiectiiDataSet proiectiiDataSet = new proiectiiDataSet())
            {
                DataTableCollection tables = proiectiiDataSet.Tables;
                DataTable table = tables[0];
                DataRow data = table.NewRow();

                foreach (DataRow row in table.Rows)
                {
                    if (row[2].ToString() == Username && row[3].ToString()==Password)
                    {
                         main = new Form1(Convert.ToBoolean(row[4]));
                        main.Show();
                        this.Hide();
                        return;
                    }
                }
            }*/

        }
    }
}
