
namespace Dolgozo
{
    partial class FormSelect
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
            this.btn_rogz = new System.Windows.Forms.Button();
            this.btn_list = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_rogz
            // 
            this.btn_rogz.Location = new System.Drawing.Point(89, 89);
            this.btn_rogz.Name = "btn_rogz";
            this.btn_rogz.Size = new System.Drawing.Size(182, 65);
            this.btn_rogz.TabIndex = 0;
            this.btn_rogz.Text = "Rögzítés";
            this.btn_rogz.UseVisualStyleBackColor = true;
            this.btn_rogz.Click += new System.EventHandler(this.btn_rogz_Click);
            // 
            // btn_list
            // 
            this.btn_list.Location = new System.Drawing.Point(396, 89);
            this.btn_list.Name = "btn_list";
            this.btn_list.Size = new System.Drawing.Size(182, 65);
            this.btn_list.TabIndex = 1;
            this.btn_list.Text = "Listázás";
            this.btn_list.UseVisualStyleBackColor = true;
            this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
            // 
            // FormSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(666, 259);
            this.Controls.Add(this.btn_list);
            this.Controls.Add(this.btn_rogz);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormSelect";
            this.Text = "Menü";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_rogz;
        private System.Windows.Forms.Button btn_list;
    }
}