using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAIHS_CS_2_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       private void textBox6_TextChanged(object sender, EventArgs e) // 英吋轉公分
        {
            try // 
            {
                double inch = Convert.ToDouble(textBox6.Text); // 將輸入值資料型態轉成double並存入變數inch
                double cm = inch * 2.54; // 將因吋轉公分(inch*2.54)並存入變數cm
                label8.Text = cm.ToString("f2"); // 顯示公分並四捨五入至小數點後第二位
            }
            catch { // 當錯誤發生時
                label8.Text = "0"; // 將文字顯示0
                textBox6.Clear(); // 將輸入框清空
            }
        }
        private void textBox_TextChanged(object sender, EventArgs e) // 公分轉英吋
        {
            try {
                double cm = Convert.ToDouble(textBox7.Text);
                double inch = cm / 2.54;
                label11.Text = inch.ToString("f2");
            }
            catch
            {
                label11.Text = "0";
                textBox7.Clear();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[] clearBox = { textBox1, textBox2,textBox4,textBox5,textBox6,textBox7 };
            foreach (TextBox i in clearBox)
            {
                i.Clear();
            }
        }
        private void textBox6_Enter(object sender, EventArgs e)
        {
            textBox6.Clear();
        }
        private void textBox7_Enter(object sender, EventArgs e)
        {
            textBox7.Clear();
        }
    }
}
