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
        //constをつけると初期化時のみ変更が可能になる
        const int BUTTON_SIZE_X = 100;
        const int BUTTON_SIZE_Y = 100;

        const int BOARD_SIZE_X = 3;
        const int BOARD_SIZE_Y = 3;
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < BOARD_SIZE_X; i++)
            {
                for (int j = 0; j < BOARD_SIZE_Y; j++)
                {

                    //インスタンス生成
                    testbutton Testbutton = new testbutton(new Point (BUTTON_SIZE_X * i, BUTTON_SIZE_Y * j),
                                                           new Size(BUTTON_SIZE_X, BUTTON_SIZE_Y),"あ");

                    //コントロールボタンを追加
                    Controls.Add(Testbutton);
                }
            }

        }
       
        
        //自動生成
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("C#の世界へようこそ！");
        }
    }
}
