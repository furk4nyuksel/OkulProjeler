namespace Web_Browser
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
            this.btnhabergetir = new System.Windows.Forms.Button();
            this.txturl = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // btnhabergetir
            // 
            this.btnhabergetir.Location = new System.Drawing.Point(72, 22);
            this.btnhabergetir.Name = "btnhabergetir";
            this.btnhabergetir.Size = new System.Drawing.Size(122, 36);
            this.btnhabergetir.TabIndex = 0;
            this.btnhabergetir.Text = "Haberleri Getir";
            this.btnhabergetir.UseVisualStyleBackColor = true;
            this.btnhabergetir.Click += new System.EventHandler(this.btnhabergetir_Click);
            // 
            // txturl
            // 
            this.txturl.Location = new System.Drawing.Point(220, 31);
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(217, 20);
            this.txturl.TabIndex = 1;
            this.txturl.TextChanged += new System.EventHandler(this.txturl_TextChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader1});
            this.listView1.Location = new System.Drawing.Point(12, 74);
            this.listView1.Name = "listView1";
            this.listView1.Scrollable = false;
            this.listView1.Size = new System.Drawing.Size(284, 230);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Link";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Haber Başlığı";
            this.columnHeader1.Width = 127;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(332, 74);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(362, 230);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 316);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txturl);
            this.Controls.Add(this.btnhabergetir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhabergetir;
        private System.Windows.Forms.TextBox txturl;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

