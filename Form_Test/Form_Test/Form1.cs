using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Form_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                    //インスタンス生成
                    testbutton Testbutton = new testbutton(new Point (50*i,50*j),new Size(50,50),"あ");

                    //Click eventにhogehogeClick関数を登録
                    Testbutton.Click += hogehogeClick;

                    //コントロールボタンを追加
                    Controls.Add(Testbutton);
                }
            }

        }
        //自分で作成することも可能
        private void hogehogeClick(object sender, EventArgs e)
        {
            MessageBox.Show("クリック");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("C#の世界へようこそ！");
        }
    }
}
