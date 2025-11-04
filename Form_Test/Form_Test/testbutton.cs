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
            SetEnable(!_enable);
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
        }
        private int[][] _toggleData =
        {
            new int[]{0,0},
            new int[]{1, 0 },
            new int[]{-1, 0},
            new int[]{0, 1},
            new int[]{0, -1},
        };
    }
}

