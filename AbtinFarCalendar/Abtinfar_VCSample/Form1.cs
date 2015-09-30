using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Abtinfar_VCSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AbtinFar1_ArabicDateChanged(string ArabicDate)
        {
            MessageBox.Show(ArabicDate);
        }

        private void AbtinFar1_EnglishDateChanged(string EnglishDate)
        {
            MessageBox.Show(EnglishDate);
        }

        private void AbtinFar1_DateChanged(string FDate)
        {
            MessageBox.Show(FDate);
        }

        private void AbtinFar1_DayEvents(string Events)
        {
            MessageBox.Show(Events);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ComboBox1.SelectedIndex = 0;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            AbtinFar1.TodayDate();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AbtinFar1.SetCalendarStyle(ComboBox1.SelectedItem.ToString());
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            tharf.Text = AbtinFarConvertor1.ConvertDigits(Double.Parse(tadad.Text));
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            txtShamsi01.Text = AbtinFarConvertor1.English2Persian(DateTime.Parse(txtMiladi01.Text));
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            txtMiladi02.Text = AbtinFarConvertor1.Persian2English(txtShamsi02.Text).ToString();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            txtQamari.Text = AbtinFarConvertor1.Persian2Qamari(txtShamsi03.Text);
        }
    }
}
