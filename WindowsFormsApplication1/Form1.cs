using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnmvsmkntrl_Click(object sender, EventArgs e)
        {

            switch ((txtGirilenDeger.Text).ToLower())
            {
                case "kış":
                    MessageBox.Show("Aralık - Ocak - Şubat");
                    break;

                case "ilkbahar":
                    MessageBox.Show("Mart - Nisan - Mayıs");
                    break;

                case "yaz":
                    MessageBox.Show("Haziran - Temmuz - Ağustos");
                    break;

                case "sonbahar":
                    MessageBox.Show("Eylül - Ekim - Kasım");
                    break;

                default:
                    MessageBox.Show("Lütfen bir mevsim adı giriniz");
                    break;

            }
        }
    }
}
