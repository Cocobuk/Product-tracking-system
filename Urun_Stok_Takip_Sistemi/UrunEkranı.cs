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
    public partial class UrunEkranı : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=BURAK\\SQLEXPRESS;Initial Catalog=Urun_Stok_Takip_Sistemi;Integrated Security=True");
        //Sql baglantimi bagladim
        public UrunEkranı()
        {
            InitializeComponent();
        }
        SqlCommand komut_201104112;//Sql komut olusturdum
        DataTable tablo_201104112 = new DataTable();//Sql den veri almasi icin 

        private void UrunEkranı_Load(object sender, EventArgs e)
        {
            
            this.urun_EkraniTableAdapter1.Fill(this.urun_Stok_Takip_SistemiDataSet7.Urun_Ekrani);//Veri tabanindaki degerleri Form yuklendiginde getirmesi icin

            comboBox1.Items.AddRange(new string[] { "A", "B", "C", "D", "E", "F", "G" });//Combobox a belli olan degerleri form yuklendiginde getirmesi icin yazdim
        }

        private void button1_Click(object sender, EventArgs e)//URUN EKLEME BUTONU
        {
            try
            {

            


            if (textBox1.Text == "")//Model no bos birakilirsa hata vermesi icin
            {
                MessageBox.Show("Model No Bos Bırakılamaz");
            }
            else
            {
                baglanti.Open();//Sql baglantimi actim
                komut_201104112 = new SqlCommand("insert into Urun_Ekrani(Model_No,Urun_Rengi,Toplam_Hacim,Enerji_Sinifi) values (@p1,@p2,@p3,@p4)", baglanti);//Sql sorgumu gonderdim
                komut_201104112.Parameters.AddWithValue("@p1", textBox1.Text);//Sql parametrelerimi hangisine tanimladimi yazarak gonderdim
                komut_201104112.Parameters.AddWithValue("@p2", textBox2.Text);//Sql parametrelerimi hangisine tanimladimi yazarak gonderdim
                komut_201104112.Parameters.AddWithValue("@p3", textBox3.Text);//Sql parametrelerimi hangisine tanimladimi yazarak gonderdim
                komut_201104112.Parameters.AddWithValue("@p4", comboBox1.Text);//Sql parametrelerimi hangisine tanimladimi yazarak gonderdim
                komut_201104112.ExecuteNonQuery();//Sql islemlerini yapmasi icin 
                baglanti.Close();//Sql baglantisini kapadim
                
                dataGridView1.DataSource = yenile();//Sql de bilgileri yenileyip dataGridView e yazmasi icin
                textBox1.Text = "";//Urun eklendikten sonra bilgileri temizlemesi icin
                textBox2.Text = "";//Urun eklendikten sonra bilgileri temizlemesi icin
                textBox3.Text = "";//Urun eklendikten sonra bilgileri temizlemesi icin
                comboBox1.Text = "";//Urun eklendikten sonra bilgileri temizlemesi icin
                MessageBox.Show("Urun Basariyla Eklendi", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                }
        }
             catch (Exception)
            {

                MessageBox.Show("Ayni Model No dan 1 den fazla olamaz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)//SILME BUTONU
        {
            try
            {


                baglanti.Open();//Sql baglantisini actim
                string sorgu = "DELETE FROM Urun_Ekrani WHERE Model_No=@k1";//Sql sorgusu yaptim
                komut_201104112 = new SqlCommand(sorgu, baglanti);//Sql komutunu bir degere atadim
                komut_201104112.Parameters.AddWithValue("@k1", textBox1.Text);//Sql atatigim parametreleri hangi degerden alicagini girdim
                komut_201104112.ExecuteNonQuery();//Sql islemlerini yapmasi icin 
                baglanti.Close();//Sql baglantimi kapadim
                MessageBox.Show("Urun Basariyla Silindi","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                textBox4.Clear();//Textbox i silme isleminden sonra temizledim
                textBox1.Text = "";//Textbox i silme isleminden sonra temizledim
                textBox2.Text = "";//Textbox i silme isleminden sonra temizledim
                textBox3.Text = "";//Textbox i silme isleminden sonra temizledim
                comboBox1.Text = "";//Textbox i silme isleminden sonra temizledim

                dataGridView1.DataSource = yenile();//dataGridViwe yenilenen listeyi guncel haliyle getirmesi icin yenile fonksiyonunu cagirdim
            }
            catch (Exception)
            {

                MessageBox.Show("Bilinmeyen Bir Hata Olustu", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
       
        private void button2_Click(object sender, EventArgs e)//MODEL ARAMA BUTONU
        {
            try
            {


                int hata_201104112 = 0;
                if (textBox4.Text == string.Empty)//Eger textbox4 bos ise hata vericek
                {
                    hata_201104112 = 1;
                }
                if (hata_201104112 == 1)
                {
                    MessageBox.Show("Arama Alanini Doldurun");
                }

                else
                {
                    baglanti.Open();//Sql baglantimi actim
                    SqlCommand komut_201104112 = new SqlCommand("Select *from Urun_Ekrani where Model_No like'%" + textBox4.Text + "%'", baglanti);//Sql sorgumu gonderdim
                    SqlDataAdapter da_201104112 = new SqlDataAdapter(komut_201104112);//Sql baglantisi okumasi icin degere atadim
                    DataSet ds_201104112 = new DataSet();//Sql den veri almasi icin degere atadim
                    da_201104112.Fill(ds_201104112);//Verileri satirlari eklmesi ve yenilemesi icin dataset i gonderdim
                    dataGridView1.DataSource = ds_201104112.Tables[0];//dataGridView de arama yapmasi icin
                    baglanti.Close();//Sql baglantisini kapadim
                    this.urun_EkraniTableAdapter1.Fill(this.urun_Stok_Takip_SistemiDataSet7.Urun_Ekrani);//dataGridView e guncel urunleri listelemesi icin


                }
            }
            catch (Exception)
            {

                MessageBox.Show("Bilinmeyen Bir Hata Olustu", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button3_Click(object sender, EventArgs e)//GUNCELLEME BUTONU
        {

            try
            {


                baglanti.Open();//Sql baglantimi actim
                string sorgu_201104112 = "update Urun_Ekrani set Urun_Rengi=@a1,Toplam_Hacim=@a2,Enerji_Sinifi=@a3 where Model_No=@a4";//Sql sorgumu gonderdim
                SqlCommand komutguncelle_201104112 = new SqlCommand(sorgu_201104112, baglanti);//Sql baglantisi okumasi icin degere atadim
                komutguncelle_201104112.Parameters.AddWithValue("@a4", textBox1.Text);//Sql atatigim parametreleri hangi degerden alicagini girdim
                komutguncelle_201104112.Parameters.AddWithValue("@a1", textBox2.Text);//Sql atatigim parametreleri hangi degerden alicagini girdim
                komutguncelle_201104112.Parameters.AddWithValue("@a2", textBox3.Text);//Sql atatigim parametreleri hangi degerden alicagini girdim
                komutguncelle_201104112.Parameters.AddWithValue("@a3", comboBox1.Text);//Sql atatigim parametreleri hangi degerden alicagini girdim
                komutguncelle_201104112.ExecuteNonQuery();//Sql islemlerini yapmasi icin 
                baglanti.Close();//Sql baglantimi kapadim
                MessageBox.Show("Urun Basariyla Guncellendi","",MessageBoxButtons.OK,MessageBoxIcon.Information);

                dataGridView1.DataSource = yenile();//dataGridView e guncel urunleri listelemesi icin
            }
            catch (Exception)
            {

                MessageBox.Show("Bilinmeyen Bir Hata Olustu", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = yenile();

         


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                int secilen_201104112 = dataGridView1.SelectedCells[0].RowIndex;//dataGridView de ki degere cift tiklandiginde degeri textbox ve combobox yazmasi icin

                textBox1.Text = dataGridView1.Rows[secilen_201104112].Cells[0].Value.ToString();
                textBox4.Text = dataGridView1.Rows[secilen_201104112].Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.Rows[secilen_201104112].Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.Rows[secilen_201104112].Cells[2].Value.ToString();
                comboBox1.Text = dataGridView1.Rows[secilen_201104112].Cells[3].Value.ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("Beklenmedik Bir Hata Olustu", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }
        DataTable yenile()//Sql de verileri getirmesi icin fonksiyon olusturdum
        {
            baglanti.Open();//Sql baglantimi actim
            SqlDataAdapter adtr_201104112 = new SqlDataAdapter("select *from Urun_Ekrani", baglanti);//Sql sorgumu gonderdim
            DataTable tablo_201104112 = new DataTable();//Sutun ve satirlari getirmesi icin
            adtr_201104112.Fill(tablo_201104112);//Verileri satirlari eklmesi ve yenilemesi icin dataset i gonderdim
            baglanti.Close();//Sql baglantimi kapadim
            return tablo_201104112;//Tablo degerini geri dondurdum
        }
    }
}
