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
        public testbutton(Point position, Size size, string text)
      {
        //ボタンの位置設定
        Location=position;
        //ボタンの大きさ設定
        Size=size;
        //ボタン内のテキスト設定
        Text=text;

        Click+=ClickEvent;
       }

        //自分で作成することも可能

             private void ClickEvent(object sender, EventArgs e)
        {
            MessageBox.Show("Testbutton内で設定");
        }
    }


}

