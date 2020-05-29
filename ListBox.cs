using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_03
{
    class ListBox : Window
    {
        public ListBox(int top, int left, string contents):base(top, left)
        {
            listBoxContents = contents;
        }
        public override void DrawWindow()
        {
            base.DrawWindow();
            Console.WriteLine("Write string to the list:{0}",listBoxContents);
        }
        private string listBoxContents;
    }
}
