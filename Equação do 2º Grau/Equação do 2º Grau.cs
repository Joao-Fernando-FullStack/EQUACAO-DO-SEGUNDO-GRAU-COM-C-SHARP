using System;
using System.Windows.Forms;

namespace Equação_do_2º_Grau
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtB.Focus();
            }
        }

        private void txtB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtC.Focus();
            }
        }

        private void txtC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                equacao();  
            }
        }

        void equacao()
        {
            try
            {
                double a, b, c, resuD, x1, x2;
                a = Convert.ToDouble(txtA.Text);
                b = Convert.ToDouble(txtB.Text);
                c = Convert.ToDouble(txtC.Text);

                resuD = b * b - 4 * a * c;
                if (resuD >= 0)
                {
                    x1 = (-b + Math.Sqrt(resuD)) / (2 * a);
                    x2 = (-b - Math.Sqrt(resuD)) / (2 * a);

                    lbx1.Text = x1.ToString();
                    lbx2.Text = x2.ToString();

                    a1.Text = a.ToString();
                    a2.Text = a.ToString();
                    a3.Text = a.ToString();
                    b1.Text = b.ToString();
                    b2.Text = b.ToString();
                    b3.Text = b.ToString();
                    b4.Text = b.ToString();
                    c1.Text = c.ToString();
                    dilta.Text = resuD.ToString();
                    delta1.Text = resuD.ToString();
                    delta2.Text = resuD.ToString();
                    xx1.Text = x1.ToString();
                    xx2.Text = x2.ToString();
                }
                else
                {
                    MessageBox.Show("A raiz não é posetiva!", resuD.ToString());
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro! Digite Corretamente os Números de cada variavel");
            }
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            equacao();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            a1.Text = "a";
            a2.Text = "a";
            a3.Text = "a";
            b1.Text = "b";
            b2.Text = "b";
            b3.Text = "b";
            b4.Text = "b";
            c1.Text = "c";
            dilta.Text = "valor";
            delta1.Text = "∆";
            delta2.Text = "∆";
            xx1.Text = "valor";
            xx2.Text = "valor";
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = "";
            lbx1.Text = "x1";
            lbx2.Text = "x2";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 5)
            {
                johnSoft4.Visible = false;
                progressBar1.Value++;
            }
            else if (progressBar1.Value < 10)
            {
                johnSoft4.Visible = true;
                progressBar1.Value++;
            }
            else if (progressBar1.Value < 15)
            {
                johnSoft4.Visible = false;
                progressBar1.Value++;
            }
            else if (progressBar1.Value < 20)
            {
                johnSoft4.Visible = true;
                progressBar1.Value++;
            }
            else if (progressBar1.Value < 25)
            {
                johnSoft4.Visible = false;
                progressBar1.Value++;
            }
            else if (progressBar1.Value < 30)
            {
                johnSoft4.Visible = true;
                progressBar1.Value++;
            }
            else if (progressBar1.Value < 35)
            {
                johnSoft4.Visible = false;
                progressBar1.Value++;
            }
            else if (progressBar1.Value < 40)
            {
                johnSoft4.Visible = true;
                progressBar1.Value++;
            }
            else if (progressBar1.Value < 45)
            {
                johnSoft4.Visible = false;
                progressBar1.Value++;
            }
            else if (progressBar1.Value < 50)
            {
                johnSoft4.Visible = true;
                progressBar1.Value++;
            }
            else if (progressBar1.Value < 55)
            {
                johnSoft4.Visible = false;
                progressBar1.Value++;
            }
            else if (progressBar1.Value < 60)
            {
                johnSoft4.Visible = true;
                progressBar1.Value++;
            }
            else if (progressBar1.Value < 65)
            {
                johnSoft4.Visible = false;
                progressBar1.Value++;
            }
            else if (progressBar1.Value < 70)
            {
                johnSoft4.Visible = true;
                progressBar1.Value++;
            }
            else if (progressBar1.Value < 75)
            {
                johnSoft4.Visible = false;
                progressBar1.Value++;
            }
            else if (progressBar1.Value < 80)
            {
                johnSoft4.Visible = true;
                progressBar1.Value++;
            }
            else if (progressBar1.Value < 85)
            {
                johnSoft4.Visible = false;
                progressBar1.Value++;
            }
            else if (progressBar1.Value < 90)
            {
                johnSoft4.Visible = true;
                progressBar1.Value++;
            }
            else if (progressBar1.Value < 95)
            {
                johnSoft4.Visible = false;
                progressBar1.Value++;
            }
            else if (progressBar1.Value < 100)
            {
                johnSoft4.Visible = true;
                progressBar1.Value++;
            }
            else
            {
                timer1.Enabled = false;
                johnSoft4.Visible = true;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
