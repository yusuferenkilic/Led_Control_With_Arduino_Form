using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Arduino_Led_CSHARP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.SelectedItem.ToString();
            serialPort1.Open();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
                comboBox1.Items.Add(port);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("1");
            label2.Text = "Tüm Ledleri Aç";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("0");
            label2.Text = "Tüm Ledleri Kapat";
        }
        private void button15_Click(object sender, EventArgs e)
        {
            serialPort1.Write("!");
            label2.Text = "Mod Bitti";
        }

        //BEYAZ MODLAR
        private void button3_Click(object sender, EventArgs e)
        {
            serialPort1.Write("b");
            label2.Text = "Beyaz Mod 0";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            serialPort1.Write("g");
            label2.Text = "Beyaz Mod 1";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            serialPort1.Write("t");
            label2.Text = "Beyaz Mod 2";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            serialPort1.Write("5");
            label2.Text = "Beyaz Mod 3";
        }

        //KIRMIZI MODLAR
        private void button4_Click(object sender, EventArgs e)
        {
            serialPort1.Write("k");
            label2.Text = "Kırmızı Mod 0";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            serialPort1.Write("i");
            label2.Text = "Kırmızı Mod 1";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            serialPort1.Write("o");
            label2.Text = "Kırmızı Mod 2";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            serialPort1.Write("8");
            label2.Text = "Kırmızı Mod 3";
        }

        //MAVİ MODLAR
        private void button5_Click(object sender, EventArgs e)
        {
            serialPort1.Write("m");
            label2.Text = "Mavi Mod 0";
        }
        private void button12_Click(object sender, EventArgs e)
        {
            serialPort1.Write("j");
            label2.Text = "Mavi Mod 1";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            serialPort1.Write("u");
            label2.Text = "Mavi Mod 2";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            serialPort1.Write("7");
            label2.Text = "Mavi Mod 3";
        }

        //KARIŞIK MODLAR
        private void button16_Click(object sender, EventArgs e)
        {
            serialPort1.Write("q");
            label2.Text = "Mod 0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            serialPort1.Write("a");
            label2.Text = "Mod 1";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            serialPort1.Write("z");
            label2.Text = "Mod 2";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            serialPort1.Write("w");
            label2.Text = "Mod 3";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            serialPort1.Write("s");
            label2.Text = "Mod 4";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            serialPort1.Write("x");
            label2.Text = "Mod 5";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            
        }
    }
}
