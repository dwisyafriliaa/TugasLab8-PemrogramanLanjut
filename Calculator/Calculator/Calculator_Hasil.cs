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
    public partial class Calculator_Hasil : Form
    {
        public Calculator_Hasil()
        {
            InitializeComponent();
        }

        private void Output(int operasi, int a, int b, int hasil)
        {
            char[] operasi_simbol = { '+', '-', '*', '/' };
            string[] operasi_str = { "Penambahan", "Pengurangan", "Perkalian", "Pembagian" };
            lstHasil.Items.Add($"Hasil {(operasi_str[operasi]).ToLower()} {a} {operasi_simbol[operasi]} {b} = {hasil}");
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            Calculator_Input cal = new Calculator_Input();
            cal.Create += Output;
            cal.ShowDialog();
        }
    }
}