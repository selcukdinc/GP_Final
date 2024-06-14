using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace GPFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string conStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\veriler.accdb";
        //OleDbConnection con = new OleDbConnection(conStr);
        string path = Application.StartupPath;
        private void Form1_Load(object sender, EventArgs e)
        {
            //veriOku();
            //tbPassword.UseSystemPasswordChar = true;
        }

        public void veriOku()
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(conStr))
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "select * from cihazlar";
                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    con.Open();
                    da.Fill(dt);
                    con.Close();
                    dgvVeriler.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri okunamadı, hata:\n" + ex.Message, "Hata");
            }
        }

        public void veriYaz()
        {
            try
            {
                using (OleDbConnection con = new OleDbConnection(conStr))
                using (OleDbCommand cmd = new OleDbCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "insert into cihazlar (cihaz_id, cihaz_ismi, cihaz_turu) values (P1,P2, P3)";
                    cmd.Parameters.Add("@P1", OleDbType.Integer).Value = Convert.ToInt32(tbCihazID.Text);
                    cmd.Parameters.Add("@P2", OleDbType.VarChar).Value = tbCihazIsim.Text;
                    cmd.Parameters.Add("@P2", OleDbType.VarChar).Value = tbCihazTur.Text;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri yazılamadı, hata:\n" + ex.Message, "Hata");
            }

        }

        public void sifirla()
        {
            //tbName.Text = "";
            //tbPassword.Text = "";
            //tbSurnmae.Text = "";
        }

        private void btnAyarDosyasıKontrol_Click(object sender, EventArgs e)
        {

            if (File.Exists(path + "\\ayarlar.ini"))
            {
                MessageBox.Show("ayarlar.ini dosyanız bulunuyor");
            }
            else
            {
                MessageBox.Show("ayarlar.ini dosyanız bulunmuyor");
            }
        }

        private void btnVeritabaniDosyaKontrol_Click(object sender, EventArgs e)
        {
            if (File.Exists(path + "\\veriler.accdb"))
            {
                MessageBox.Show("veriler.accdb dosyanız bulunuyor");
            }
            else if (File.Exists(path + "\\veriler.mdb"))
            {
                MessageBox.Show("veriler.mdb dosyanız bulunuyor");
            }
            else
            {
                MessageBox.Show("veriler.accdb dosyanız bulunmuyor");
            }
        }

        private void VeritabaniBaglantiKontrol_Click(object sender, EventArgs e)
        {
            try
            {
                // Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\bin\Debug\veriler.accdb
                string _con = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\veriler.accdb";
                OleDbConnection _conection = new OleDbConnection(_con);
                _conection.Open();
                _conection.Close();
                MessageBox.Show("Veritabanınız bağlı");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanınızın bağlantısı yapılamadı, hata:\n" + ex.Message);
            }
        }

        private void btnAyarOku_Click(object sender, EventArgs e)
        {
            if (File.Exists(path + "\\ayarlar.ini"))
            {
                lbAyarlar.Items.Clear();
                FileStream fs = new FileStream(path + "\\ayarlar.ini", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string _text;
                while ((_text = sr.ReadLine()) != null)
                {
                    lbAyarlar.Items.Add(_text);
                }
                sr.Close();
                fs.Close();
            }
            else
            {
                MessageBox.Show("ayarlar.ini dosyanız bulunmuyor");
            }
        }

        private void btnVeritabaniOku_Click(object sender, EventArgs e)
        {
            veriOku();
        }

        private void btnVeritabaniYaz_Click(object sender, EventArgs e)
        {
            veriYaz();
            veriOku();
        }

    }
}
