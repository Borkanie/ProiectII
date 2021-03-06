using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using ProiectII.Clase;
using ProiectII.Database;
using ProiectII.Restaurant;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProiectII
{
    public partial class Form1 : Form
    {
        private RestaurantView pnlRestaurant;
        private Clase.Meniu Menu;
        private bool admin;
        public Form1(bool admin)
        {
            InitializeComponent();
            this.admin = admin;      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double totaltavlue = RestaurantView.FocusTable.Model.Reciept.CloseReciept();
            
            DialogResult result=MessageBox.Show("Want to close Reciept for:"+ totaltavlue.ToString(),"Are you sure ?",MessageBoxButtons.YesNo);
            if(result==DialogResult.Yes)
            {
                var dbCon = DBConnection.Instance();
                if (dbCon.IsConnect())
                {
                    //suppose col0 and col1 are defined as VARCHAR in the DB
                    string query = "INSERT INTO `proiectii`.`reciept`(`OraData`,`Valoare`,`Masa`,`Item`)VALUES(\""+DateTime.Now.ToString()+"\","+ totaltavlue .ToString()+",\""+ RestaurantView.FocusTable.Model.Id.ToString()+"\",\""+ RestaurantView.FocusTable.Model.Reciept.ToString()+ "\");";
                    var cmd = new MySqlCommand(query, dbCon.Connection);
                    var reader = cmd.ExecuteReader();
                    dbCon.Close();
                }
                RestaurantView.FocusTable.Model.Reciept.Items.Clear();
                lstItems.Items.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                openFileDialog1.InitialDirectory = "c:\\";
                openFileDialog1.Filter = "JSON files (*.json)|*.json";
                openFileDialog1.FilterIndex = 0;
                openFileDialog1.RestoreDirectory = true;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if(pnlRestaurant!=null)
                    {
                        pnlRestaurant.Hide();
                        pnlRestaurant = null;
                    }
                    string directory = Resources.Util.GetDirectoryOfFile(openFileDialog1.FileName);
                    string selectedFileName = openFileDialog1.FileName;
                    string restaurant = selectedFileName.Split('\\')[selectedFileName.Split('\\').Length - 1].Split('.')[0];
                    string path = selectedFileName;
                    #region restaurant_pozitii
                    JObject o1 = JObject.Parse(File.ReadAllText(path));

                    // read JSON directly from a file
                    using (StreamReader file = File.OpenText(path))
                    using (JsonTextReader reader = new JsonTextReader(file))
                    {
                        JObject restaurant_pozition_json = (JObject)JToken.ReadFrom(reader);
                        int width = Convert.ToInt32(restaurant_pozition_json[restaurant]["Dimensiuni"].ToString().Split(':')[1]);
                        int height = Convert.ToInt32(restaurant_pozition_json[restaurant]["Dimensiuni"].ToString().Split(':')[0]);
                        pnlRestaurant = new RestaurantView(height, width, this.Size, restaurant);
                        this.Controls.Add(pnlRestaurant);
                        var tables = restaurant_pozition_json[restaurant]["Mese"];
                        int i = 1;
                        foreach (var table in tables)
                        {
                            pnlRestaurant.AddTable(new Table(new TableModel(table, pnlRestaurant.GetXRatio(), pnlRestaurant.GetYRatio(), i++, lstItems)));
                        }

                    }
                    #endregion
                    #region meniu_restaurant
                    using (StreamReader file = File.OpenText(directory + "Menu.json"))
                    using (JsonTextReader reader = new JsonTextReader(file))
                    {
                        JObject menu_json = (JObject)JToken.ReadFrom(reader);
                        this.Menu = new Clase.Meniu(directory);
                        foreach (var item in menu_json)
                        {
                            Item MenuItem = new Item(item.Value);
                            Menu.AddItem(MenuItem);
                        }

                    }
                    #endregion
                    btnCloseReciept.Show();
                    btnAddItems.Show();

                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }


        }
        public static DirectoryInfo TryGetSolutionDirectoryInfo(string currentPath = null)
        {
            var directory = new DirectoryInfo(
                currentPath ?? Directory.GetCurrentDirectory());
            while (directory != null && !directory.GetFiles("*.sln").Any())
            {
                directory = directory.Parent;
            }
            return directory;
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            try
            {
                if (RestaurantView.FocusTable != null)
                {
                    AddItemsForms forms = new AddItemsForms(this.Menu, RestaurantView.FocusTable.Model.Reciept);
                    forms.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            string directory = AppDomain.CurrentDomain.BaseDirectory+"\\LaMarcel\\";
            string selectedFileName = AppDomain.CurrentDomain.BaseDirectory+ "\\LaMarcel\\LaMarcel.json";
            string restaurant = selectedFileName.Split('\\')[selectedFileName.Split('\\').Length - 1].Split('.')[0];
            string path = selectedFileName;
            #region restaurant_pozitii
            JObject o1 = JObject.Parse(File.ReadAllText(path));

            // read JSON directly from a file
            using (StreamReader file = File.OpenText(path))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JObject restaurant_pozition_json = (JObject)JToken.ReadFrom(reader);
                int width = Convert.ToInt32(restaurant_pozition_json[restaurant]["Dimensiuni"].ToString().Split(':')[1]);
                int height = Convert.ToInt32(restaurant_pozition_json[restaurant]["Dimensiuni"].ToString().Split(':')[0]);
                pnlRestaurant = new RestaurantView(height, width, this.Size, restaurant);
                this.Controls.Add(pnlRestaurant);
                var tables = restaurant_pozition_json[restaurant]["Mese"];
                int i = 1;
                foreach (var table in tables)
                {
                    pnlRestaurant.AddTable(new Table(new TableModel(table, pnlRestaurant.GetXRatio(), pnlRestaurant.GetYRatio(), i++, lstItems)));
                }

            }
            #endregion
            #region meniu_restaurant
            using (StreamReader file = File.OpenText(directory + "Menu.json"))
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                JObject menu_json = (JObject)JToken.ReadFrom(reader);
                this.Menu = new Clase.Meniu(directory);
                foreach (var item in menu_json)
                {
                    Item MenuItem = new Item(item.Value);
                    Menu.AddItem(MenuItem);
                }

            }
            #endregion
            btnCloseReciept.Show();
            btnAddItems.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                LoginForm.Me.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
