using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasPertemuan9
{
    public partial class Calculator : Form
    {
        double hasil = 0;
        string operasi = "";
        bool isOperasi = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnangka_Click(object sender, EventArgs e)
        {
            //Mengganti 0 default di txthasil dengan input pertama
            if(txthasil.Text == "0" || isOperasi)
            {
                txthasil.Clear();
            }
            isOperasi = false;
            //Mengambil click dari angka
            Button button = (Button)sender;
            //Validasi desimal
            if(button.Text == ".")
            {
                if (!txthasil.Text.Contains("."))
                {
                    txthasil.Text = txthasil.Text + button.Text;
                }
            }else
            //Menambahkan angka yang di click ke txthasil
            txthasil.Text = txthasil.Text + button.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            //Mengambil operasi dari event click
            Button button = (Button)sender;
            if (hasil != 0)
            {
                btnhasil.PerformClick();
                operasi = button.Text;
                labelProses.Text = hasil + " " + operasi;
                isOperasi = true;
            }
            else
            {
                //Mengisinialisasi variabel operaasi dengan button
                operasi = button.Text;
                hasil = double.Parse(txthasil.Text);
                //Menampilkan proses hitung di label
                labelProses.Text = hasil + " " + operasi;
                isOperasi = true;
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txthasil.Text = "0";
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txthasil.Text = "0";
            hasil = 0;
        }

        private void btnhasil_Click(object sender, EventArgs e)
        {
            switch(operasi)
            {
                case "+":
                    txthasil.Text = (hasil + double.Parse(txthasil.Text)).ToString(); 
                    break;
                case "-":
                    txthasil.Text = (hasil - double.Parse(txthasil.Text)).ToString();
                    break;
                case "x":
                    txthasil.Text = (hasil * double.Parse(txthasil.Text)).ToString();
                    break;
                case "/":
                    txthasil.Text = (hasil / double.Parse(txthasil.Text)).ToString();
                    break;
                default:
                    break;
            }
            hasil = double.Parse(txthasil.Text);
            labelProses.Text = "";
        }

    }
}
