using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator_Input : Form
    {
        public delegate void CreateData(int operasi, int a, int b, int hasil);
        public event CreateData Create;

        public Calculator_Input()
        {
            InitializeComponent();
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
            string operasi = cbOperasi.SelectedItem.ToString();
            int a = Convert.ToInt32(txtNilaiA.Text);
            int b = Convert.ToInt32(txtNilaiB.Text);
            int hasil = 0;

            switch (cbOperasi.SelectedIndex)
            {
                case 0:
                    hasil = a + b;
                    break;
                case 1:
                    hasil = a - b;
                    break;
                case 2:
                    hasil = a * b;
                    break;
                case 3:
                    hasil = a / b;
                    break;
                default:
                    hasil = 0;
                    break;
            }
            this.Create(cbOperasi.SelectedIndex, a, b, hasil);
        }
    }
}