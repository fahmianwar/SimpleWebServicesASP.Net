using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operator_Aritmatika
{

    public partial class Form1 : Form
    {
        layananOperator.aritmatika myService;
        
        int tambah;
        float kurang;
        float bagi;
        float kali;
        public Form1()
        {
            InitializeComponent();
        }

        private void Tombol_Tambah_Click(object sender, EventArgs e)
        {
            tambah = myService.Penjumlahan(int.Parse(Kotak_Nilai_A.Text), int.Parse(Kotak_Nilai_B.Text));
            Kotak_Hasil.Text = tambah.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myService = new layananOperator.aritmatika();
        }

        private void Tombol_Kurang_Click(object sender, EventArgs e)
        {
            kurang = myService.Pengurangan(float.Parse(Kotak_Nilai_A.Text), float.Parse(Kotak_Nilai_B.Text));
            Kotak_Hasil.Text = kurang.ToString();
        }

        private void Tombol_Kali_Click(object sender, EventArgs e)
        {
            kali = myService.Perkalian(float.Parse(Kotak_Nilai_A.Text), float.Parse(Kotak_Nilai_B.Text));
            Kotak_Hasil.Text = kali.ToString();
        }

        private void Tombol_Bagi_Click(object sender, EventArgs e)
        {
            bagi = myService.Pembagian(float.Parse(Kotak_Nilai_A.Text), float.Parse(Kotak_Nilai_B.Text));
            Kotak_Hasil.Text = bagi.ToString();
        }
    }
}
