namespace HW_Module_03
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 41);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Text = "Задание первое";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnButton1Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 41);
            this.button2.TabIndex = 1;
            this.button2.TabStop = false;
            this.button2.Text = "Задание второе";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnClickButton2);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(27, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 41);
            this.button3.TabIndex = 2;
            this.button3.TabStop = false;
            this.button3.Text = "Задание третье";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(27, 171);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 41);
            this.button4.TabIndex = 3;
            this.button4.TabStop = false;
            this.button4.Text = "Задание четвертое";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(27, 218);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(156, 41);
            this.button5.TabIndex = 4;
            this.button5.TabStop = false;
            this.button5.Text = "Задание пятое";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 289);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HW_Module_03";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}