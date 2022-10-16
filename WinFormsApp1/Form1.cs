using System.Net;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckIP(object sender, EventArgs e)
        {
            string ip1 = ipa1.Text;
            string ip2 = ipa2.Text;
            string ip3 = ipa3.Text;
            string ip4 = ipa4.Text;


            int niki = int.Parse(ip1);
            int niki2 = int.Parse(ip2);
            int niki3 = int.Parse(ip3);
            int niki4 = int.Parse(ip4);



            if (niki < 0 || niki > 255)
            {
                textBox1.Text = "Nie";
            }

            else if (niki2 < 0 || niki2 > 255)
            {
                textBox1.Text = "Nie";
            }
            else if (niki3 < 0 || niki3 > 255)
            {
                textBox1.Text = "Nie";
            }
            else if (niki4 < 0 || niki4 > 255)
            {
                textBox1.Text = "Nie";
            }
            else { textBox1.Text = "Tak"; }

        }

        private void CheckClass_Click(object sender, EventArgs e)
        {
            string maska1 = mask1.Text;
            string maska2 = mask2.Text;
            string maska3 = mask3.Text;


            int honey = int.Parse(maska1);
            int honey2 = int.Parse(maska2);
            int honey3 = int.Parse(maska3);



            if (honey < 0 || honey > 255)
            {
                textBox2.Text = "A";
            }

            else if ((honey < 0 || honey > 255) && (honey2 < 0 || honey2 > 255))
            {
                textBox2.Text = "B";
            }
            else if ((honey < 0 || honey > 255) && (honey2 < 0 || honey2 > 255) && (honey3 < 0 || honey3 > 255))
            {
                textBox2.Text = "C";
            }
            else
            {
                textBox2.Text = "nie podano maski";
            }
            
        }
    }
}
