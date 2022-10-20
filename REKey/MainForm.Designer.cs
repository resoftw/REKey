namespace REKey
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lbl = new System.Windows.Forms.Label();
            this.tb = new System.Windows.Forms.TextBox();
            this.lblctrl = new System.Windows.Forms.Label();
            this.lblalt = new System.Windows.Forms.Label();
            this.lblshift = new System.Windows.Forms.Label();
            this.lbrshift = new System.Windows.Forms.Label();
            this.lbrctrl = new System.Windows.Forms.Label();
            this.lbralt = new System.Windows.Forms.Label();
            this.lblwin = new System.Windows.Forms.Label();
            this.lbrwin = new System.Windows.Forms.Label();
            this.lbctx = new System.Windows.Forms.Label();
            this.lblstat = new System.Windows.Forms.Label();
            this.lblstat2 = new System.Windows.Forms.Label();
            this.lblstat3 = new System.Windows.Forms.Label();
            this.lblcaps = new System.Windows.Forms.Label();
            this.lblnum = new System.Windows.Forms.Label();
            this.lblscroll = new System.Windows.Forms.Label();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.traymenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traymenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Location = new System.Drawing.Point(0, 0);
            this.lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(869, 196);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Label";
            // 
            // tb
            // 
            this.tb.AcceptsReturn = true;
            this.tb.Location = new System.Drawing.Point(20, 465);
            this.tb.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.tb.Multiline = true;
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(819, 424);
            this.tb.TabIndex = 1;
            // 
            // lblctrl
            // 
            this.lblctrl.AutoSize = true;
            this.lblctrl.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblctrl.ForeColor = System.Drawing.Color.DarkGray;
            this.lblctrl.Location = new System.Drawing.Point(22, 284);
            this.lblctrl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblctrl.Name = "lblctrl";
            this.lblctrl.Size = new System.Drawing.Size(92, 59);
            this.lblctrl.TabIndex = 2;
            this.lblctrl.Text = "Ctrl";
            // 
            // lblalt
            // 
            this.lblalt.AutoSize = true;
            this.lblalt.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblalt.ForeColor = System.Drawing.Color.DarkGray;
            this.lblalt.Location = new System.Drawing.Point(198, 284);
            this.lblalt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblalt.Name = "lblalt";
            this.lblalt.Size = new System.Drawing.Size(78, 59);
            this.lblalt.TabIndex = 3;
            this.lblalt.Text = "Alt";
            // 
            // lblshift
            // 
            this.lblshift.AutoSize = true;
            this.lblshift.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblshift.ForeColor = System.Drawing.Color.DarkGray;
            this.lblshift.Location = new System.Drawing.Point(22, 196);
            this.lblshift.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblshift.Name = "lblshift";
            this.lblshift.Size = new System.Drawing.Size(110, 59);
            this.lblshift.TabIndex = 4;
            this.lblshift.Text = "Shift";
            // 
            // lbrshift
            // 
            this.lbrshift.AutoSize = true;
            this.lbrshift.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbrshift.ForeColor = System.Drawing.Color.DarkGray;
            this.lbrshift.Location = new System.Drawing.Point(726, 196);
            this.lbrshift.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbrshift.Name = "lbrshift";
            this.lbrshift.Size = new System.Drawing.Size(110, 59);
            this.lbrshift.TabIndex = 5;
            this.lbrshift.Text = "Shift";
            // 
            // lbrctrl
            // 
            this.lbrctrl.AutoSize = true;
            this.lbrctrl.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbrctrl.ForeColor = System.Drawing.Color.DarkGray;
            this.lbrctrl.Location = new System.Drawing.Point(730, 284);
            this.lbrctrl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbrctrl.Name = "lbrctrl";
            this.lbrctrl.Size = new System.Drawing.Size(92, 59);
            this.lbrctrl.TabIndex = 6;
            this.lbrctrl.Text = "Ctrl";
            // 
            // lbralt
            // 
            this.lbralt.AutoSize = true;
            this.lbralt.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbralt.ForeColor = System.Drawing.Color.DarkGray;
            this.lbralt.Location = new System.Drawing.Point(439, 284);
            this.lbralt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbralt.Name = "lbralt";
            this.lbralt.Size = new System.Drawing.Size(78, 59);
            this.lbralt.TabIndex = 7;
            this.lbralt.Text = "Alt";
            // 
            // lblwin
            // 
            this.lblwin.AutoSize = true;
            this.lblwin.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblwin.ForeColor = System.Drawing.Color.DarkGray;
            this.lblwin.Location = new System.Drawing.Point(126, 291);
            this.lblwin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblwin.Name = "lblwin";
            this.lblwin.Size = new System.Drawing.Size(60, 42);
            this.lblwin.TabIndex = 8;
            this.lblwin.Text = "";
            // 
            // lbrwin
            // 
            this.lbrwin.AutoSize = true;
            this.lbrwin.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbrwin.ForeColor = System.Drawing.Color.DarkGray;
            this.lbrwin.Location = new System.Drawing.Point(544, 291);
            this.lbrwin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbrwin.Name = "lbrwin";
            this.lbrwin.Size = new System.Drawing.Size(62, 43);
            this.lbrwin.TabIndex = 9;
            this.lbrwin.Text = "";
            // 
            // lbctx
            // 
            this.lbctx.AutoSize = true;
            this.lbctx.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbctx.ForeColor = System.Drawing.Color.DarkGray;
            this.lbctx.Location = new System.Drawing.Point(618, 284);
            this.lbctx.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbctx.Name = "lbctx";
            this.lbctx.Size = new System.Drawing.Size(87, 59);
            this.lbctx.TabIndex = 10;
            this.lbctx.Text = "Ctx";
            // 
            // lblstat
            // 
            this.lblstat.AutoSize = true;
            this.lblstat.ForeColor = System.Drawing.Color.White;
            this.lblstat.Location = new System.Drawing.Point(39, 395);
            this.lblstat.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblstat.Name = "lblstat";
            this.lblstat.Size = new System.Drawing.Size(78, 32);
            this.lblstat.TabIndex = 11;
            this.lblstat.Text = "label1";
            // 
            // lblstat2
            // 
            this.lblstat2.AutoSize = true;
            this.lblstat2.ForeColor = System.Drawing.Color.White;
            this.lblstat2.Location = new System.Drawing.Point(336, 395);
            this.lblstat2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblstat2.Name = "lblstat2";
            this.lblstat2.Size = new System.Drawing.Size(78, 32);
            this.lblstat2.TabIndex = 12;
            this.lblstat2.Text = "label1";
            // 
            // lblstat3
            // 
            this.lblstat3.AutoSize = true;
            this.lblstat3.ForeColor = System.Drawing.Color.White;
            this.lblstat3.Location = new System.Drawing.Point(618, 395);
            this.lblstat3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblstat3.Name = "lblstat3";
            this.lblstat3.Size = new System.Drawing.Size(78, 32);
            this.lblstat3.TabIndex = 13;
            this.lblstat3.Text = "label1";
            // 
            // lblcaps
            // 
            this.lblcaps.AutoSize = true;
            this.lblcaps.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblcaps.ForeColor = System.Drawing.Color.DarkGray;
            this.lblcaps.Location = new System.Drawing.Point(318, 213);
            this.lblcaps.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblcaps.Name = "lblcaps";
            this.lblcaps.Size = new System.Drawing.Size(75, 37);
            this.lblcaps.TabIndex = 14;
            this.lblcaps.Text = "Caps";
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblnum.ForeColor = System.Drawing.Color.DarkGray;
            this.lblnum.Location = new System.Drawing.Point(405, 213);
            this.lblnum.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(75, 37);
            this.lblnum.TabIndex = 15;
            this.lblnum.Text = "Num";
            // 
            // lblscroll
            // 
            this.lblscroll.AutoSize = true;
            this.lblscroll.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblscroll.ForeColor = System.Drawing.Color.DarkGray;
            this.lblscroll.Location = new System.Drawing.Point(503, 213);
            this.lblscroll.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblscroll.Name = "lblscroll";
            this.lblscroll.Size = new System.Drawing.Size(82, 37);
            this.lblscroll.TabIndex = 16;
            this.lblscroll.Text = "Scroll";
            // 
            // tmr
            // 
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // tray
            // 
            this.tray.ContextMenuStrip = this.traymenu;
            this.tray.Icon = ((System.Drawing.Icon)(resources.GetObject("tray.Icon")));
            this.tray.Text = "REKey";
            this.tray.Visible = true;
            // 
            // traymenu
            // 
            this.traymenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.traymenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.traymenu.Name = "traymenu";
            this.traymenu.Size = new System.Drawing.Size(169, 86);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(168, 38);
            this.aboutToolStripMenuItem.Text = "About...";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(165, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(168, 38);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(864, 915);
            this.Controls.Add(this.lblscroll);
            this.Controls.Add(this.lblnum);
            this.Controls.Add(this.lblcaps);
            this.Controls.Add(this.lblstat3);
            this.Controls.Add(this.lblstat2);
            this.Controls.Add(this.lblstat);
            this.Controls.Add(this.lbctx);
            this.Controls.Add(this.lbrwin);
            this.Controls.Add(this.lblwin);
            this.Controls.Add(this.lbralt);
            this.Controls.Add(this.lbrctrl);
            this.Controls.Add(this.lbrshift);
            this.Controls.Add(this.lblshift);
            this.Controls.Add(this.lblalt);
            this.Controls.Add(this.lblctrl);
            this.Controls.Add(this.tb);
            this.Controls.Add(this.lbl);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "MainForm";
            this.Text = "REKey";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.traymenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl;
        private TextBox tb;
        private Label lblctrl;
        private Label lblalt;
        private Label lblshift;
        private Label lbrshift;
        private Label lbrctrl;
        private Label lbralt;
        private Label lblwin;
        private Label lbrwin;
        private Label lbctx;
        private Label lblstat;
        private Label lblstat2;
        private Label lblstat3;
        private Label lblcaps;
        private Label lblnum;
        private Label lblscroll;
        private System.Windows.Forms.Timer tmr;
        private NotifyIcon tray;
        private ContextMenuStrip traymenu;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}