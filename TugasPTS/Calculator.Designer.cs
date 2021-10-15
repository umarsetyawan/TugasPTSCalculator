
namespace TugasPTS
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
            this.number1_txt = new System.Windows.Forms.TextBox();
            this.number2_txt = new System.Windows.Forms.TextBox();
            this.answer_txt = new System.Windows.Forms.TextBox();
            this.add_btn = new System.Windows.Forms.Button();
            this.subtract_btn = new System.Windows.Forms.Button();
            this.devide_btn = new System.Windows.Forms.Button();
            this.multiply_btn = new System.Windows.Forms.Button();
            this.clr_btn = new System.Windows.Forms.Button();
            this.die_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // number1_txt
            // 
            this.number1_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.number1_txt.Location = new System.Drawing.Point(85, 27);
            this.number1_txt.Name = "number1_txt";
            this.number1_txt.Size = new System.Drawing.Size(141, 20);
            this.number1_txt.TabIndex = 0;
            // 
            // number2_txt
            // 
            this.number2_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.number2_txt.Location = new System.Drawing.Point(85, 67);
            this.number2_txt.Name = "number2_txt";
            this.number2_txt.Size = new System.Drawing.Size(141, 20);
            this.number2_txt.TabIndex = 1;
            // 
            // answer_txt
            // 
            this.answer_txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.answer_txt.Location = new System.Drawing.Point(85, 106);
            this.answer_txt.Name = "answer_txt";
            this.answer_txt.Size = new System.Drawing.Size(141, 20);
            this.answer_txt.TabIndex = 2;
            // 
            // add_btn
            // 
            this.add_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.add_btn.Location = new System.Drawing.Point(12, 164);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(72, 40);
            this.add_btn.TabIndex = 3;
            this.add_btn.Text = "+";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // subtract_btn
            // 
            this.subtract_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.subtract_btn.Location = new System.Drawing.Point(90, 164);
            this.subtract_btn.Name = "subtract_btn";
            this.subtract_btn.Size = new System.Drawing.Size(72, 40);
            this.subtract_btn.TabIndex = 4;
            this.subtract_btn.Text = "-";
            this.subtract_btn.UseVisualStyleBackColor = true;
            this.subtract_btn.Click += new System.EventHandler(this.subtract_btn_Click);
            // 
            // devide_btn
            // 
            this.devide_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.devide_btn.Location = new System.Drawing.Point(168, 164);
            this.devide_btn.Name = "devide_btn";
            this.devide_btn.Size = new System.Drawing.Size(72, 40);
            this.devide_btn.TabIndex = 5;
            this.devide_btn.Text = "%";
            this.devide_btn.UseVisualStyleBackColor = true;
            this.devide_btn.Click += new System.EventHandler(this.devide_btn_Click);
            // 
            // multiply_btn
            // 
            this.multiply_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.multiply_btn.Location = new System.Drawing.Point(246, 164);
            this.multiply_btn.Name = "multiply_btn";
            this.multiply_btn.Size = new System.Drawing.Size(72, 40);
            this.multiply_btn.TabIndex = 6;
            this.multiply_btn.Text = "X";
            this.multiply_btn.UseVisualStyleBackColor = true;
            this.multiply_btn.Click += new System.EventHandler(this.multiply_btn_Click);
            // 
            // clr_btn
            // 
            this.clr_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clr_btn.Location = new System.Drawing.Point(12, 253);
            this.clr_btn.Name = "clr_btn";
            this.clr_btn.Size = new System.Drawing.Size(150, 40);
            this.clr_btn.TabIndex = 7;
            this.clr_btn.Text = "Clear";
            this.clr_btn.UseVisualStyleBackColor = true;
            this.clr_btn.Click += new System.EventHandler(this.clr_btn_Click);
            // 
            // die_btn
            // 
            this.die_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.die_btn.Location = new System.Drawing.Point(168, 253);
            this.die_btn.Name = "die_btn";
            this.die_btn.Size = new System.Drawing.Size(150, 40);
            this.die_btn.TabIndex = 8;
            this.die_btn.Text = "Exit";
            this.die_btn.UseVisualStyleBackColor = true;
            this.die_btn.Click += new System.EventHandler(this.die_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Angka 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Angka 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Jawaban";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 305);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.die_btn);
            this.Controls.Add(this.clr_btn);
            this.Controls.Add(this.multiply_btn);
            this.Controls.Add(this.devide_btn);
            this.Controls.Add(this.subtract_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.answer_txt);
            this.Controls.Add(this.number2_txt);
            this.Controls.Add(this.number1_txt);
            this.MaximumSize = new System.Drawing.Size(345, 480);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox number1_txt;
        private System.Windows.Forms.TextBox number2_txt;
        private System.Windows.Forms.TextBox answer_txt;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button subtract_btn;
        private System.Windows.Forms.Button devide_btn;
        private System.Windows.Forms.Button multiply_btn;
        private System.Windows.Forms.Button clr_btn;
        private System.Windows.Forms.Button die_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

