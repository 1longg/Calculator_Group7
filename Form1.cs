using System.Data;
using System.Linq;
using System.Linq.Expressions;

namespace TeamWork1_Group7
{
public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void so0_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "0";
        }

        private void so1_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "1";
        }

        private void so2_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "2";
        }

        private void so3_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "3";
        }

        private void so4_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "4";
        }

        private void so5_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "5";
        }

        private void so6_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "6";
        }

        private void so7_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "7";
        }

        private void so8_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "8";
        }

        private void so9_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "9";
        }

        private void chia_nguyen_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "/";
        }

        private void nhan_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "*";
        }

        private void tru_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "-";
        }

        private void cong_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "+";
        }

        private void dau_cham_Click(object sender, EventArgs e)
        {
            txtOutput.Text += ".";
        }

        private void xoa_1_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text.Length > 0)
            {
                txtOutput.Text = txtOutput.Text.Remove(txtOutput.Text.Length - 1);
            }
        }

        private void xoa_all_Click(object sender, EventArgs e)
        {
            txtOutput.Text = string.Empty;
        }

        private void bang_Click(object sender, EventArgs e)
        {
            string chuoi_phep_tinh = txtOutput.Text;

            try
            {
                txtOutput.Text = string.Empty;
                txtOutput.Text = (new DataTable().Compute(chuoi_phep_tinh, null)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Phep tinh loi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /*    private void bang_Click(object sender, EventArgs e)
            {
                string chuoi_phep_tinh = txtOutput.Text;

                string[] phep_tinh = chuoi_phep_tinh.Split(new char[] { '+', '-', '*', '/', '%' });

                double ket_qua = double.Parse(phep_tinh[0]);

                for(int i = 1; i<phep_tinh.Length; i++)
                {
                    double j = double.Parse((phep_tinh[i]));

                    if(chuoi_phep_tinh.Contains('+') && chuoi_phep_tinh.IndexOf('+') == i )
                    {
                        if (chuoi_phep_tinh[i-1] == '+')
                        {
                            ket_qua += j;
                        }else if (chuoi_phep_tinh[i-1] == '-')
                            ket_qua -= j;
                    }
                    else if (chuoi_phep_tinh.Contains('-') && chuoi_phep_tinh.IndexOf('-') == i)
                    {
                        if (chuoi_phep_tinh[i - 1] == '+')
                        {
                            ket_qua += j;
                        }
                        else if (chuoi_phep_tinh[i - 1] == '-')
                            ket_qua -= j;
                    }
                    else if (chuoi_phep_tinh.Contains('') && chuoi_phep_tinh.IndexOf('') == i)
                    {
                        ket_qua *= j;
                    }
                    else if (chuoi_phep_tinh.Contains('/') && chuoi_phep_tinh.IndexOf('/') == i)
                    {
                        if (j != 0)
                            ket_qua /= j;
                        else
                        {
                            MessageBox.Show("Phep tinh loi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else if (chuoi_phep_tinh.Contains('%') && chuoi_phep_tinh.IndexOf('%') == i)
                    {
                        if (j != 0)
                            ket_qua %= j;
                        else
                        {
                            MessageBox.Show("Phep tinh loi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                txtOutput.Text = string.Empty;
                txtOutput.Text = ket_qua.ToString();
            }*/

        private void chia_du_Click(object sender, EventArgs e)
        {
            txtOutput.Text += "%";
        }
    }
}

