namespace WindowsFormsApp3
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
            this.button1 = new System.Windows.Forms.Button();
            this.question_text = new System.Windows.Forms.TextBox();
            this.solution_textbox = new System.Windows.Forms.TextBox();
            this.solution_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.Location = new System.Drawing.Point(484, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "คำนวน";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // question_text
            // 
            this.question_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.question_text.Location = new System.Drawing.Point(81, 67);
            this.question_text.Multiline = true;
            this.question_text.Name = "question_text";
            this.question_text.Size = new System.Drawing.Size(278, 60);
            this.question_text.TabIndex = 1;
            // 
            // solution_textbox
            // 
            this.solution_textbox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.solution_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solution_textbox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.solution_textbox.Location = new System.Drawing.Point(81, 207);
            this.solution_textbox.Multiline = true;
            this.solution_textbox.Name = "solution_textbox";
            this.solution_textbox.Size = new System.Drawing.Size(119, 37);
            this.solution_textbox.TabIndex = 2;
            this.solution_textbox.Text = "0";
            // 
            // solution_label
            // 
            this.solution_label.AutoSize = true;
            this.solution_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.solution_label.ForeColor = System.Drawing.Color.Firebrick;
            this.solution_label.Location = new System.Drawing.Point(418, 219);
            this.solution_label.Name = "solution_label";
            this.solution_label.Size = new System.Drawing.Size(24, 25);
            this.solution_label.TabIndex = 3;
            this.solution_label.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.solution_label);
            this.Controls.Add(this.solution_textbox);
            this.Controls.Add(this.question_text);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox question_text;
        private System.Windows.Forms.TextBox solution_textbox;
        private System.Windows.Forms.Label solution_label;
    }
}

