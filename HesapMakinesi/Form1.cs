using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private String islem;
        private double sayi1, sayi2, toplam,devam=-1;


        private double sonuc(String islem, double sayi1 , double sayi2) {

            double sonuc = 0;
            switch (islem) {
                    case "+":
                         sonuc = sayi1 + sayi2;
                    break;

                    case "-":
                            sonuc=sayi1 - sayi2;
                    break ;

                    case "*":
                        sonuc = sayi1 * sayi2;
                    break; 


                    case "/":
                        sonuc = sayi1 / sayi2;
                    break;

            
            }

            return sonuc;
        }

        private void btnToplama_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                sayi1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                islem = "+";
            }
        }

        private void btnCikarma_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!=""){
                sayi1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                islem = "-";
            }
        }

        private void btnCarpma_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                sayi1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                islem = "*";
            }
        }

        private void btnBolme_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                sayi1 = Convert.ToDouble(textBox1.Text);
                textBox1.Text = "";
                islem = "/";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text !="") {
                sayi2 = Convert.ToDouble(textBox1.Text);
                if (devam == -1)
                {

                    devam = Convert.ToDouble(textBox1.Text);

                }
                toplam = sonuc(islem, sayi1, sayi2);
                textBox1.Text = toplam.ToString();
                sayi1 = devam;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            islem = "";
            sayi1 = 0;
            sayi2 = 0;
            toplam = 0;
            devam = -1;
        }

      
    }
}
