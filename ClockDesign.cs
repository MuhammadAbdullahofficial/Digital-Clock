using System.Drawing;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class Clock
    {
        private void initDesign()
        {
            Point loc = new Point(0, 0);
            Size size = new Size(panel_base.Width / columns, panel_base.Height / rows);
            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    //labels[row][column].Text = c.ToString();
                    labels[row][column].Location = new Point(loc.X, loc.Y);
                    labels[row][column].AutoSize = false;
                    labels[row][column].TextAlign = ContentAlignment.MiddleCenter;
                    labels[row][column].Font = font;
                    labels[row][column].Size = size;
                    panel_base.Controls.Add(labels[row][column]);
                    loc.X += size.Width;
                }
                loc.X = 0;
                loc.Y += size.Height;
            }
        }

    }
}
