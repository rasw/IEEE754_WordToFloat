using System;
using System.Windows.Forms;

namespace WordToFloat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int keyPressCount = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string highWord = txtWordHigh.Text.Trim();
            string lowWord = txtWordLow.Text.Trim();

            var i = Convert.ToInt32(highWord + lowWord, fromBase: 16);
            //var i = int.Parse(highWord + lowWord, NumberStyles.AllowHexSpecifier);  // this also works
            var bytes = BitConverter.GetBytes(i);
            var single = BitConverter.ToSingle(bytes, 0);   // 15.8446
            txtFloatValue.Text = single.ToString();

        }

        private void txtWordHigh_KeyUp(object sender, KeyEventArgs e)
        {
            if (++keyPressCount > 3)
            {
                txtWordLow.Focus();
                keyPressCount = 0;
            }
        }
    }
}
