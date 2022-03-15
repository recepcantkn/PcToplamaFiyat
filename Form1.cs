using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PcToplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            decimal tabanFiyat = 500;
            decimal cpuFiyat = 0;
            if (rbCpuI7.Checked)
                cpuFiyat = 6000;
            else if (rbCpuI5.Checked)
                cpuFiyat = 4000;
            else if (rbCpuI3.Checked)
                cpuFiyat = 2500;
            else if (rbCpuR5.Checked)
                cpuFiyat = 3500;
            else if (rbCpuR3.Checked)
                cpuFiyat = 2500;
            tabanFiyat += cpuFiyat;

            decimal ramFiyat = 0;
             if (rbRam16.Checked)
            ramFiyat = 1400;
            else if (rbRam8.Checked)
            ramFiyat = 600;
            else if (rbRam4.Checked)
            ramFiyat = 350;
            tabanFiyat += ramFiyat;

            decimal hddFiyat = 0;
            if (rbHdd1000.Checked)
                hddFiyat = 800;
            else if (rbHdd500.Checked)
                hddFiyat = 350;
            else if (rbHdd320.Checked)
                hddFiyat = 150;
            tabanFiyat += hddFiyat;

            decimal ekDonanimFiyat = 0;
            if (cbDvd.Checked)
                ekDonanimFiyat = 400;
            else if (cbWebCam.Checked)
                ekDonanimFiyat = 1500;
            else if (cbWifi.Checked)
                ekDonanimFiyat = 200;
            tabanFiyat += ekDonanimFiyat;

            MessageBox.Show(string.Format("Toplam Fiyat ={0:C}", tabanFiyat));

            
        }
    }
}
