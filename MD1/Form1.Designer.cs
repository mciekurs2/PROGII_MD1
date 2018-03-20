namespace MD1
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
            this.skaitlis1 = new System.Windows.Forms.TextBox();
            this.finalValue = new System.Windows.Forms.TextBox();
            this.skaitlis2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rezButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // skaitlis1
            // 
            this.skaitlis1.Location = new System.Drawing.Point(16, 72);
            this.skaitlis1.Name = "skaitlis1";
            this.skaitlis1.Size = new System.Drawing.Size(100, 20);
            this.skaitlis1.TabIndex = 1;
            this.skaitlis1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.skaitlis1_KeyPress);
            // 
            // finalValue
            // 
            this.finalValue.Location = new System.Drawing.Point(265, 72);
            this.finalValue.Name = "finalValue";
            this.finalValue.Size = new System.Drawing.Size(100, 20);
            this.finalValue.TabIndex = 5;
            // 
            // skaitlis2
            // 
            this.skaitlis2.Location = new System.Drawing.Point(140, 72);
            this.skaitlis2.Name = "skaitlis2";
            this.skaitlis2.Size = new System.Drawing.Size(100, 20);
            this.skaitlis2.TabIndex = 3;
            this.skaitlis2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.skaitlis2_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reizinashana";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "x";

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "=";

            // 
            // rezButton
            // 
            this.rezButton.Location = new System.Drawing.Point(17, 108);
            this.rezButton.Name = "rezButton";
            this.rezButton.Size = new System.Drawing.Size(75, 23);
            this.rezButton.TabIndex = 6;
            this.rezButton.Text = "Rezinat";
            this.rezButton.UseVisualStyleBackColor = true;
            this.rezButton.Click += new System.EventHandler(this.rezButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 211);
            this.Controls.Add(this.rezButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.skaitlis2);
            this.Controls.Add(this.finalValue);
            this.Controls.Add(this.skaitlis1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox skaitlis1;
        private System.Windows.Forms.TextBox finalValue;
        private System.Windows.Forms.TextBox skaitlis2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button rezButton;
    }
}


