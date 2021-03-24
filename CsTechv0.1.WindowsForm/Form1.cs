using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsTechv0._1.WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        int rastgeleSayi = 0;
        int artisonuc = 0;
        int eksisonuc = 0;
        int denemeSayisi = 1;

        private void button1_Click(object sender, EventArgs e)
        {
            /*4 rakam dışında bir sayi girilmesi durumunda hata verilir. */
            if (txtSayi.Text.ToString().Length != 4)
            {
                MesajYazdır("4 rakamlı bir sayi girilmesi gerekmektedir.");
            }
            else
            {
                /*initilize yapılır.*/
                artisonuc = 0;
                eksisonuc = 0;

                /*bilgisayarın verdiği sayi ile girilen sayi karşılaştırılır.*/
                if (rastgeleSayi == Convert.ToInt32(txtSayi.Text))
                {
                    /*doğru ise mesaj verilerek bu mesaja göre eğer yeniden oynamak isterlerse yeniden form yüklenir.*/
                    DialogResult result = MessageBox.Show("Tebrikler sayiyi doğru tahmin ettiniz. Yeniden oynamak ister misiniz ?", "Bildirim", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        Form1_Load(sender, e);
                    }
                }
                else
                {
                    /*farklı ise sayi basamaklarına bölünerek basamakların kaçının doğru olup olmadığına bakılır.*/
                    basamaklaraAyir(rastgeleSayi, Convert.ToInt32(txtSayi.Text));
                    denemeSayisi += 1;
                    txtDenemeSayisi.Text = denemeSayisi.ToString();
                }
            }

        }

        public void basamaklaraAyir(int sayi, int sayi2)
        {
            /*sayi uzunluğu alınır.*/
            var sayiUzunluk = sayi.ToString().Length;

            /*doğru basamak ve yanlış basamak sayisi bulunur.*/
            for (int i = 0; i < sayiUzunluk; i++)
            {
                if (sayi % 10 == sayi2 % 10)
                {
                    artisonuc += 1;
                }
                else
                {
                    eksisonuc += 1;
                }

                sayi = sayi / 10;
                sayi2 = sayi2 / 10;
            }

            /*aşağıya yazdırılır.*/
            txtDgrSayi.Text = artisonuc.ToString();
            txtYnlsSayi.Text = eksisonuc.ToString();

            //int birlerBasamagi = sayi % 10;
            //if (sayi % 10 == sayi2 % 10)
            //{
            //    artisonuc += 1;
            //}
            //else
            //{

            //}
            //sayi % 10 = sayi % 10;
            //sayi = sayi / 10;

            //int onlarBasamagi = sayi % 10;
            //sayi = sayi / 10;

            //int yüzlerBasamagi = sayi % 10;
            //sayi = sayi / 10;

            //int binlerBasamagi = sayi % 10;
        }


        public void basamaklaraAyir2(object sender, EventArgs e, int sayi)
        {
            /*Sayi basamakları tek tek bulunarak birbirinden farklı 4 rakamlı bir sayi elde edilir.*/
            int birlerBasamagi = sayi % 10;
            sayi = sayi / 10;

            int onlarBasamagi = sayi % 10;
            sayi = sayi / 10;

            int yüzlerBasamagi = sayi % 10;
            sayi = sayi / 10;

            int binlerBasamagi = sayi % 10;

            if (birlerBasamagi == onlarBasamagi || birlerBasamagi == yüzlerBasamagi || birlerBasamagi == binlerBasamagi || onlarBasamagi == yüzlerBasamagi || onlarBasamagi == binlerBasamagi || yüzlerBasamagi == binlerBasamagi)
            {
                rastgeleSayi = 0;
                Form1_Load(sender, e);
            }
            else
            {

            }
        }

        public void MesajYazdır(string message)
        {
            /*mesaj ile verilmek istenen şeyler yazılır.*/
            MessageBox.Show(message);
        }


        public void Form1_Load(object sender, EventArgs e)
        {
            /*initialize*/
            txtDgrSayi.Text = 0.ToString();
            txtYnlsSayi.Text = 0.ToString();
            txtSayi.Text = 0.ToString();
            txtDenemeSayisi.Text = 1.ToString();

            /*eğer bir sayi üretildi ve 4 rakam birbirinden farklı ise buraya girmemsi için*/
            if (rastgeleSayi != 0)
            {

            }
            else
            {
                /*rastgele sayi = 0 veya birbirinden farklı değilse 4 rakam yeniden rakam üretilir.*/
                Random rnd = new Random();
                /* 4 haneli bir rakam oluşturmasını sağlar bilgisayarın. */
                rastgeleSayi = rnd.Next(1000, 9999);
                /* Rakamları birbirinden farklı bir sayi oluşturmanızı sağlar. */
                basamaklaraAyir2(sender, e, rastgeleSayi);
            }

        }

        private void txtSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*inputa textboxa sadece sayi girilmesi sağlanır.*/
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*ana menüye girişi sağlar.*/
            this.Hide();
            MainScreen main = new MainScreen();
            main.ShowDialog();
        }
    }
}
