namespace bankacilik2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string isim;
        string soyisim;
        int tc;
        double hesapMiktari;

        KisiselBilgiler kb = new KisiselBilgiler();
        HesapBilgileri hb = new HesapBilgileri();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                isim = txtAd.Text;
                soyisim = txtSoyad.Text;
                tc = Convert.ToInt32(txtTCNo.Text);
                hesapMiktari = Convert.ToDouble(lblHesapMiktari.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (isim == kb.Ad && soyisim == kb.Soyad && tc == kb.Id)
            {
                MessageBox.Show("Kullanýcý bilgileri doðru.");
                kb.Bilgiler = true;
                lblHesapMiktari.Text = hb.HesapToplami.ToString();
            }

            else
            {
                MessageBox.Show("Kullanýcý bilgileri yanlýþ. ");
                kb.Bilgiler = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (kb.Bilgiler == true)
            {
                double paraGonder = Convert.ToDouble(txtParaMiktari.Text);

                if (paraGonder <= hb.HesapToplami)
                {
                    hb.HesapToplami -= paraGonder;
                    lblHesapMiktari.Text = hb.HesapToplami.ToString();
                    MessageBox.Show(paraGonder + " TL para gonderildi.");
                }
                else MessageBox.Show("yetersiz bakiye");
            }
            else MessageBox.Show("lutfen kullanýcý bilgilerini giriniz.");
        }

        
    }
}
