namespace matematik_işlemleri_1575
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sayi1 , sayi2, sonuc =0;
            sayi1= Convert.ToInt32(txtSayi1.Text);
            sayi2 = Convert.ToInt32(txtSayi2.Text);
            sonuc = 2 * (sayi1 + sayi2) + 5;
            MessageBox.Show("sonuç:" + sonuc);




        }
    }
}