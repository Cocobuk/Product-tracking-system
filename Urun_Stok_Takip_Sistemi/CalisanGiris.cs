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
namespace Urun_Stok_Takip_Sistemi
{
    public partial class CalisanGiris : Form
    {
        public CalisanGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=BURAK\\SQLEXPRESS;Initial Catalog=Urun_Stok_Takip_Sistemi;Integrated Security=True");
        //Sql baglantimi sagladim
        SqlDataReader dr_201104112;//Sql den okumasi icin deger atadim
        SqlCommand com_201104112;//Sql komut olusturdum
        private void button1_Click(object sender, EventArgs e)//Giris Butonu
        {

            try
            {


            baglanti.Open();//Sql baglantimi actim
            com_201104112 = new SqlCommand();//Sql komutumu bir degere atadim

            com_201104112.Connection = baglanti;//Sql e baglanmasi icin
            com_201104112.CommandText = "Select * From Calisan_Ekleme where Calisan_TC_No='" + textBox1.Text + "'And Sicil_No='" + textBox2.Text + "'";//Sql sorgumu gonderdim
            dr_201104112 = com_201104112.ExecuteReader();//Sql de okumasi icin
            if (dr_201104112.Read())//Sql de degeri okuyup dogruysa Urun ekleme ekrani acilacak
            {
                UrunEkranı urunler_201104112 = new UrunEkranı();//Urun ekleme ekrani acilmasi icin yeni form olusturdum
                this.Hide();//Urun ekrani acildiginda calisan giris ekranini gizlicek
                urunler_201104112.ShowDialog();//Urun ekranini gostericek
                textBox1.Text = "";//Urun ekranini acildiktan sonra TC yi silicek ve kapandiginda bir daha girmek zorunda kalicak
                textBox2.Text = "";//Urun ekranini acildiktan sonra TC yi silicek ve kapandiginda bir daha girmek zorunda kalicak
                this.Show();//Urun ekrani kapandiktan sonra calisan ekrani acilicak

            }

            else
            {
                if (textBox1.Text == "" && textBox2.Text == "")//Eger textbox degerleri bos birakilirsa hata vericek
                {
                    MessageBox.Show("TC yi Ve Sifreyi Girmediniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (textBox1.Text == "")
                {

                    MessageBox.Show("TC Girmediniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("Sifreyi Girmediniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {

                    MessageBox.Show("Hatali Giris Yaptiniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }


            }
            baglanti.Close();//Sql baglantisini kapadim
        }
             catch (Exception)
            {

                MessageBox.Show("Beklenmedik bir hata olustu", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Enter Tusuna basildiginda alttaki deger e gecmesi icin
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Enter tusuna basildiginda buton a direk basmis olarak algilicak ve giris yapicak
            {
                button1.PerformClick();
            }
        }
    }
}
