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
    public partial class CalisanEkle : Form
    {
        public CalisanEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=BURAK\\SQLEXPRESS;Initial Catalog=Urun_Stok_Takip_Sistemi;Integrated Security=True");
        //Sql baglantisi sagladim

       
        private void button1_Click(object sender, EventArgs e)//Calisan Eklemem Butonu
        {


            try
            {






                if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "" && label6.Text == "")//Alanlar Bos ise hata vericek
                {
                    MessageBox.Show("Alanlari Doldurmadiniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (textBox1.Text == "")
                {
                    MessageBox.Show("Calisan TC_No Girmediniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("Sicil No Girmediniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (textBox3.Text == "")
                {
                    MessageBox.Show("Ad i Girmediniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (textBox4.Text == "")
                {
                    MessageBox.Show("Soyad i Girmediniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (label6.Text == "")
                {
                    MessageBox.Show("Cinsiyeti i Girmediniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);//Cinsiyet girilmedigi icin bos bir deger dondugunden tekrardan if-else yapisiyla tekrardan radiobutonu ile kontrol edildi




                }


                else
                {


                    baglanti.Open();//Sql baglantisini actim

                    SqlCommand komut_201104112 = new SqlCommand("insert into Calisan_Ekleme (Calisan_TC_No,Sicil_No,Ad,Soyad,Cinsiyet) values (@p1,@p2,@p3,@p4,@p5)", baglanti);//Sorgumu yazdim
                    komut_201104112.Parameters.AddWithValue("@p1", textBox1.Text);//Sql parametrelerimi hangisine tanimladimi yazarak gonderdim
                    komut_201104112.Parameters.AddWithValue("@p2", textBox2.Text);//Sql parametrelerimi hangisine tanimladimi yazarak gonderdim
                    komut_201104112.Parameters.AddWithValue("@p3", textBox3.Text);//Sql parametrelerimi hangisine tanimladimi yazarak gonderdim
                    komut_201104112.Parameters.AddWithValue("@p4", textBox4.Text);//Sql parametrelerimi hangisine tanimladimi yazarak gonderdim

                    if (radioButton1.Checked)
                    {
                        label6.Text = "Kadin";//Radiobutonu1 seciliyse label6 degeri yaziyor
                        komut_201104112.Parameters.AddWithValue("@p5", label6.Text);//Sql parametrelerimi hangisine tanimladimi yazarak gonderdim
                    }
                    else
                    {
                        label6.Text = "Erkek";//Radiobutonu2 seciliyse label6 degeri yaziyor
                        komut_201104112.Parameters.AddWithValue("@p5", label6.Text);//Sql parametrelerimi hangisine tanimladimi yazarak gonderdim
                    }

                   
                    komut_201104112.ExecuteNonQuery();//Sql islemlerini yapmasi icin 
                    textBox1.Text = "";//Ekleme yaptiktan sonra girilen degerleri silmesi icin 
                    textBox2.Text = "";//Ekleme yaptiktan sonra girilen degerleri silmesi icin 
                    textBox3.Text = "";//Ekleme yaptiktan sonra girilen degerleri silmesi icin 
                    textBox4.Text = "";//Ekleme yaptiktan sonra girilen degerleri silmesi icin 
                    radioButton1.Checked = false;//Ekleme yaptiktan sonra girilen degerleri silmesi icin 
                    radioButton2.Checked = false;//Ekleme yaptiktan sonra girilen degerleri silmesi icin 
                    MessageBox.Show("Kayit Basariyla Olusturuldu", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    baglanti.Close();//Sql baglantisini kapadim
                }

                label6.Text = "";//Buton basildiktan sonra tekrardan cinsiyet yazisini sifirlamasi icin


            }
            catch (Exception)
            {

                MessageBox.Show("Ayni TC den 1 den fazla olamaz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
        }









        private void CalisanEkle_Load(object sender, EventArgs e)
        {
            label6.Text="";
            label6.Visible = false;//label6 nin gorunmesi engellemek icin olan kodu
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label6.Text = "Kadin";//Radiobutonu1 seciliyse label6 degeri yaziyor
            }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                label6.Text = "Erkek";//Radiobutonu1 seciliyse label6 degeri yaziyor
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
            if (e.KeyCode == Keys.Enter)//Enter Tusuna basildiginda alttaki deger e gecmesi icin
            {
                textBox3.Focus();
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Enter Tusuna basildiginda alttaki deger e gecmesi icin
            {
                textBox4.Focus();
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Enter Tusuna basildiginda alttaki deger e gecmesi icin
            {
                radioButton1.Focus();
            }
        }

        private void radioButton1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Enter Tusuna basildiginda alttaki deger e gecmesi icin
            {
                radioButton2.Focus();
            }
        }

      
    }
}
