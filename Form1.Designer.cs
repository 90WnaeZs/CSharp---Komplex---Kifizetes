
namespace Dolgozo
{
    partial class Rogzit
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
            this.combo_dolgozo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.num_osszeg = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Rogzit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_osszeg)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // combo_dolgozo
            // 
            this.combo_dolgozo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.combo_dolgozo.FormattingEnabled = true;
            this.combo_dolgozo.Location = new System.Drawing.Point(94, 54);
            this.combo_dolgozo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.combo_dolgozo.Name = "combo_dolgozo";
            this.combo_dolgozo.Size = new System.Drawing.Size(296, 28);
            this.combo_dolgozo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(34, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fizető";
            // 
            // num_osszeg
            // 
            this.num_osszeg.Location = new System.Drawing.Point(94, 138);
            this.num_osszeg.Maximum = new decimal(new int[] {
            150000,
            0,
            0,
            0});
            this.num_osszeg.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_osszeg.Name = "num_osszeg";
            this.num_osszeg.Size = new System.Drawing.Size(296, 26);
            this.num_osszeg.TabIndex = 2;
            this.num_osszeg.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(24, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Összeg";
            // 
            // btn_Rogzit
            // 
            this.btn_Rogzit.Location = new System.Drawing.Point(232, 197);
            this.btn_Rogzit.Name = "btn_Rogzit";
            this.btn_Rogzit.Size = new System.Drawing.Size(158, 49);
            this.btn_Rogzit.TabIndex = 4;
            this.btn_Rogzit.Text = "Rögzítés";
            this.btn_Rogzit.UseVisualStyleBackColor = true;
            this.btn_Rogzit.Click += new System.EventHandler(this.btn_Rogzit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.combo_dolgozo);
            this.groupBox1.Controls.Add(this.btn_Rogzit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.num_osszeg);
            this.groupBox1.Location = new System.Drawing.Point(25, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 308);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rögzítés";
            // 
            // Rogzit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(482, 363);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Rogzit";
            this.Text = "Kifizetés rögzítése";
            ((System.ComponentModel.ISupportInitialize)(this.num_osszeg)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_dolgozo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_osszeg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Rogzit;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

