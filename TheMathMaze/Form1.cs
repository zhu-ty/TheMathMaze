﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheMathMaze
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            DateTime t1 = DateTime.Now;
            string ans = MazeConsoleMain.get_result(textBox1.Text);
            int milisec = (int)DateTime.Now.Subtract(t1).TotalMilliseconds;
            int ans_num = ans.Split(new char[1] { '\r' }).Length - 1;

            textBox2.Text = "找到" + ans_num.ToString() + "个解\r\n" + "消耗时间：" + milisec.ToString() + "毫秒\r\n" + ans;
        }
    }
}
