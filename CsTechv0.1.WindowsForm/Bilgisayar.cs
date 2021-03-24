using System;
using System.Windows.Forms;

namespace CsTechv0._1.WindowsForm
{
    public partial class Bilgisayar : Form
    {
        public Bilgisayar()
        {
            InitializeComponent();
        }


        int sayi = 0;
        int denemeSayisi = 1;
        int binlerBasamagi = 0;
        int yüzlerBasamagi = 0;
        int onlarBasamagi = 0;
        int birlerBasamagi = 0;

        public void Bilgisayar_Load(object sender, EventArgs e)
        {
            /*değerler set edilir.*/
            sayi = 1000;
            txtBilgisayarSayiTahmin.Text = sayi.ToString();
            txtDgrSayi.Text = 0.ToString();
            txtYnlsSayi.Text = 4.ToString();
            txtDenemeSayisi.Text = 1.ToString();
            btneksi.Visible = false;

        }

        public void btnynls_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtDgrSayi.Text) + Convert.ToInt32(txtYnlsSayi.Text) != 4)
            {
                MessageBox.Show("Doğru basamak sayısı ve yanlış basamak sayısının toplamı 4 olmalıdır.");
            }
            else
            {

                if (Convert.ToInt32(txtDgrSayi.Text) == 0)
                {
                    /*eğer önceki bulunan sayılardan biriyle aynı ise girilecek sayının rakamları farklı olacağı için farklı rakamda farklı artış sağlanır.*/
                    binlerBasamagi = kontroller(1000, binlerBasamagi);
                }

                else if (Convert.ToInt32(txtDgrSayi.Text) == 1)
                {
                    /*eğer önceki bulunan sayılardan biriyle aynı ise girilecek sayının rakamları farklı olacağı için farklı rakamda farklı artış sağlanır.*/
                    yüzlerBasamagi = kontroller(100, yüzlerBasamagi);
                }

                else if (Convert.ToInt32(txtDgrSayi.Text) == 2)
                {
                    /*eğer önceki bulunan sayılardan biriyle aynı ise girilecek sayının rakamları farklı olacağı için farklı rakamda farklı artış sağlanır.*/
                    onlarBasamagi = kontroller(10, onlarBasamagi);
                }

                else if (Convert.ToInt32(txtDgrSayi.Text) == 3)
                {
                    /*eğer önceki bulunan sayılardan biriyle aynı ise girilecek sayının rakamları farklı olacağı için farklı rakamda farklı artış sağlanır.*/
                    birlerBasamagi = kontroller(1, birlerBasamagi);
                }

            }

            /*basamaklar birleştirilerek ekrana yazdırılır.*/
            sayi = Convert.ToInt32(Convert.ToString(binlerBasamagi) + Convert.ToString(yüzlerBasamagi) + Convert.ToString(onlarBasamagi) + Convert.ToString(birlerBasamagi));

            /*sayi ekrana yazdırılır.*/
            txtBilgisayarSayiTahmin.Text = sayi.ToString();


            denemeSayisi += 1;
            txtDenemeSayisi.Text = denemeSayisi.ToString();
        }


        public int kontroller(int dgsksayi, int basamak)
        {

            /*eğer eşitlik yoksa sayı basamak değeri kadar artacaktır.*/
            if (basamak != birlerBasamagi || basamak != onlarBasamagi || basamak != yüzlerBasamagi || basamak != binlerBasamagi)
            {
                sayi += dgsksayi;
                basamak = (sayi / dgsksayi) % 10;
                if (basamak == 10)
                {
                    basamak = 0;
                }
            }

            /*esitlik olduğu sürece sürekli artmaya devam edecektir.*/
            while (basamak == birlerBasamagi || basamak == onlarBasamagi || basamak == yüzlerBasamagi || basamak == binlerBasamagi)
            {
                sayi += dgsksayi;
                basamak = (sayi / dgsksayi) % 10;
                if (basamak == 10)
                {
                    basamak = 0;
                }
            }


            return basamak;

        }

        private void btndogru_Click(object sender, EventArgs e)
        {
            /*doğru seçeneği seçilince ekranda bir mesaj verilir ve yeniden oynamak isterse ekran temizlenir.*/
            DialogResult result = MessageBox.Show("Oyun bitti. Yeniden oynamak ister misiniz ? ", "Bildirim", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                Bilgisayar_Load(sender, e);
            }
        }

        private void txtDgrSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*textboxda sadece sayi girmesi sağlanır.*/
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtYnlsSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*textboxda sadece sayi girmesi sağlanır.*/
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtBilgisayarSayiTahmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*textboxda sadece sayi girmesi sağlanır.*/
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*cikis islemi yapılır.*/
            this.Hide();
            MainScreen main = new MainScreen();
            main.ShowDialog();
        }

        private void txtDgrSayi_TextChanged(object sender, EventArgs e)
        {
            /*0-4 arası bir sayi girmesi sağlanır.*/
            if (System.Text.RegularExpressions.Regex.IsMatch(txtDgrSayi.Text, "[0-4]"))
            {
                ///*yanlış basamak sayisi otomatik yazdırılır.*/
                txtYnlsSayi.Text = (4 - Convert.ToInt32(txtDgrSayi.Text)).ToString();
            }
            else
            {
                MessageBox.Show("1,2,3,4 rakamlarını girebilirsiniz..");
                txtDgrSayi.Text = 0.ToString();
                txtYnlsSayi.Text = 0.ToString();
            }
        }

        private void btnarti_Click(object sender, EventArgs e)
        {
            /*doğru sayısını arttıran butondur.*/
            txtDgrSayi.Text = (Convert.ToInt32(txtDgrSayi.Text) + 1).ToString();
            if (txtDgrSayi.Text == 3.ToString())
            {
                btnarti.Visible = false;
            }
            btneksi.Visible = true;
        }

        private void btneksi_Click(object sender, EventArgs e)
        {
            /*doğru sayısını azaltan butondur.*/
            txtDgrSayi.Text = (Convert.ToInt32(txtDgrSayi.Text) - 1).ToString();
            if (txtDgrSayi.Text == 0.ToString())
            {
                btneksi.Visible = false;
            }
            btnarti.Visible = true;

        }
    }
}