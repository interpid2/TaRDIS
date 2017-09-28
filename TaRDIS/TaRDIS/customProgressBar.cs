using System;
using System.Drawing;
using System.Windows.Forms;

namespace TaRDIS
{
    public enum ProgressBarDisplayText
    {
        Percentage,
        CustomText
    }
    class customProgressBar : ProgressBar
    {
        public ProgressBarDisplayText DisplayStyle { get; set; }

        //Property to hold the custom text
        public String CustomText { get; set; }

        Label customText = new Label();

        public customProgressBar()
        {
            // Modify the ControlStyles flags
            //http://msdn.microsoft.com/en-us/library/system.windows.forms.controlstyles.aspx
            customText.BackColor = Color.Transparent;
            customText.ForeColor = Color.Black;
            customText.Font = new Font (FontFamily.GenericSansSerif,10);
            this.Controls.Add(customText);
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rect = ClientRectangle;
            Graphics g = e.Graphics;
            string text = DisplayStyle == ProgressBarDisplayText.Percentage ? Value.ToString() + '%' : CustomText;
            int numFromText = Convert.ToInt32(CustomText);
            ProgressBarRenderer.DrawHorizontalBar(g, rect);
            rect.Inflate(-3, -3);
            if (numFromText > 0)
            {
                var temp = Brushes.Green;
                if (numFromText >= 70 && numFromText < 90) temp = Brushes.Orange;
                else if (numFromText >= 90) temp = Brushes.Red;
                // As we doing this ourselves we need to draw the chunks on the progress bar
                Rectangle clip = new Rectangle(rect.X, rect.Y, (int)Math.Round(((float)Value / Maximum) * rect.Width), rect.Height);
                ProgressBarRenderer.DrawHorizontalBar(g, clip);
                e.Graphics.FillRectangle(temp, clip);
            }

            SizeF len = g.MeasureString(text, new Font(FontFamily.GenericSansSerif,10));
            customText.Location= new Point(Convert.ToInt32((Width / 2) - len.Width / 2), Convert.ToInt32((Height / 2) - len.Height / 2));
            customText.Text = text+"%";
        }
    }
}
