namespace KurGetir
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblsatis = new System.Windows.Forms.Label();
            this.lblalis = new System.Windows.Forms.Label();
            this.lblkur = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Btngetir = new System.Windows.Forms.Button();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblsatis);
            this.groupBox1.Controls.Add(this.lblalis);
            this.groupBox1.Controls.Add(this.lblkur);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(157, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 135);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kur Bilgileri";
            // 
            // lblsatis
            // 
            this.lblsatis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblsatis.Location = new System.Drawing.Point(94, 86);
            this.lblsatis.Name = "lblsatis";
            this.lblsatis.Size = new System.Drawing.Size(137, 29);
            this.lblsatis.TabIndex = 5;
            this.lblsatis.Text = "label6";
            // 
            // lblalis
            // 
            this.lblalis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblalis.Location = new System.Drawing.Point(94, 49);
            this.lblalis.Name = "lblalis";
            this.lblalis.Size = new System.Drawing.Size(137, 26);
            this.lblalis.TabIndex = 4;
            this.lblalis.Text = "label5";
            // 
            // lblkur
            // 
            this.lblkur.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblkur.Location = new System.Drawing.Point(94, 16);
            this.lblkur.Name = "lblkur";
            this.lblkur.Size = new System.Drawing.Size(137, 23);
            this.lblkur.TabIndex = 3;
            this.lblkur.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Satis Fiyati";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "AlisFiyati";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kur Ismi";
            // 
            // Btngetir
            // 
            this.Btngetir.Location = new System.Drawing.Point(298, 100);
            this.Btngetir.Name = "Btngetir";
            this.Btngetir.Size = new System.Drawing.Size(140, 23);
            this.Btngetir.TabIndex = 8;
            this.Btngetir.Text = "Kur Bilgilerini Getir";
            this.Btngetir.UseVisualStyleBackColor = true;
            this.Btngetir.Click += new System.EventHandler(this.Btngetir_Click);
            // 
            // cmbTur
            // 
            this.cmbTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Location = new System.Drawing.Point(473, 100);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(121, 21);
            this.cmbTur.TabIndex = 7;
            this.cmbTur.SelectedIndexChanged += new System.EventHandler(this.cmbTur_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 429);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btngetir);
            this.Controls.Add(this.cmbTur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblsatis;
        private System.Windows.Forms.Label lblalis;
        private System.Windows.Forms.Label lblkur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btngetir;
        private System.Windows.Forms.ComboBox cmbTur;
    }
}

