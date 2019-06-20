namespace ZaverecnaPrace_MykytaVorobiov
{
    partial class Calc_ZAE_ohm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtU = new System.Windows.Forms.NumericUpDown();
            this.txtI = new System.Windows.Forms.NumericUpDown();
            this.txtR = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtR)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(21, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nápětí U [V] :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(29, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Proud I [A] :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift Condensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(21, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Odpor R [Ω]: ";
            // 
            // btnOK
            // 
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Bahnschrift SemiBold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOK.Location = new System.Drawing.Point(-9, 189);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(344, 88);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "Spočti";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(86, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 34);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ohmův zákon";
            // 
            // txtU
            // 
            this.txtU.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F);
            this.txtU.Location = new System.Drawing.Point(136, 70);
            this.txtU.Name = "txtU";
            this.txtU.Size = new System.Drawing.Size(160, 29);
            this.txtU.TabIndex = 3;
            // 
            // txtI
            // 
            this.txtI.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F);
            this.txtI.Location = new System.Drawing.Point(136, 110);
            this.txtI.Name = "txtI";
            this.txtI.Size = new System.Drawing.Size(160, 29);
            this.txtI.TabIndex = 3;
            // 
            // txtR
            // 
            this.txtR.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.8F);
            this.txtR.Location = new System.Drawing.Point(136, 150);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(160, 29);
            this.txtR.TabIndex = 3;
            // 
            // Calc_ZAE_ohm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(327, 268);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.txtI);
            this.Controls.Add(this.txtU);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Calc_ZAE_ohm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ohmův zákon ";
            ((System.ComponentModel.ISupportInitialize)(this.txtU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtU;
        private System.Windows.Forms.NumericUpDown txtI;
        private System.Windows.Forms.NumericUpDown txtR;
    }
}