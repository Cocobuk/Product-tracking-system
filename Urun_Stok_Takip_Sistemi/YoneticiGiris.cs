using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Urun_Stok_Takip_Sistemi
{
    
    public partial class YoneticiGiris : Form
    {

        
        SqlDataReader dr_201104112; //Sql den okumasi icin deger atadim
        SqlCommand com_201104112;//Sql komut olusturdum
        public YoneticiGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=BURAK\\SQLEXPRESS;Initial Catalog=Urun_Stok_Takip_Sistemi;Integrated Security=True");
        //Sql baglantisi olusturdum
        private void button1_Click(object sender, EventArgs e)//Giris Butonu
        {
            



            try
            {



                com_201104112 = new SqlCommand();//yeni bir komut tanimladim 
                baglanti.Open();//Sql baglantisini actim
                com_201104112.Connection = baglanti;//Baglanmasini sagladim
                com_201104112.CommandText = "Select * From Yonetici_GIris where kullaniciadi='" + textBox1.Text + "'And Sifre='" + textBox2.Text + "'";//Sorgumu gonderdim
                dr_201104112 = com_201104112.ExecuteReader();
                if (dr_201104112.Read())//Eger veri tabani ile bilgiler dogru ise diger sayfa aciliyor
                {
                    CalisanEkle_Cikar eklecikar_201104112 = new CalisanEkle_Cikar();//Calisan cikar ekranini tanimladim
                    this.Hide();//YOnetici sayfasini gizledim
                    eklecikar_201104112.ShowDialog();//Calisan cikar sayfasini actim
                    textBox1.Text = "";//Girilen TC yi tekrar geri geldiginde tekrar girmesi icin sildim
                    textBox2.Text = "";//Girilen sifreyi tekrar geri geldiginde tekrar girmesi icin sildim
                    this.Show();//Geri dondugunde yonetici giris ekrani acilacak

                }

                else//Degilse hata veriyor ve tekrar girmesini istiyor
                {

                    if (textBox1.Text == "" && textBox2.Text == "")//TC ve sifreyi girmediginde hata mesaji veriyor
                    {
                        MessageBox.Show("TC yi ve Sifreyi Girmediniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else if (textBox1.Text == "")//TC alanini bos biraktiginda hata mesaji veriyor
                    {

                        MessageBox.Show("TC yi Girmediniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else if (textBox2.Text == "")//Sifreyi bos biraktiginda hata mesaji veriyor
                    {
                        MessageBox.Show("Sifreyi Girmediniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                    else//TC ya da sifre yanlis girilince hata mesaji veriyor
                    {

                        MessageBox.Show("Hatali Giris Yaptiniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }


                }
                baglanti.Close();//sql baglantiyi kapadim
            }
            catch (Exception)
            {

                MessageBox.Show("Bilinmeyen Bir Hata Olustu", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
















        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)//Enter Tusuna basildiginda alttaki deger e gecmesi icin
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
