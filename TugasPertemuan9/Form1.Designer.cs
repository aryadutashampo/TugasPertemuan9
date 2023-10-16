namespace TugasPertemuan9
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.btnCE = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnhasil = new System.Windows.Forms.Button();
            this.btndecimal = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.txthasil = new System.Windows.Forms.TextBox();
            this.labelProses = new System.Windows.Forms.Label();
            this.btntambah = new System.Windows.Forms.Button();
            this.btnkurang = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnkali = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnbagi = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.DarkGray;
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.Location = new System.Drawing.Point(315, 116);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(84, 63);
            this.btnCE.TabIndex = 9;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.DarkGray;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(316, 185);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(84, 63);
            this.btnclear.TabIndex = 14;
            this.btnclear.Text = "C";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnhasil
            // 
            this.btnhasil.BackColor = System.Drawing.Color.DarkGray;
            this.btnhasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhasil.Location = new System.Drawing.Point(316, 254);
            this.btnhasil.Name = "btnhasil";
            this.btnhasil.Size = new System.Drawing.Size(84, 132);
            this.btnhasil.TabIndex = 19;
            this.btnhasil.Text = "=";
            this.btnhasil.UseVisualStyleBackColor = false;
            this.btnhasil.Click += new System.EventHandler(this.btnhasil_Click);
            // 
            // btndecimal
            // 
            this.btndecimal.BackColor = System.Drawing.Color.DimGray;
            this.btndecimal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btndecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndecimal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndecimal.Location = new System.Drawing.Point(164, 323);
            this.btndecimal.Name = "btndecimal";
            this.btndecimal.Size = new System.Drawing.Size(70, 63);
            this.btndecimal.TabIndex = 17;
            this.btndecimal.Text = ".";
            this.btndecimal.UseVisualStyleBackColor = false;
            this.btndecimal.Click += new System.EventHandler(this.btnangka_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.DimGray;
            this.btn0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn0.Location = new System.Drawing.Point(12, 323);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(146, 63);
            this.btn0.TabIndex = 15;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btnangka_Click);
            // 
            // txthasil
            // 
            this.txthasil.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txthasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthasil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txthasil.Location = new System.Drawing.Point(15, 64);
            this.txthasil.Multiline = true;
            this.txthasil.Name = "txthasil";
            this.txthasil.Size = new System.Drawing.Size(384, 39);
            this.txthasil.TabIndex = 20;
            this.txthasil.Text = "0";
            this.txthasil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelProses
            // 
            this.labelProses.AutoSize = true;
            this.labelProses.BackColor = System.Drawing.SystemColors.Window;
            this.labelProses.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProses.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.labelProses.Location = new System.Drawing.Point(22, 32);
            this.labelProses.Name = "labelProses";
            this.labelProses.Size = new System.Drawing.Size(0, 29);
            this.labelProses.TabIndex = 21;
            // 
            // btntambah
            // 
            this.btntambah.BackColor = System.Drawing.Color.DarkOrange;
            this.btntambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btntambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntambah.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btntambah.Location = new System.Drawing.Point(240, 323);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(70, 63);
            this.btntambah.TabIndex = 18;
            this.btntambah.Text = "+";
            this.btntambah.UseVisualStyleBackColor = false;
            this.btntambah.Click += new System.EventHandler(this.operator_Click);
            // 
            // btnkurang
            // 
            this.btnkurang.BackColor = System.Drawing.Color.DarkOrange;
            this.btnkurang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnkurang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkurang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnkurang.Location = new System.Drawing.Point(240, 254);
            this.btnkurang.Name = "btnkurang";
            this.btnkurang.Size = new System.Drawing.Size(70, 63);
            this.btnkurang.TabIndex = 13;
            this.btnkurang.Text = "-";
            this.btnkurang.UseVisualStyleBackColor = false;
            this.btnkurang.Click += new System.EventHandler(this.operator_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.DimGray;
            this.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn3.Location = new System.Drawing.Point(164, 254);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(70, 63);
            this.btn3.TabIndex = 12;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btnangka_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.DimGray;
            this.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn2.Location = new System.Drawing.Point(88, 254);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(70, 63);
            this.btn2.TabIndex = 11;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btnangka_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.DimGray;
            this.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn1.Location = new System.Drawing.Point(12, 254);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(70, 63);
            this.btn1.TabIndex = 10;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btnangka_Click);
            // 
            // btnkali
            // 
            this.btnkali.BackColor = System.Drawing.Color.DarkOrange;
            this.btnkali.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnkali.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkali.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnkali.Location = new System.Drawing.Point(240, 185);
            this.btnkali.Name = "btnkali";
            this.btnkali.Size = new System.Drawing.Size(70, 63);
            this.btnkali.TabIndex = 8;
            this.btnkali.Text = "x";
            this.btnkali.UseVisualStyleBackColor = false;
            this.btnkali.Click += new System.EventHandler(this.operator_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.DimGray;
            this.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn6.Location = new System.Drawing.Point(164, 185);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(70, 63);
            this.btn6.TabIndex = 7;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btnangka_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.DimGray;
            this.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn5.Location = new System.Drawing.Point(88, 185);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(70, 63);
            this.btn5.TabIndex = 6;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btnangka_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.DimGray;
            this.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn4.Location = new System.Drawing.Point(12, 185);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(70, 63);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btnangka_Click);
            // 
            // btnbagi
            // 
            this.btnbagi.BackColor = System.Drawing.Color.DarkOrange;
            this.btnbagi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnbagi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbagi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnbagi.Location = new System.Drawing.Point(240, 116);
            this.btnbagi.Name = "btnbagi";
            this.btnbagi.Size = new System.Drawing.Size(70, 63);
            this.btnbagi.TabIndex = 3;
            this.btnbagi.Text = "/";
            this.btnbagi.UseVisualStyleBackColor = false;
            this.btnbagi.Click += new System.EventHandler(this.operator_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.DimGray;
            this.btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn9.Location = new System.Drawing.Point(164, 116);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(70, 63);
            this.btn9.TabIndex = 2;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btnangka_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.DimGray;
            this.btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn8.Location = new System.Drawing.Point(88, 116);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(70, 63);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btnangka_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.DimGray;
            this.btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn7.Location = new System.Drawing.Point(12, 116);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(70, 63);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btnangka_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(412, 401);
            this.Controls.Add(this.labelProses);
            this.Controls.Add(this.txthasil);
            this.Controls.Add(this.btnhasil);
            this.Controls.Add(this.btntambah);
            this.Controls.Add(this.btndecimal);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnkurang);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btnkali);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btnbagi);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnbagi;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnkali;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnkurang;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnhasil;
        private System.Windows.Forms.Button btntambah;
        private System.Windows.Forms.Button btndecimal;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.TextBox txthasil;
        private System.Windows.Forms.Label labelProses;
    }
}

