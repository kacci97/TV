
namespace TV_Store
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDodadi = new System.Windows.Forms.Button();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.lbTelevizori = new System.Windows.Forms.ListBox();
            this.btnProdadi = new System.Windows.Forms.Button();
            this.lbProdadeni = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rbMostSales = new System.Windows.Forms.RadioButton();
            this.rbResolution = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDodadi);
            this.groupBox1.Controls.Add(this.btnIzbrisi);
            this.groupBox1.Controls.Add(this.lbTelevizori);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 406);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Телевизори";
            // 
            // btnDodadi
            // 
            this.btnDodadi.Location = new System.Drawing.Point(25, 305);
            this.btnDodadi.Name = "btnDodadi";
            this.btnDodadi.Size = new System.Drawing.Size(256, 29);
            this.btnDodadi.TabIndex = 1;
            this.btnDodadi.Text = "Додади телевизор";
            this.btnDodadi.UseVisualStyleBackColor = true;
            this.btnDodadi.Click += new System.EventHandler(this.btnDodadi_Click);
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(25, 350);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(256, 29);
            this.btnIzbrisi.TabIndex = 2;
            this.btnIzbrisi.Text = "Избриши телевизор";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbTelevizori
            // 
            this.lbTelevizori.FormattingEnabled = true;
            this.lbTelevizori.ItemHeight = 20;
            this.lbTelevizori.Location = new System.Drawing.Point(25, 36);
            this.lbTelevizori.Name = "lbTelevizori";
            this.lbTelevizori.Size = new System.Drawing.Size(256, 244);
            this.lbTelevizori.TabIndex = 0;
            // 
            // btnProdadi
            // 
            this.btnProdadi.Location = new System.Drawing.Point(355, 82);
            this.btnProdadi.Name = "btnProdadi";
            this.btnProdadi.Size = new System.Drawing.Size(94, 29);
            this.btnProdadi.TabIndex = 1;
            this.btnProdadi.Text = "Продади";
            this.btnProdadi.UseVisualStyleBackColor = true;
            this.btnProdadi.Click += new System.EventHandler(this.btnProdadi_Click);
            // 
            // lbProdadeni
            // 
            this.lbProdadeni.AutoSize = true;
            this.lbProdadeni.Location = new System.Drawing.Point(355, 140);
            this.lbProdadeni.Name = "lbProdadeni";
            this.lbProdadeni.Size = new System.Drawing.Size(0, 20);
            this.lbProdadeni.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(355, 311);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 27);
            this.textBox1.TabIndex = 3;
            // 
            // rbMostSales
            // 
            this.rbMostSales.AutoSize = true;
            this.rbMostSales.Location = new System.Drawing.Point(355, 203);
            this.rbMostSales.Name = "rbMostSales";
            this.rbMostSales.Size = new System.Drawing.Size(142, 24);
            this.rbMostSales.TabIndex = 5;
            this.rbMostSales.TabStop = true;
            this.rbMostSales.Text = "Најпродаван ТВ";
            this.rbMostSales.UseVisualStyleBackColor = true;
            this.rbMostSales.CheckedChanged += new System.EventHandler(this.rbMostSales_CheckedChanged);
            this.rbMostSales.Click += new System.EventHandler(this.rbMostSales_Click);
            // 
            // rbResolution
            // 
            this.rbResolution.AutoSize = true;
            this.rbResolution.Location = new System.Drawing.Point(355, 247);
            this.rbResolution.Name = "rbResolution";
            this.rbResolution.Size = new System.Drawing.Size(224, 24);
            this.rbResolution.TabIndex = 6;
            this.rbResolution.TabStop = true;
            this.rbResolution.Text = "ТВ со најголема резолуција";
            this.rbResolution.UseVisualStyleBackColor = true;
            this.rbResolution.CheckedChanged += new System.EventHandler(this.rbResolution_CheckedChanged);
            this.rbResolution.Click += new System.EventHandler(this.rbResolution_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 438);
            this.Controls.Add(this.rbResolution);
            this.Controls.Add(this.rbMostSales);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbProdadeni);
            this.Controls.Add(this.btnProdadi);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "TV Store";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDodadi;
        private System.Windows.Forms.Button btnIzbrisi;
        private System.Windows.Forms.ListBox lbTelevizori;
        private System.Windows.Forms.Button btnProdadi;
        private System.Windows.Forms.Label lbProdadeni;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton rbMostSales;
        private System.Windows.Forms.RadioButton rbResolution;
    }
}

