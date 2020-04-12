using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DigitalClock
{
    public partial class Clock
    {        
        private void setAll(short ch)
        {            
            for (int row = 0; row < rows; row++)
                for (int column = 0; column < columns; column++)
                    labels[row][column].Text = ch.ToString();
        }        

        private void setState(short [][] state)
        {
            for (int row = 0; row < rows; row++)
                for (int column = 0; column < columns; column++)
                    labels[row][column].Text = state[row][column].ToString();
        }

        private Color getRandomColor()
        {
            return Color.FromArgb(random.Next(0x1000000) & 0x7F7F7F);
        }

        private void randomizeColor()
        {
            for (int row = 0; row < rows; row++)
                for (int column = 0; column < columns; column++)
                    labels[row][column].ForeColor = getRandomColor();
        }

        private void clock_anim_Tick(object sender, EventArgs e)
        {
            setAll(sequence_counter++);
            randomizeColor();
            if (sequence_counter > 10)
            {
                initDesign();
                clock_tick();
                clock_anim.Enabled = false;
                clock_logic.Enabled = true;
            }
        }

        private short[] val_div(short value, int size)
        {            
            short val = value;
            short[] arr = new short[size];
            for (int i = 0; i < size; i++)
            {
                if (i == size - 1)
                {
                    arr[i] = val;
                }
                else
                {
                    arr[i] = (short)random.Next(0, val);
                    val -= arr[i];
                }
            }
            return arr;
        }

        private Point getNext(Point curr)
        {
            Point p = new Point();
            p.X = (curr.X + 1) % columns;
            if(p.X == 0)
                p.Y = (curr.Y + 1) % rows;
            else
                p.Y = curr.Y;
            return p;
        }

        private void clock_tick()
        {
            short[][] tick = new short[rows][];
            for (short i = 0; i < rows; i++)
                tick[i] = new short[columns];

            Point start = new Point(0, 0);
            start.Y = (short)random.Next(0, rows);
            start.X = (short)random.Next(0, columns);

            Point next;
            short[] values;
            DateTime dt = DateTime.Now.AddSeconds(timer_advanced);

            tick[start.Y][start.X] = (short)random.Next(-10, 0);
            
            next = getNext(start);
            values = val_div((short)dt.Hour, columns - 1);
            //setting h
            for (int i = 0; i < columns - 1; i++)
            {
                tick[next.Y][next.X] = values[i];
                next = getNext(next);
            }
            
            values = val_div((short)dt.Minute, columns);
            //setting m
            for (int i = 0; i < columns; i++)
            {
                tick[next.Y][next.X] = values[i];
                next = getNext(next);
            }
            
            values = val_div((short)dt.Second, columns);
            //setting s
            for (int i = 0; i < columns; i++)
            {
                tick[next.Y][next.X] = values[i];
                next = getNext(next);
            }

            if(textClockToolStripMenuItem.Checked)
                top_clock_display.Text = dt.Hour + ":" + dt.Minute + ":" + dt.Second;

            setState(tick);
            randomizeColor();
        }

        private void clock_logic_Tick(object sender, EventArgs e)
        {
            clock_tick();
        }

        private void initLogic()
        {
            clock_anim.Enabled = true;
        }

    }
}
