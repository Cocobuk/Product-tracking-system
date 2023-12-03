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
    public partial class CalisanCikar : Form
    {
        SqlCommand komut_201104112;//Sql komut olusturdum
        public CalisanCikar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=BURAK\\SQLEXPRESS;Initial Catalog=Urun_Stok_Takip_Sistemi;Integrated Security=True");
        //Sql baglantimi bagladim
        private void button2_Click(object sender, EventArgs e)//CALISAN CIKARMA BUTONU
        {
            try
            {



                baglanti.Open();//Sql baglantisini actim
                string sorgu = "DELETE FROM Calisan_EKleme WHERE CAlisan_TC_No=@k1";//Sql sorgumu yazdim
                komut_201104112 = new SqlCommand(sorgu, baglanti);//Sql komutumu yazdim
                komut_201104112.Parameters.AddWithValue("@k1", textBox1.Text);//textbox1 de yazilan TC yi atadim
                komut_201104112.ExecuteNonQuery();//Sql islemlerini yapmasi icin 
                baglanti.Close();//Sql baglantimi kapadim
                MessageBox.Show("Kayit Basariyla Silindi","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                textBox1.Clear();//textbox da ki yazilan degeri islem yapildiktan sonra temizliyor
                dataGridView1.DataSource = yenile();//Form yuklendiginde dataGridView e bilgiler direk gelmesi icin olusturdugum fonksiyonu cektim

            }
            catch (Exception)
            {

                MessageBox.Show("Bilinmeyen Bir Hata Olustu", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void button1_Click(object sender, EventArgs e)//ARAMA BUTONU
        {
            try
            {



                int hata_201104112 = 0;
                if (textBox1.Text == string.Empty)//EGer arama butonuna bastiginda textbox a deger girmediyse hata veriyor
                {
                    hata_201104112 = 1;
                }
                if (hata_201104112 == 1)
                {
                    MessageBox.Show("Arama Alanini Doldurun");
                }

                else
                {
                    baglanti.Open();//Sql baglantisini actim
                    SqlCommand komut_201104112 = new SqlCommand("Select * from Calisan_Ekleme where Calisan_TC_No like'%" + textBox1.Text + "%'", baglanti);//Sql sorgumu yaptim
                    SqlDataAdapter da_201104112 = new SqlDataAdapter(komut_201104112);//Sql baglantisi okumasi icin degere atadim
                    DataSet ds_201104112 = new DataSet();//Sql den veri almasi icin degere atadim
                    da_201104112.Fill(ds_201104112);//Verileri satirlari eklmesi ve yenilemesi icin dataset i gonderdim
                    dataGridView1.DataSource = ds_201104112.Tables[0];//dataGridView de arama yapmasi icin
                    baglanti.Close();//Sql baglantisini kapadim
                    this.calisan_EklemeTableAdapter1.Fill(this.urun_Stok_Takip_SistemiDataSet6.Calisan_Ekleme);//dataGridView e sql de ki degerleri getirmesi icin

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Bilinmeyen Bir Hata Olustu", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen_201104112 = dataGridView1.SelectedCells[0].RowIndex;

            textBox1.Text = dataGridView1.Rows[secilen_201104112].Cells[0].Value.ToString();//dataGridView den bir calisana 2 kere basildiginda textbox TC sini yazmasi icin


        }

        private void CalisanCikar_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = yenile();//Form yuklendiginde dataGridView e bilgiler direk gelmesi icin olusturdugum fonksiyonu cektim

        }

       
        DataTable yenile()//Sql da ki listeleri dataGridView e cekmesi icin yeni bir fonksiyon olusturdum 
        {
            baglanti.Open();//Sql baglantimi actim
            SqlDataAdapter adtr_201104112 = new SqlDataAdapter("select *from Calisan_Ekleme", baglanti);//Sql sorgumu gonderdim
            DataTable tablo_201104112 = new DataTable();//Sutun ve satirlari getirmesi icin
            adtr_201104112.Fill(tablo_201104112);//Verileri satirlari eklmesi ve yenilemesi icin dataset i gonderdim
            baglanti.Close();//Sql baglantimi kapadim
            return tablo_201104112;//Tablo degerini geri dondurdum
        }

    }
}
