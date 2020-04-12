using System;
using System.Drawing;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class Clock
    {
        private static short rows;
        private static short columns;
        private static Label[][] labels;
        private static Font font;
        private static Random random;
        private short sequence_counter;
        private short timer_advanced;

        private void initData()
        {
            rows = 3;
            columns = 3;
            labels = new Label[rows][];
            font = new Font("Microsoft Sans Serif", 10);
            random = new Random();
            sequence_counter = 1;
            timer_advanced = 2;
            for (int row = 0; row < rows; row++)
            {
                labels[row] = new Label[columns];
                for (int column = 0; column < columns; column++)
                {
                    labels[row][column] = new Label();
                }
            }
        }
    }
}
