namespace ColorMixer
{
    partial class frmColorMixer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmColorMixer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.btnRandomize = new System.Windows.Forms.Button();
            this.txtBlue = new System.Windows.Forms.TextBox();
            this.txtGreen = new System.Windows.Forms.TextBox();
            this.txtRed = new System.Windows.Forms.TextBox();
            this.scrollBarBlue = new System.Windows.Forms.HScrollBar();
            this.scrollBarGreen = new System.Windows.Forms.HScrollBar();
            this.scrollBarRed = new System.Windows.Forms.HScrollBar();
            this.txtRedBinary = new System.Windows.Forms.TextBox();
            this.txtGreenBinary = new System.Windows.Forms.TextBox();
            this.txtBlueBinary = new System.Windows.Forms.TextBox();
            this.txtRedHex = new System.Windows.Forms.TextBox();
            this.txtGreenHex = new System.Windows.Forms.TextBox();
            this.txtBlueHex = new System.Windows.Forms.TextBox();
            this.lblBinary = new System.Windows.Forms.Label();
            this.lblHex = new System.Windows.Forms.Label();
            this.lblDecimal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblBinary);
            this.panel1.Controls.Add(this.lblDecimal);
            this.panel1.Controls.Add(this.lblHex);
            this.panel1.Controls.Add(this.txtBlueHex);
            this.panel1.Controls.Add(this.txtGreenHex);
            this.panel1.Controls.Add(this.txtRedHex);
            this.panel1.Controls.Add(this.txtBlueBinary);
            this.panel1.Controls.Add(this.txtGreenBinary);
            this.panel1.Controls.Add(this.txtRedBinary);
            this.panel1.Controls.Add(this.lblBlue);
            this.panel1.Controls.Add(this.lblGreen);
            this.panel1.Controls.Add(this.lblRed);
            this.panel1.Controls.Add(this.btnRandomize);
            this.panel1.Controls.Add(this.txtBlue);
            this.panel1.Controls.Add(this.txtGreen);
            this.panel1.Controls.Add(this.txtRed);
            this.panel1.Controls.Add(this.scrollBarBlue);
            this.panel1.Controls.Add(this.scrollBarGreen);
            this.panel1.Controls.Add(this.scrollBarRed);
            this.panel1.Location = new System.Drawing.Point(934, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 184);
            this.panel1.TabIndex = 0;
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBlue.Location = new System.Drawing.Point(23, 108);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(57, 25);
            this.lblBlue.TabIndex = 14;
            this.lblBlue.Text = "Blue:";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGreen.Location = new System.Drawing.Point(8, 67);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(72, 25);
            this.lblGreen.TabIndex = 13;
            this.lblGreen.Text = "Green:";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRed.Location = new System.Drawing.Point(27, 27);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(53, 25);
            this.lblRed.TabIndex = 12;
            this.lblRed.Text = "Red:";
            // 
            // btnRandomize
            // 
            this.btnRandomize.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRandomize.Location = new System.Drawing.Point(824, 147);
            this.btnRandomize.Name = "btnRandomize";
            this.btnRandomize.Size = new System.Drawing.Size(100, 23);
            this.btnRandomize.TabIndex = 12;
            this.btnRandomize.Text = "Randomize!";
            this.btnRandomize.UseVisualStyleBackColor = true;
            this.btnRandomize.Click += new System.EventHandler(this.btnRandomize_Click);
            // 
            // txtBlue
            // 
            this.txtBlue.Enabled = false;
            this.txtBlue.Location = new System.Drawing.Point(727, 108);
            this.txtBlue.Name = "txtBlue";
            this.txtBlue.Size = new System.Drawing.Size(36, 22);
            this.txtBlue.TabIndex = 9;
            // 
            // txtGreen
            // 
            this.txtGreen.Enabled = false;
            this.txtGreen.Location = new System.Drawing.Point(727, 67);
            this.txtGreen.Name = "txtGreen";
            this.txtGreen.Size = new System.Drawing.Size(36, 22);
            this.txtGreen.TabIndex = 5;
            // 
            // txtRed
            // 
            this.txtRed.Enabled = false;
            this.txtRed.Location = new System.Drawing.Point(727, 27);
            this.txtRed.Name = "txtRed";
            this.txtRed.Size = new System.Drawing.Size(36, 22);
            this.txtRed.TabIndex = 1;
            // 
            // scrollBarBlue
            // 
            this.scrollBarBlue.LargeChange = 1;
            this.scrollBarBlue.Location = new System.Drawing.Point(86, 108);
            this.scrollBarBlue.Maximum = 255;
            this.scrollBarBlue.Name = "scrollBarBlue";
            this.scrollBarBlue.Size = new System.Drawing.Size(614, 21);
            this.scrollBarBlue.TabIndex = 8;
            this.scrollBarBlue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollBarBlue_Scroll);
            // 
            // scrollBarGreen
            // 
            this.scrollBarGreen.LargeChange = 1;
            this.scrollBarGreen.Location = new System.Drawing.Point(86, 67);
            this.scrollBarGreen.Maximum = 255;
            this.scrollBarGreen.Name = "scrollBarGreen";
            this.scrollBarGreen.Size = new System.Drawing.Size(614, 21);
            this.scrollBarGreen.TabIndex = 4;
            this.scrollBarGreen.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollBarGreen_Scroll);
            // 
            // scrollBarRed
            // 
            this.scrollBarRed.LargeChange = 1;
            this.scrollBarRed.Location = new System.Drawing.Point(86, 27);
            this.scrollBarRed.Maximum = 255;
            this.scrollBarRed.Name = "scrollBarRed";
            this.scrollBarRed.Size = new System.Drawing.Size(614, 21);
            this.scrollBarRed.TabIndex = 0;
            this.scrollBarRed.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollBarRed_Scroll);
            // 
            // txtRedBinary
            // 
            this.txtRedBinary.Enabled = false;
            this.txtRedBinary.Location = new System.Drawing.Point(796, 27);
            this.txtRedBinary.Name = "txtRedBinary";
            this.txtRedBinary.Size = new System.Drawing.Size(75, 22);
            this.txtRedBinary.TabIndex = 2;
            // 
            // txtGreenBinary
            // 
            this.txtGreenBinary.Enabled = false;
            this.txtGreenBinary.Location = new System.Drawing.Point(796, 67);
            this.txtGreenBinary.Name = "txtGreenBinary";
            this.txtGreenBinary.Size = new System.Drawing.Size(75, 22);
            this.txtGreenBinary.TabIndex = 6;
            // 
            // txtBlueBinary
            // 
            this.txtBlueBinary.Enabled = false;
            this.txtBlueBinary.Location = new System.Drawing.Point(796, 108);
            this.txtBlueBinary.Name = "txtBlueBinary";
            this.txtBlueBinary.Size = new System.Drawing.Size(75, 22);
            this.txtBlueBinary.TabIndex = 10;
            // 
            // txtRedHex
            // 
            this.txtRedHex.Enabled = false;
            this.txtRedHex.Location = new System.Drawing.Point(900, 27);
            this.txtRedHex.Name = "txtRedHex";
            this.txtRedHex.Size = new System.Drawing.Size(24, 22);
            this.txtRedHex.TabIndex = 3;
            // 
            // txtGreenHex
            // 
            this.txtGreenHex.Enabled = false;
            this.txtGreenHex.Location = new System.Drawing.Point(900, 67);
            this.txtGreenHex.Name = "txtGreenHex";
            this.txtGreenHex.Size = new System.Drawing.Size(24, 22);
            this.txtGreenHex.TabIndex = 7;
            // 
            // txtBlueHex
            // 
            this.txtBlueHex.Enabled = false;
            this.txtBlueHex.Location = new System.Drawing.Point(900, 108);
            this.txtBlueHex.Name = "txtBlueHex";
            this.txtBlueHex.Size = new System.Drawing.Size(24, 22);
            this.txtBlueHex.TabIndex = 11;
            // 
            // lblBinary
            // 
            this.lblBinary.AutoSize = true;
            this.lblBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBinary.Location = new System.Drawing.Point(805, 4);
            this.lblBinary.Name = "lblBinary";
            this.lblBinary.Size = new System.Drawing.Size(57, 20);
            this.lblBinary.TabIndex = 16;
            this.lblBinary.Text = "Binary";
            // 
            // lblHex
            // 
            this.lblHex.AutoSize = true;
            this.lblHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblHex.Location = new System.Drawing.Point(892, 4);
            this.lblHex.Name = "lblHex";
            this.lblHex.Size = new System.Drawing.Size(39, 20);
            this.lblHex.TabIndex = 17;
            this.lblHex.Text = "Hex";
            // 
            // lblDecimal
            // 
            this.lblDecimal.AutoSize = true;
            this.lblDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDecimal.Location = new System.Drawing.Point(710, 4);
            this.lblDecimal.Name = "lblDecimal";
            this.lblDecimal.Size = new System.Drawing.Size(71, 20);
            this.lblDecimal.TabIndex = 15;
            this.lblDecimal.Text = "Decimal";
            // 
            // frmColorMixer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1902, 981);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1918, 1028);
            this.Name = "frmColorMixer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Mixer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmColorPicker_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmColorPicker_Paint);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.HScrollBar scrollBarBlue;
        private System.Windows.Forms.HScrollBar scrollBarGreen;
        private System.Windows.Forms.HScrollBar scrollBarRed;
        private System.Windows.Forms.TextBox txtBlue;
        private System.Windows.Forms.TextBox txtGreen;
        private System.Windows.Forms.TextBox txtRed;
        private System.Windows.Forms.Button btnRandomize;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.TextBox txtRedBinary;
        private System.Windows.Forms.TextBox txtBlueBinary;
        private System.Windows.Forms.TextBox txtGreenBinary;
        private System.Windows.Forms.TextBox txtBlueHex;
        private System.Windows.Forms.TextBox txtGreenHex;
        private System.Windows.Forms.TextBox txtRedHex;
        private System.Windows.Forms.Label lblBinary;
        private System.Windows.Forms.Label lblHex;
        private System.Windows.Forms.Label lblDecimal;
    }
}