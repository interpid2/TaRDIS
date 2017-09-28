using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace tardis
{
    public class RTBExtend
    {
        RichTextBox box;
        public void AppendText(string text, Color color)
        {
            int start = box.TextLength;
            box.AppendText(text+"\n");
            int end = box.TextLength;

            // Textbox may transform chars, so (end-start) != text.Length
            box.Select(start, end - start);
            {
                box.SelectionColor = color;
                // could set box.SelectionBackColor, box.SelectionFont too.
            }
            box.SelectionLength = 0; // clear
        }

        public RTBExtend(RichTextBox bx)
        {
            box = bx;
        }
    }
}
