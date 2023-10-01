namespace Assignment_SifreKontrolu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string girilenSifre = string.Empty;
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            girilenSifre = txtSifre.Text;

            if (girilenSifre.Length > 6)
            {
                lblDerece.Text = "Orta";
                lblDerece.ForeColor = Color.Blue;

                bool ozelKarakterVarMi = false;

                foreach (char karakter in girilenSifre)
                {
                    if (!char.IsLetterOrDigit(karakter) && !char.IsWhiteSpace(karakter))
                    {
                        ozelKarakterVarMi = true; 
                    }
                }

                if (girilenSifre.Any(char.IsDigit) && ozelKarakterVarMi == true)
                {
                    lblDerece.Text = "Yüksek";
                    lblDerece.ForeColor = Color.Green;
                }

            }
            else
            {
                lblDerece.Text = "Düþük";
                lblDerece.ForeColor = Color.Red;
            }
        }
    }
}
    
