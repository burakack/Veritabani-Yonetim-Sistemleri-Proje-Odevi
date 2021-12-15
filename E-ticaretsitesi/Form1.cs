using System;
using Npgsql;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_ticaretsitesi
{
    public partial class Form1 : Form
    {
        public Form1() 
        {
            InitializeComponent();
        }
        NpgsqlConnection connection = new NpgsqlConnection("server=localHost;port=5432;Database=Odev;user Id=postgres;password=mert2010");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Listele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from urunlergetir()";
            NpgsqlDataAdapter daadapter = new NpgsqlDataAdapter(sorgu, connection);
            DataSet ds = new DataSet();
            daadapter.Fill(ds);
            Dataekran.DataSource = ds.Tables[0];
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void Satinal_TabIndexChanged(object sender, EventArgs e)
        {
            string sorgu = "select * from urunlergetir()";
            NpgsqlDataAdapter daadapter = new NpgsqlDataAdapter(sorgu, connection);
            DataSet ds = new DataSet();
            daadapter.Fill(ds);
            Dataekran.DataSource = ds.Tables[0];
        }

        private void Urunekle_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM Urunekle('"+urunad.Text+"'"+", "+urunsatici.Text + ", "+ urunfiyat.Text + ");";
            NpgsqlDataAdapter daadapter = new NpgsqlDataAdapter(sorgu, connection);
            DataSet ds = new DataSet();
            daadapter.Fill(ds);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void Urunlerilistele_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM urunlergetir()";
            NpgsqlDataAdapter daadapter = new NpgsqlDataAdapter(sorgu, connection);
            DataSet ds = new DataSet();
            daadapter.Fill(ds);
            Satinaldataekran.DataSource = ds.Tables[0];

        }

        private void urunsil_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM urunsil('" + urunad.Text + "'" + ", " + urunsatici.Text + ", " + urunfiyat.Text + ")";
            NpgsqlDataAdapter daadapter = new NpgsqlDataAdapter(sorgu, connection);
            DataSet ds = new DataSet();
            daadapter.Fill(ds);
        }

        private void saticilistele_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM saticilargetir()";
            NpgsqlDataAdapter daadapter = new NpgsqlDataAdapter(sorgu, connection);
            DataSet ds = new DataSet();
            daadapter.Fill(ds);
            saticidata.DataSource = ds.Tables[0];

        }

        private void saticiekle_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM Saticiekle('" + saticiad.Text + "'" + ",'" + saticisoyad.Text + "');";
            NpgsqlDataAdapter daadapter = new NpgsqlDataAdapter(sorgu, connection);
            DataSet ds = new DataSet();
            daadapter.Fill(ds);
        }

        private void saticisil_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM Saticisil('" + saticiad.Text + "'" + ",'" + saticisoyad.Text + "');";
            NpgsqlDataAdapter daadapter = new NpgsqlDataAdapter(sorgu, connection);
            DataSet ds = new DataSet();
            daadapter.Fill(ds);
        }

        private void Musterikayit_Click(object sender, EventArgs e)
        {

        }

        private void Musterilistele_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM Musterilergetir();";
            NpgsqlDataAdapter daadapter = new NpgsqlDataAdapter(sorgu, connection);
            DataSet ds = new DataSet();
            daadapter.Fill(ds);
            Musteridata.DataSource = ds.Tables[0];
        }

        private void Musteriekle_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM Musteriekle('" + musteriad.Text + "'" + ",'" + musterisoyad.Text + "'" + ",'" + musteridogum.Text + "'); ";
            NpgsqlDataAdapter daadapter = new NpgsqlDataAdapter(sorgu, connection);
            DataSet ds = new DataSet();
            daadapter.Fill(ds);
        }

        private void Musteriadresbagla_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM Adresekle(" + Musteriid.Text + "," + İlkodu.Text + "," + İlcekodu.Text + ",'" + Sokak.Text + "','" + Apartman.Text + "'," +  Kapino.Text + "); ";
            NpgsqlDataAdapter daadapter = new NpgsqlDataAdapter(sorgu, connection);
            DataSet ds = new DataSet();
            daadapter.Fill(ds);

        }

        private void Satınal_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM urunsatinal('" + satinalad.Text + "'" + ", " + satinalsatici.Text + ", " + satinalfiyat.Text + ");";
            NpgsqlDataAdapter daadapter = new NpgsqlDataAdapter(sorgu, connection);
            DataSet ds = new DataSet();
            daadapter.Fill(ds);
        }

        private void urunfiyatguncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "SELECT * FROM urunguncelle(" + urunguncelleid.Text + ",'" + urunguncellead.Text + "'," + urunguncellefiyat.Text + ");";
            NpgsqlDataAdapter daadapter = new NpgsqlDataAdapter(sorgu, connection);
            DataSet ds = new DataSet();
            daadapter.Fill(ds);
        }
    }
}
