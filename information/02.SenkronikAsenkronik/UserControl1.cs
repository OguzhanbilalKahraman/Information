using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace _02.SenkronikAsenkronik
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {

            Topla(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
        }

        private async void btnCarp_Click(object sender, EventArgs e)
        {
           await CarpAsyc(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            MessageBox.Show("İşlem Tamamlandı.");

        }

        private void Carp(int sayi1, int sayi2)
        {
            int carpim = sayi1 * sayi2;
            Thread.Sleep(5000);
            MessageBox.Show($"Carpim: {carpim}");

        }

        private void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            MessageBox.Show($"Toplam: {toplam}");
        }

        private Task CarpAsyc(int sayi1, int sayi2)
        {
            return Task.Run(()=>{

                Thread.Sleep(5000);
                MessageBox.Show($"Carpim: {sayi1*sayi2}");
            });
        }
    }
}
