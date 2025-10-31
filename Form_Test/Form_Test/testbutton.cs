using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Test
{
    internal class testbutton : Button
    {
        //ボタンの色設定
        private Color _onColor=Color.LightBlue;//ONの時の色
        private Color _offColor = Color.DarkBlue;//OFFの時の色

        private bool _enable;
        public void SetEnable(bool on)
        {
            _enable= on;
            if (on)
            {
                BackColor = _onColor;
            }
            else
            {
                BackColor= _offColor;
            }
                
        }


        public testbutton(Point position, Size size, string text)
      {
        //ボタンの位置設定
        Location=position;
        //ボタンの大きさ設定
        Size=size;
        //ボタン内のテキスト設定
        Text=text;

        SetEnable(false);

        Click+=ClickEvent;
       }

        //自分で作成することも可能

             private void ClickEvent(object sender, EventArgs e)
        {
            SetEnable(!_enable);//クリックしたら切り替わるようになる
        }
    }
}

