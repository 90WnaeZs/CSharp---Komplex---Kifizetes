
namespace Dolgozo
{
    partial class Listazas
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Átlag = new System.Windows.Forms.Button();
            this.lbl_atlag = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_dolgozo
            // 
            this.combo_dolgozo.FormattingEnabled = true;
            this.combo_dolgozo.Location = new System.Drawing.Point(16, 44);
            this.combo_dolgozo.Name = "combo_dolgozo";
            this.combo_dolgozo.Size = new System.Drawing.Size(278, 28);
            this.combo_dolgozo.TabIndex = 1;
            this.combo_dolgozo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fizető";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kifizetések";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Átlag
            // 
            this.btn_Átlag.Location = new System.Drawing.Point(328, 44);
            this.btn_Átlag.Name = "btn_Átlag";
            this.btn_Átlag.Size = new System.Drawing.Size(131, 28);
            this.btn_Átlag.TabIndex = 4;
            this.btn_Átlag.Text = "Átlag";
            this.btn_Átlag.UseVisualStyleBackColor = true;
            this.btn_Átlag.Click += new System.EventHandler(this.btn_Átlag_Click);
            // 
            // lbl_atlag
            // 
            this.lbl_atlag.AutoSize = true;
            this.lbl_atlag.Location = new System.Drawing.Point(486, 44);
            this.lbl_atlag.Name = "lbl_atlag";
            this.lbl_atlag.Size = new System.Drawing.Size(0, 20);
            this.lbl_atlag.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(727, 380);
            this.dataGridView1.TabIndex = 6;
            // 
            // Listazas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(755, 526);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_atlag);
            this.Controls.Add(this.btn_Átlag);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_dolgozo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Listazas";
            this.Text = "Listázás";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox combo_dolgozo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Átlag;
        private System.Windows.Forms.Label lbl_atlag;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}