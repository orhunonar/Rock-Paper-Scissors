using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taş_Kağıt_Makas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }
        Random rastgele = new Random();
        int toplamben = 0;
        int toplampc = 0;
        private void button1_Click(object sender, EventArgs e)
        {
                   
                      
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int bilgisayar= rastgele.Next(1, 4);
            label1.Text = "Taş";

            if (bilgisayar == 1)
            { label2.Text = "Taş";
                MessageBox.Show("Berabere");
            }
            if (bilgisayar == 2) { label2.Text = "Kağıt";
                MessageBox.Show("Bilgisayar Kazandı");
                toplampc++;
                label7.Text = toplampc.ToString();             
            } if (bilgisayar == 3) { label2.Text = "Makas";
                MessageBox.Show  ("Siz Kazandınız");
                toplamben++;
                label8.Text = toplamben.ToString();
            }
            if (toplamben > 10 && toplamben > toplampc) { MessageBox.Show("Çok Şanslısın ;)");
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }if(toplampc>10 && toplampc > toplamben) { MessageBox.Show("Bir Dahaki Sefere :S");
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int bilgisayar = rastgele.Next(1, 4);
            label1.Text = "Kağıt";

            if (bilgisayar == 1) { label2.Text = "Taş";
                MessageBox.Show("Siz Kazandınız");
                toplamben++;
                label8.Text = toplamben.ToString();
            }
            if (bilgisayar == 2) { label2.Text = "Kağıt";
                MessageBox.Show("Berabere");
            }
            if (bilgisayar == 3) { label2.Text = "Makas";
                MessageBox.Show("Bilgisayar Kazandı");
                toplampc++;
                label7.Text = toplampc.ToString();
            }
            if (toplamben > 10 && toplamben > toplampc) { MessageBox.Show("Çok Şanslısın ;)");
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            if (toplampc > 10 && toplampc > toplamben) { MessageBox.Show("Bir Dahaki Sefere :S");
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int bilgisayar = rastgele.Next(1, 4);
            label1.Text = "Makas";
            if (bilgisayar == 1) { label2.Text = "Taş";
                MessageBox.Show("Bilgisayar Kazandı");
                toplampc++;
                label7.Text = toplampc.ToString();
            }
            if (bilgisayar == 2) { label2.Text = "Kağıt";
                MessageBox.Show("Siz Kazandınz");
                toplamben++;
                label8.Text = toplamben.ToString();
            }
            if (bilgisayar == 3) { label2.Text = "Makas";
                MessageBox.Show("Berabere");
            }
            if (toplamben >10 && toplamben>toplampc) { MessageBox.Show("Çok Şanslısın ;)");
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
            if (toplampc > 10 && toplampc > toplamben) { MessageBox.Show("Bir Dahaki Sefere :S");
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
           
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Orhun Onar :)");
        }
    }
}
