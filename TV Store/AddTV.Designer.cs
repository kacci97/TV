
namespace TV_Store
{
    partial class AddTV
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbProizvoditel = new System.Windows.Forms.TextBox();
            this.nudResolucija = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOtkazi = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudResolucija)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Производител";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Резолуција";
            // 
            // tbProizvoditel
            // 
            this.tbProizvoditel.Location = new System.Drawing.Point(12, 58);
            this.tbProizvoditel.Name = "tbProizvoditel";
            this.tbProizvoditel.Size = new System.Drawing.Size(261, 27);
            this.tbProizvoditel.TabIndex = 2;
            this.tbProizvoditel.Validating += new System.ComponentModel.CancelEventHandler(this.tbProizvoditel_Validating);
            // 
            // nudResolucija
            // 
            this.nudResolucija.Location = new System.Drawing.Point(12, 147);
            this.nudResolucija.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudResolucija.Name = "nudResolucija";
            this.nudResolucija.Size = new System.Drawing.Size(150, 27);
            this.nudResolucija.TabIndex = 3;
            this.nudResolucija.Validating += new System.ComponentModel.CancelEventHandler(this.nudResolucija_Validating);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Додади";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOtkazi
            // 
            this.btnOtkazi.Location = new System.Drawing.Point(12, 223);
            this.btnOtkazi.Name = "btnOtkazi";
            this.btnOtkazi.Size = new System.Drawing.Size(127, 38);
            this.btnOtkazi.TabIndex = 5;
            this.btnOtkazi.Text = "Откажи";
            this.btnOtkazi.UseVisualStyleBackColor = true;
            this.btnOtkazi.Click += new System.EventHandler(this.btnOtkazi_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddTV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 300);
            this.Controls.Add(this.btnOtkazi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nudResolucija);
            this.Controls.Add(this.tbProizvoditel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddTV";
            this.Text = "Add TV";
            this.Load += new System.EventHandler(this.AddTV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudResolucija)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbProizvoditel;
        private System.Windows.Forms.NumericUpDown nudResolucija;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOtkazi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}