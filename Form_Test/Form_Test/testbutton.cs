using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Test
{
    public class testbutton : Button
    {
        //ボタンの色設定
        private Color _onColor = Color.LightBlue;//ONの時の色

        private Color _offColor = Color.DarkBlue;//OFFの時の色

        private bool _enable;

        private Form1 _form1;

        private int _x;

        private int _y;

        public static Random _random = new Random();//これで乱数生成
        public testbutton(Form1 form1, int x, int y, Size size, string text)
        {

            _form1 = form1;

            _x = x;

            _y = y;
            //ボタンの位置設定
            Location = new Point(x * size.Width, y * size.Height);
            //ボタンの大きさ設定
            Size = size;
            //ボタン内のテキスト設定
            Text = text;

            SetEnable(false);

            Click += ClickEvent;
        }
        public void SetEnable(bool on)
        {
            _enable = on;
            if (on)
            {
                BackColor = _onColor;
            }
            else
            {
                BackColor = _offColor;
            }
           
        }

        public void Toggle()
        {
            SetEnable(!_enable);//ON OFF反転
        }

        private void ClickEvent(object sender, EventArgs e)
        {
            ////楽な書き方
            //_form1.GetTestButton(_x, _y)?.Toggle();//?はnull安全
            //_form1.GetTestButton(_x + 1, _y)?.Toggle();
            //_form1.GetTestButton(_x - 1, _y)?.Toggle();
            //_form1.GetTestButton(_x, _y + 1)?.Toggle();
            //_form1.GetTestButton(_x, _y - 1)?.Toggle();

            //かっこいい書き方
            for (int i = 0; i < _toggleData.Length; i++)
            {
                var data = _toggleData[i];
                var button = _form1.GetTestButton(_x + data[0], _y + data[1]);

                if (button != null)
                {
                    button.Toggle();

                }
           
            }

            if (IsAllSame())
            {
                MessageBox.Show("クリアしました！");
            }
        }
        //全部同じ色か判定
        private bool IsAllSame()
        {
            bool first = _form1.GetTestButton(0, 0)._enable;//左上のボタンがONかOFFか記録

            for (int y = 0; y < 3; y++) //3*3のすべてのボタンを確認
            {
                for (int x = 0; x < 3; x++)
                {
                    if (_form1.GetTestButton(x, y)._enable != first)
                        return false;//クリアしてないならfalseを返す
                }
            }
            return true;//全部同じならクリアでtrueを返す
        }


        private int[][] _toggleData =//どのボタンを反転するか
        {
            new int[]{0,0},
            new int[]{1, 0 },
            new int[]{-1, 0},
            new int[]{0, 1},
            new int[]{0, -1},
        };
        public static void RandomizeBoard(Form1 form, int width, int height, int moves = 5)//ランダムにボタンを5回押した状態から
        {
            //全てOFFに
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    form.GetTestButton(x, y).SetEnable(false);
                }
            }

            // 何回かクリックしたことにする
            for (int i = 0; i < moves; i++)
            {
                int randomx = _random.Next(width);//Nextでランダムな位置を選ぶ
                int randomy = _random.Next(height);
                testbutton button = form.GetTestButton(randomx, randomy);
                if (button != null)
                {
                    // 押した時と同じ処理
                    foreach (var data in button._toggleData)
                    {
                        testbutton button2 = form.GetTestButton(randomx + data[0], randomy + data[1]);
                        button2?.Toggle();
                    }
                }

            }
        }




    }
}

