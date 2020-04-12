namespace DigitalClock
{
    partial class Clock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_base = new System.Windows.Forms.Panel();
            this.clock_anim = new System.Windows.Forms.Timer(this.components);
            this.clock_logic = new System.Windows.Forms.Timer(this.components);
            this.panel_top = new System.Windows.Forms.Panel();
            this.top_clock_display = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textClockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_top.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_base
            // 
            this.panel_base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_base.Location = new System.Drawing.Point(0, 33);
            this.panel_base.Name = "panel_base";
            this.panel_base.Size = new System.Drawing.Size(282, 167);
            this.panel_base.TabIndex = 0;
            this.panel_base.SizeChanged += new System.EventHandler(this.panel_base_SizeChanged);
            // 
            // clock_anim
            // 
            this.clock_anim.Interval = 500;
            this.clock_anim.Tick += new System.EventHandler(this.clock_anim_Tick);
            // 
            // clock_logic
            // 
            this.clock_logic.Interval = 5000;
            this.clock_logic.Tick += new System.EventHandler(this.clock_logic_Tick);
            // 
            // panel_top
            // 
            this.panel_top.Controls.Add(this.top_clock_display);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(282, 33);
            this.panel_top.TabIndex = 1;
            // 
            // top_clock_display
            // 
            this.top_clock_display.Dock = System.Windows.Forms.DockStyle.Fill;
            this.top_clock_display.Location = new System.Drawing.Point(0, 0);
            this.top_clock_display.Name = "top_clock_display";
            this.top_clock_display.Size = new System.Drawing.Size(282, 33);
            this.top_clock_display.TabIndex = 0;
            this.top_clock_display.Text = "00:00:00";
            this.top_clock_display.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(282, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textClockToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // textClockToolStripMenuItem
            // 
            this.textClockToolStripMenuItem.CheckOnClick = true;
            this.textClockToolStripMenuItem.Name = "textClockToolStripMenuItem";
            this.textClockToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.textClockToolStripMenuItem.Text = "Text Clock";
            this.textClockToolStripMenuItem.CheckedChanged += new System.EventHandler(this.textClockToolStripMenuItem_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_base);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel_top);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 225);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 25);
            this.panel2.TabIndex = 2;
            // 
            // Clock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 300);
            this.MinimumSize = new System.Drawing.Size(100, 100);
            this.Name = "Clock";
            this.Text = "Digital Clock";
            this.panel_top.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_base;
        private System.Windows.Forms.Timer clock_anim;
        private System.Windows.Forms.Timer clock_logic;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textClockToolStripMenuItem;
        private System.Windows.Forms.Label top_clock_display;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

