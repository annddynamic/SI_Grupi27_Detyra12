namespace Projekti3
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.verifiedText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ngarko PDF ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(193, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ngarko Certifikaten";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fjalekalimi i Certifikates";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(193, 339);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 53);
            this.button3.TabIndex = 5;
            this.button3.Text = "Nenshkruaj";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(193, 287);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(187, 22);
            this.Password.TabIndex = 6;
            this.Password.UseSystemPasswordChar = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(594, 105);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(235, 44);
            this.button4.TabIndex = 7;
            this.button4.Text = "Ngarko PDF per verifikim";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(594, 180);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(232, 42);
            this.button5.TabIndex = 8;
            this.button5.Text = "Verifiko";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // verifiedText
            // 
            this.verifiedText.Location = new System.Drawing.Point(594, 264);
            this.verifiedText.Multiline = true;
            this.verifiedText.Name = "verifiedText";
            this.verifiedText.Size = new System.Drawing.Size(230, 45);
            this.verifiedText.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projekti3.Properties.Resources.istockphoto_170958625_170667a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1066, 546);
            this.Controls.Add(this.verifiedText);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox verifiedText;
    }
}

