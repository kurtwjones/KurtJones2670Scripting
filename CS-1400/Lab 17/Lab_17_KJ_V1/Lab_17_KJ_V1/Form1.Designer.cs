namespace Lab_17_KJ_V1
{
    partial class Form1
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
            this.StandardShipBtn = new System.Windows.Forms.RadioButton();
            this.ExpressShipBtn = new System.Windows.Forms.RadioButton();
            this.SameDayShipBtn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StandardShipBtn
            // 
            this.StandardShipBtn.AutoSize = true;
            this.StandardShipBtn.Checked = true;
            this.StandardShipBtn.Location = new System.Drawing.Point(6, 25);
            this.StandardShipBtn.Name = "StandardShipBtn";
            this.StandardShipBtn.Size = new System.Drawing.Size(100, 24);
            this.StandardShipBtn.TabIndex = 0;
            this.StandardShipBtn.TabStop = true;
            this.StandardShipBtn.Text = "Standard";
            this.StandardShipBtn.UseVisualStyleBackColor = false;
            this.StandardShipBtn.CheckedChanged += new System.EventHandler(this.StandardShipBtn_CheckedChanged);
            // 
            // ExpressShipBtn
            // 
            this.ExpressShipBtn.AutoSize = true;
            this.ExpressShipBtn.Location = new System.Drawing.Point(6, 55);
            this.ExpressShipBtn.Name = "ExpressShipBtn";
            this.ExpressShipBtn.Size = new System.Drawing.Size(91, 24);
            this.ExpressShipBtn.TabIndex = 1;
            this.ExpressShipBtn.TabStop = true;
            this.ExpressShipBtn.Text = "Express";
            this.ExpressShipBtn.UseVisualStyleBackColor = true;
            this.ExpressShipBtn.CheckedChanged += new System.EventHandler(this.ExpressShipBtn_CheckedChanged);
            // 
            // SameDayShipBtn
            // 
            this.SameDayShipBtn.AutoSize = true;
            this.SameDayShipBtn.Location = new System.Drawing.Point(6, 85);
            this.SameDayShipBtn.Name = "SameDayShipBtn";
            this.SameDayShipBtn.Size = new System.Drawing.Size(109, 24);
            this.SameDayShipBtn.TabIndex = 2;
            this.SameDayShipBtn.TabStop = true;
            this.SameDayShipBtn.Text = "Same-Day";
            this.SameDayShipBtn.UseVisualStyleBackColor = true;
            this.SameDayShipBtn.CheckedChanged += new System.EventHandler(this.SameDayShipBtn_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose Your Shipping Method:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(336, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(51, 29);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(211, 30);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(211, 30);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ExpressShipBtn);
            this.groupBox1.Controls.Add(this.StandardShipBtn);
            this.groupBox1.Controls.Add(this.SameDayShipBtn);
            this.groupBox1.Location = new System.Drawing.Point(17, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 129);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shipping Method:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 284);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Lab_17_KJ_V1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton StandardShipBtn;
        private System.Windows.Forms.RadioButton ExpressShipBtn;
        private System.Windows.Forms.RadioButton SameDayShipBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

