namespace MyIP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.localiplabel = new System.Windows.Forms.Label();
            this.publiciplabel = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.publicip = new System.Windows.Forms.TextBox();
            this.about = new System.Windows.Forms.Button();
            this.localip = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // localiplabel
            // 
            this.localiplabel.AutoSize = true;
            this.localiplabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localiplabel.Location = new System.Drawing.Point(12, 12);
            this.localiplabel.Name = "localiplabel";
            this.localiplabel.Size = new System.Drawing.Size(74, 23);
            this.localiplabel.TabIndex = 0;
            this.localiplabel.Text = "Local IP:";
            // 
            // publiciplabel
            // 
            this.publiciplabel.AutoSize = true;
            this.publiciplabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publiciplabel.Location = new System.Drawing.Point(12, 54);
            this.publiciplabel.Name = "publiciplabel";
            this.publiciplabel.Size = new System.Drawing.Size(86, 23);
            this.publiciplabel.TabIndex = 1;
            this.publiciplabel.Text = "Public IP: ";
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(319, 99);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(80, 30);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // publicip
            // 
            this.publicip.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicip.Location = new System.Drawing.Point(98, 54);
            this.publicip.Name = "publicip";
            this.publicip.ReadOnly = true;
            this.publicip.Size = new System.Drawing.Size(274, 27);
            this.publicip.TabIndex = 5;
            // 
            // about
            // 
            this.about.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about.Location = new System.Drawing.Point(222, 99);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(80, 30);
            this.about.TabIndex = 6;
            this.about.Text = "About";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // localip
            // 
            this.localip.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.localip.Location = new System.Drawing.Point(98, 12);
            this.localip.Name = "localip";
            this.localip.ReadOnly = true;
            this.localip.Size = new System.Drawing.Size(274, 27);
            this.localip.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Image = global::MyIP.Properties.Resources.refresh1;
            this.button2.Location = new System.Drawing.Point(373, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 26);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(373, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 26);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 141);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.localip);
            this.Controls.Add(this.about);
            this.Controls.Add(this.publicip);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.publiciplabel);
            this.Controls.Add(this.localiplabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyIP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label localiplabel;
        private System.Windows.Forms.Label publiciplabel;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox publicip;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.TextBox localip;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

