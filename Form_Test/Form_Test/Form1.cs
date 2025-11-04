using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Form_Test
{
    public partial class Form1 : Form
    {
        //constをつけると初期化時のみ変更が可能になる
        const int BUTTON_SIZE_X = 100;//ボタンの横
        const int BUTTON_SIZE_Y = 100;//ボタンの縦

        const int BOARD_SIZE_X = 3;//ボタンが横に何個並ぶか
        const int BOARD_SIZE_Y = 3;//ボタンが縦に何個並ぶか

        //testbuttonの二次元配列
        private testbutton[,] _buttonArray;

        public Form1()
        {
            InitializeComponent();

            //_buttonArrayの初期化
            _buttonArray = new testbutton[BOARD_SIZE_Y, BOARD_SIZE_X];

            for (int i = 0; i < BOARD_SIZE_X; i++)
            {
                for (int j = 0; j < BOARD_SIZE_Y; j++)
                {
                    //インスタンス生成
                    testbutton Testbutton =
                        new testbutton(
                            this,
                            i,j,
                            new Size(BUTTON_SIZE_X, BUTTON_SIZE_Y),
                              "");

                    //配列にボタンの参照を追加
                    _buttonArray[j, i] = Testbutton;

                    //コントロールボタンを追加
                    Controls.Add(Testbutton);
                }
            }

            _buttonArray[1, 0].SetEnable(true);
        }
            public testbutton GetTestButton(int x, int y)
        
            
            {
                //配列外参照対策
                if (x < 0 || x >= BOARD_SIZE_X) return null;
                if (y < 0 || y >= BOARD_SIZE_Y) return null;
           
                return _buttonArray[y, x];
            }
      
        
        //自動生成
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("クリック");
        }
    }
}
