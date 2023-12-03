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
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//Yonetici Giris Butonu / Yonetici giris TC=31885573112 Sifre=201104112
        {
            YoneticiGiris yonetici_201104112 = new YoneticiGiris(); //Yoneti Giris Paneli acmasi icin yeni form olusturdum
            this.Hide();//Ilk sayfanin kapanmasi icin
            yonetici_201104112.ShowDialog();//Yonetici Giris Panali Acmasi icin
            this.Show();//Yonetici panali kapatilinca ilk sayfa acilmasi icin
        }
        
        private void button2_Click(object sender, EventArgs e)//Calisan Girin Butonu
        {
            CalisanGiris calisan_201104112 = new CalisanGiris();//Calisan Giris Panali acmasi icin yeni form olusturdum
            this.Hide();//Ilk sayfanin kapanmasi icin
            calisan_201104112.ShowDialog();//Calisan Giris Panali Acmasi icin
            this.Show();//Calisan panali kapatilinca ilk sayfa acilmasi icin
        }
    }
}
