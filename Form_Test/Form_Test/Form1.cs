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

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //インスタンス生成
                    testbutton Testbutton = new testbutton();

                    //ボタンの位置設定
                    Testbutton.Location = new Point(50 * i, 50*j);


                    //ボタンの大きさを設定
                    Testbutton.Size = new Size(200, 100);

                    //ボタン内のテキスト設定
                    Testbutton.Text = "あいうえお";

                    //コントロールボタンを追加
                    Controls.Add(Testbutton);
                }
            }
          
            {

            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("C#の世界へようこそ！");
        }
    }
}
