using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LatvanyossagApplication
{
    public partial class Form1 : Form
    {
        MySqlConnection connection;
        public Form1()
        {
            InitializeComponent();

            connection = new MySqlConnection("Server=localhost; Database=latvanyossagokdb; Uid=root; Pwd=;");
            try
            {
                connection.Open();
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "CREATE TABLE IF NOT EXISTS varosok(id int(11) NOT NULL AUTO_INCREMENT, nev text COLLATE utf8mb4_hungarian_ci NOT NULL, lakossag int(11) NOT NULL, PRIMARY KEY(id), UNIQUE KEY nev(nev) USING HASH)";
                MySqlDataReader reader = command.ExecuteReader();
                reader.Close();
                
                command = connection.CreateCommand();
                command.CommandText = "CREATE TABLE IF NOT EXISTS latvanyossagok (id int(11) NOT NULL AUTO_INCREMENT, varos_id int(11), nev text COLLATE utf8mb4_hungarian_ci NOT NULL, leiras text COLLATE utf8mb4_hungarian_ci NOT NULL, ar int(11) DEFAULT NULL, PRIMARY KEY(id), FOREIGN KEY(varos_id) REFERENCES varosok(id))";
                reader = command.ExecuteReader();
                reader.Close();

                varoslista_frissites();
            }
            catch (Exception ex)
            {  
                DialogResult hibaUzenet = MessageBox.Show("Hiba a kapcsolódásnál." + ex);
                if (hibaUzenet == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void Városok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (varosok_listBox.SelectedIndex != -1)
            {
                latvanyossag_frissites();
            }
        }

        private void bttn_varoshoz_Click(object sender, EventArgs e)
        {
            if (varosneve_txtBox.Text != "")
            {
                try
                {
                    MySqlCommand command = connection.CreateCommand();
                    command.CommandText = "INSERT INTO varosok (nev, lakossag) VALUES('" + varosneve_txtBox.Text + "', " + lakossag_varos_updown.Value + ")";
                    MySqlDataReader reader = command.ExecuteReader();
                    reader.Close();

                    varoslista_frissites();
                }
                catch
                {
                    MessageBox.Show("Van már ilyen város!");
                }
            }
        }

        private void bttn_latvanyhoz_Click(object sender, EventArgs e)
        {
            if (varosok_listBox.SelectedIndex != -1)
            {
                if (bttn_latvanyhoz.Text != "")
                {
                    try
                    {
                        MySqlCommand command = connection.CreateCommand();
                        command.CommandText = "INSERT INTO latvanyossagok (varos_id, nev, leiras, ar) VALUES(" + ((Varos)varosok_listBox.SelectedItem).Id + ", '" + latvanyossagneve_txtBox.Text + "', '" + leiras_txtBox.Text + "', " + latvanyar_upDown.Value + ")";
                        MySqlDataReader reader = command.ExecuteReader();
                        reader.Close();

                        latvanyossag_frissites();
                    }
                    catch
                    {
                        MessageBox.Show("Hibás felvétel!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Válasszon ki egy várost!");
            }
        }

        private void varoslista_frissites()
        {
            varosok_listBox.Items.Clear();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM varosok";
            MySqlDataReader reader = command.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    varosok_listBox.Items.Add(new Varos(int.Parse(reader.GetString("id")), reader.GetString("nev"), int.Parse(reader.GetString("lakossag"))));
                }
            }
            reader.Close();
        }

        private void latvanyossag_frissites()
        {
            latvanyossag_listBox.Items.Clear();
            MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT * FROM latvanyossagok WHERE varos_id LIKE " + ((Varos)varosok_listBox.SelectedItem).Id;
            MySqlDataReader reader = command.ExecuteReader();
            using (reader)
            {
                while (reader.Read())
                {
                    latvanyossag_listBox.Items.Add(new Latvanyossag(int.Parse(reader.GetString("id")), reader.GetString("nev"), reader.GetString("leiras"), int.Parse(reader.GetString("ar")), int.Parse(reader.GetString("varos_id"))));
                }
            }
            reader.Close();
        }

        private void bttn_varosTorles_Click(object sender, EventArgs e)
        {
            if (varosok_listBox.SelectedIndex != -1)
            {
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "DELETE FROM latvanyossagok WHERE varos_id LIKE " + ((Varos)varosok_listBox.SelectedItem).Id;
                MySqlDataReader reader = command.ExecuteReader();
                reader.Close();

                command = connection.CreateCommand();
                command.CommandText = "DELETE FROM varosok WHERE id LIKE " + ((Varos)varosok_listBox.SelectedItem).Id;
                reader = command.ExecuteReader();
                reader.Close();
                latvanyossag_listBox.Items.Clear();

                varoslista_frissites();
            }
        }

        private void bttn_latvanyTorles_Click(object sender, EventArgs e)
        {
            if (latvanyossag_listBox.SelectedIndex != -1)
            {
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "DELETE FROM latvanyossagok WHERE id LIKE " + ((Latvanyossag)latvanyossag_listBox.SelectedItem).Id;
                MySqlDataReader reader = command.ExecuteReader();
                reader.Close();

                latvanyossag_frissites();
            }
        }
    }
}
