using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Urun_Stok_Takip_Sistemi
{
    public partial class CalisanEkle_Cikar : Form
    {
        public CalisanEkle_Cikar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//CALISAN EKLE BUTONU
        {
            CalisanEkle ekle = new CalisanEkle();//Calisan ekle butonuna basildiginda yeni form olusturcak
            this.Hide();//Bu formu gizlicek
            ekle.ShowDialog();//Calisan ekle sayfasini gostericek
            this.Show();//Calisan ekle sayfasi kapatildiginda calisan ekle-cikar sayfasi geri acilacak



        }

        private void button2_Click(object sender, EventArgs e)//CALISAN CIKAR BUTONU
        {
            CalisanCikar cikar = new CalisanCikar();//Calisan cikar butonuna basildiginda yeni form olusturcak
            this.Hide();//Bu formu gizlicek
            cikar.ShowDialog();//Calisan cikar sayfasini gostericek
            this.Show();//Calisan cikar sayfasi kapatildiginda calisan ekle-cikar sayfasi geri acilacak
        }
    }
}
