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
                command.ExecuteReader();

                command = connection.CreateCommand();
                command.CommandText = "CREATE TABLE IF NOT EXISTS latvanyossagok (id int(11) NOT NULL AUTO_INCREMENT, varos_id int(11), nev text COLLATE utf8mb4_hungarian_ci NOT NULL, leiras text COLLATE utf8mb4_hungarian_ci NOT NULL, ar int(11) DEFAULT NULL, PRIMARY KEY(id), FOREIGN KEY(varos_id) REFERENCES varosok(id))";
                command.ExecuteReader();

                command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM varosok";
                MySqlDataReader reader;
                reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        varosok_listBox.Items.Add(new Varos(int.Parse(reader.GetString("id")), reader.GetString("nev"), int.Parse(reader.GetString("lakossag"))));
                    }
                }
                reader.Close();
            }
            catch
            {  
                DialogResult hibaUzenet = MessageBox.Show("Hiba a kapccsolódásnál.");
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
                MySqlCommand command = connection.CreateCommand();
                command = connection.CreateCommand();
                command.CommandText = "SELECT * FROM latvanyossagok WHERE varos_id LIKE " + ((Varos)varosok_listBox.SelectedItem).Id;
                MySqlDataReader reader;
                reader = command.ExecuteReader();
                using (reader)
                {
                    while (reader.Read())
                    {
                        latvanyossag_listBox.Items.Add();
                    }
                }
                reader.Close();
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
                    command.ExecuteReader();
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
                        command.ExecuteReader();
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
    }
}
