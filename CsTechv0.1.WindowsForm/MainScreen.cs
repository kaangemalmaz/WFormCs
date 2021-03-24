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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Siz bilgisayarın sayisini bulun ekranına gider.*/
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*Bilgisayar sizin sayısınızı bulsun ekranına gider.*/
            this.Hide();
            Bilgisayar form1 = new Bilgisayar();
            form1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*Programı kapatır.*/
            Application.Exit();
        }
    }
}
