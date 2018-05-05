using System;
using System.Windows.Forms;

namespace Lab01
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                var σ = double.Parse(tbσ.Text.Replace('.', ','));
                var λ = double.Parse(tbλ.Text.Replace('.', ','));
                var n = int.Parse(tbN.Text);

                var recvRandomizer = new RayleighRandomizer(σ);
                var servRandomizer = new ExpRandomizer(λ);

                var r = new Calculator().Calculate(recvRandomizer, servRandomizer, n);

                lblB0.Text = @"B0 = " + r.Coeffs.Item1;
                lblB1.Text = @"B1 = " + r.Coeffs.Item2;
                lblB2.Text = @"B2 = " + r.Coeffs.Item3;
                lblB3.Text = @"B3 = " + r.Coeffs.Item4;

                lblT1.Text = @"T1 = " + r.Time.Item1;
                lblT2.Text = @"T2 = " + r.Time.Item2;

                lblT.Text = @"T = " + r.RealTime;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Ошибка!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
