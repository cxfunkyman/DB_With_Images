using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;

namespace DB_With_Images
{
    public partial class Images : Form
    {
        private static string connectionString = "Data Source=MSI;Initial Catalog=ImageDB;Integrated Security=True";
        
        public Images()
        {
            InitializeComponent();
        }

        private void Images_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();

            var image = new ImageConverter().ConvertTo(pictureBoxAddLoad.Image, typeof(Byte[]));

            cmd.Parameters.AddWithValue("@image", image);
            cmd.CommandText = "INSERT INTO Image_Table (image) VALUES (@image)";

            if(cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Image was added");
            }
            else
            {
                MessageBox.Show("Image was not added");
            }
            conn.Close();
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand cmd = conn.CreateCommand();

            var image = new ImageConverter().ConvertTo(pictureBoxAddLoad.Image, typeof(Byte[]));

            cmd.Parameters.AddWithValue("@id", textBoxID.Text);
            cmd.CommandText = "SELECT * FROM Image_Table WHERE id = @id";

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                MemoryStream ms = new MemoryStream(reader.GetSqlBytes(1).Buffer);
                pictureBoxFetch.Image = Image.FromStream(ms);             
            }
            else
            {
                pictureBoxFetch.Image = null;
                MessageBox.Show("Image was not found");                
            }
            conn.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog OD = new OpenFileDialog();

            OD.FileName = "";
            OD.Filter = "Supported Images|*.jpg;*.jpeg;*.png";

            if (OD.ShowDialog() == DialogResult.OK)
            {
                pictureBoxAddLoad.Load(OD.FileName);
            }
        }
    }
}
