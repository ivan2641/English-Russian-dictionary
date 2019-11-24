namespace Lab4
{
    partial class testForm
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
            this.labelAnswer = new System.Windows.Forms.TextBox();
            this.textQuestion = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelAnswer
            // 
            this.labelAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAnswer.Location = new System.Drawing.Point(17, 65);
            this.labelAnswer.Name = "labelAnswer";
            this.labelAnswer.Size = new System.Drawing.Size(291, 41);
            this.labelAnswer.TabIndex = 1;
            // 
            // textQuestion
            // 
            this.textQuestion.AutoSize = true;
            this.textQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textQuestion.Location = new System.Drawing.Point(14, 24);
            this.textQuestion.Name = "textQuestion";
            this.textQuestion.Size = new System.Drawing.Size(95, 36);
            this.textQuestion.TabIndex = 2;
            this.textQuestion.Text = "label1";
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNext.Location = new System.Drawing.Point(59, 111);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(215, 46);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = "Далее";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // testForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 179);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.textQuestion);
            this.Controls.Add(this.labelAnswer);
            this.Name = "testForm";
            this.Text = "Тестирование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox labelAnswer;
        private System.Windows.Forms.Label textQuestion;
        private System.Windows.Forms.Button buttonNext;
    }
}