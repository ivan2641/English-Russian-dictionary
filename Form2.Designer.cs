namespace Lab4
{
    partial class AddWordFrom
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.addLabel = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.typeBox = new System.Windows.Forms.ComboBox();
            this.translateLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Новое слово";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.MaximumSize = new System.Drawing.Size(150, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 68);
            this.label2.TabIndex = 1;
            this.label2.Text = "Перевод (каждый новый вариант перевода - с новой строки)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Часть речи";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(164, 189);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(150, 52);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // addLabel
            // 
            this.addLabel.Location = new System.Drawing.Point(164, 19);
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(150, 22);
            this.addLabel.TabIndex = 0;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(15, 189);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 52);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // typeBox
            // 
            this.typeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeBox.FormattingEnabled = true;
            this.typeBox.Location = new System.Drawing.Point(163, 141);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(150, 24);
            this.typeBox.TabIndex = 6;
            // 
            // translateLabel
            // 
            this.translateLabel.Location = new System.Drawing.Point(164, 55);
            this.translateLabel.Multiline = true;
            this.translateLabel.Name = "translateLabel";
            this.translateLabel.Size = new System.Drawing.Size(150, 74);
            this.translateLabel.TabIndex = 2;
            // 
            // AddWordFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 253);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.translateLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addLabel);
            this.Name = "AddWordFrom";
            this.Text = "Добавить слово";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox addLabel;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.ComboBox typeBox;
        private System.Windows.Forms.TextBox translateLabel;
    }
}