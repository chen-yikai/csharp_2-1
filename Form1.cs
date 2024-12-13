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
            try // 嘗試執行以下程式碼
            {
                double inch = Convert.ToDouble(textBox6.Text); // 將輸入值資料型態轉成double並存入變數inch
                double cm = inch * 2.54; // 將因吋轉公分(inch*2.54)並存入變數cm
                label8.Text = cm.ToString("f2"); // 顯示公分並四捨五入至小數點後第二位
            }
            catch
            { // 當上方錯誤發生時
                label8.Text = "0"; // 將文字顯示0
                textBox6.Clear(); // 將輸入框清空
            }
        }
        private void textBox_TextChanged(object sender, EventArgs e) // 公分轉英吋
        {
            try
            {
                double cm = Convert.ToDouble(textBox7.Text); // 將輸入值資料型態轉成double並存入變數cm
                double inch = cm / 2.54; // 將公分轉英吋(cm/2.54)並存入變數inch
                label11.Text = inch.ToString("f2"); // 顯示英吋並四捨五入至小數點後第二位
            }
            catch
            {
                label11.Text = "0"; // 將文字顯示0
                textBox7.Clear(); // 將輸入框清空
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[] clearBox = { textBox1, textBox2, textBox4, textBox5, textBox6, textBox7 }; // 將所有輸入框存入陣列
            foreach (TextBox i in clearBox) // 將陣列中的每個輸入框清空
            {
                i.Clear();
            }
        }
        // 當輸入框被選取時清空
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
