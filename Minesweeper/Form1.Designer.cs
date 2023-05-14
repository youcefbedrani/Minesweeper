namespace Minesweeper
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.biggnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intermediatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pGame = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1252, 255);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1079, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 86);
            this.label2.TabIndex = 1;
            this.label2.Text = "50";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(76, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 86);
            this.label1.TabIndex = 0;
            this.label1.Text = "00:00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.levelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1252, 61);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(141, 57);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(274, 66);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // levelToolStripMenuItem
            // 
            this.levelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.biggnerToolStripMenuItem,
            this.intermediatToolStripMenuItem,
            this.expertToolStripMenuItem});
            this.levelToolStripMenuItem.Name = "levelToolStripMenuItem";
            this.levelToolStripMenuItem.Size = new System.Drawing.Size(129, 57);
            this.levelToolStripMenuItem.Text = "Level";
            // 
            // biggnerToolStripMenuItem
            // 
            this.biggnerToolStripMenuItem.Name = "biggnerToolStripMenuItem";
            this.biggnerToolStripMenuItem.Size = new System.Drawing.Size(538, 66);
            this.biggnerToolStripMenuItem.Text = "Biggner";
            this.biggnerToolStripMenuItem.Click += new System.EventHandler(this.biggnerToolStripMenuItem_Click);
            // 
            // intermediatToolStripMenuItem
            // 
            this.intermediatToolStripMenuItem.Name = "intermediatToolStripMenuItem";
            this.intermediatToolStripMenuItem.Size = new System.Drawing.Size(538, 66);
            this.intermediatToolStripMenuItem.Text = "Intermediat";
            this.intermediatToolStripMenuItem.Click += new System.EventHandler(this.intermediatToolStripMenuItem_Click);
            // 
            // expertToolStripMenuItem
            // 
            this.expertToolStripMenuItem.Name = "expertToolStripMenuItem";
            this.expertToolStripMenuItem.Size = new System.Drawing.Size(538, 66);
            this.expertToolStripMenuItem.Text = "Expert";
            this.expertToolStripMenuItem.Click += new System.EventHandler(this.expertToolStripMenuItem_Click);
            // 
            // pGame
            // 
            this.pGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGame.Location = new System.Drawing.Point(0, 255);
            this.pGame.Name = "pGame";
            this.pGame.Size = new System.Drawing.Size(1252, 1253);
            this.pGame.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 48F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 1508);
            this.Controls.Add(this.pGame);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MineSweeper";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel pGame;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem gameToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem levelToolStripMenuItem;
        private ToolStripMenuItem biggnerToolStripMenuItem;
        private ToolStripMenuItem intermediatToolStripMenuItem;
        private ToolStripMenuItem expertToolStripMenuItem;
    }
}