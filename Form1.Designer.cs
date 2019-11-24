namespace Lab4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlDict = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.textBoxTranslate = new System.Windows.Forms.TextBox();
            this.listBoxWord = new System.Windows.Forms.ListBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelCntMiddle = new System.Windows.Forms.Label();
            this.labelF = new System.Windows.Forms.Label();
            this.labelFail = new System.Windows.Forms.Label();
            this.labelMiddle = new System.Windows.Forms.Label();
            this.labelCntAdj = new System.Windows.Forms.Label();
            this.labelAdj = new System.Windows.Forms.Label();
            this.labelCntVerb = new System.Windows.Forms.Label();
            this.labelVerbs = new System.Windows.Forms.Label();
            this.labelCntNoun = new System.Windows.Forms.Label();
            this.labelNouns = new System.Windows.Forms.Label();
            this.labelCntWords = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.tabControlDict.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlDict
            // 
            this.tabControlDict.Controls.Add(this.tabPage1);
            this.tabControlDict.Controls.Add(this.tabPage2);
            this.tabControlDict.Location = new System.Drawing.Point(21, 12);
            this.tabControlDict.Name = "tabControlDict";
            this.tabControlDict.SelectedIndex = 0;
            this.tabControlDict.Size = new System.Drawing.Size(1122, 480);
            this.tabControlDict.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.buttonDelete);
            this.tabPage1.Controls.Add(this.buttonSave);
            this.tabPage1.Controls.Add(this.buttonAdd);
            this.tabPage1.Controls.Add(this.textBoxType);
            this.tabPage1.Controls.Add(this.textBoxTranslate);
            this.tabPage1.Controls.Add(this.listBoxWord);
            this.tabPage1.Controls.Add(this.buttonExit);
            this.tabPage1.Controls.Add(this.buttonOpen);
            this.tabPage1.Controls.Add(this.buttonTest);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1114, 451);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Изучение слов";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(772, 6);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(165, 45);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "Удалить слово";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(190, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(165, 45);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(943, 6);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(165, 45);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить слово";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // textBoxType
            // 
            this.textBoxType.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxType.BackColor = System.Drawing.Color.White;
            this.textBoxType.Enabled = false;
            this.textBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxType.Location = new System.Drawing.Point(772, 68);
            this.textBoxType.Multiline = true;
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(336, 308);
            this.textBoxType.TabIndex = 4;
            // 
            // textBoxTranslate
            // 
            this.textBoxTranslate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTranslate.BackColor = System.Drawing.Color.White;
            this.textBoxTranslate.Enabled = false;
            this.textBoxTranslate.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTranslate.Location = new System.Drawing.Point(396, 68);
            this.textBoxTranslate.Multiline = true;
            this.textBoxTranslate.Name = "textBoxTranslate";
            this.textBoxTranslate.Size = new System.Drawing.Size(336, 308);
            this.textBoxTranslate.TabIndex = 4;
            // 
            // listBoxWord
            // 
            this.listBoxWord.BackColor = System.Drawing.Color.White;
            this.listBoxWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxWord.FormattingEnabled = true;
            this.listBoxWord.ItemHeight = 38;
            this.listBoxWord.Location = new System.Drawing.Point(19, 70);
            this.listBoxWord.Name = "listBoxWord";
            this.listBoxWord.Size = new System.Drawing.Size(336, 308);
            this.listBoxWord.TabIndex = 3;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(19, 3);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(165, 45);
            this.buttonOpen.TabIndex = 2;
            this.buttonOpen.Text = "Открыть";
            this.buttonOpen.UseVisualStyleBackColor = true;
            // 
            // buttonTest
            // 
            this.buttonTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTest.Location = new System.Drawing.Point(467, 389);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(168, 47);
            this.buttonTest.TabIndex = 1;
            this.buttonTest.Text = "Тестирование";
            this.buttonTest.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.labelCntMiddle);
            this.tabPage2.Controls.Add(this.labelF);
            this.tabPage2.Controls.Add(this.labelFail);
            this.tabPage2.Controls.Add(this.labelMiddle);
            this.tabPage2.Controls.Add(this.labelCntAdj);
            this.tabPage2.Controls.Add(this.labelAdj);
            this.tabPage2.Controls.Add(this.labelCntVerb);
            this.tabPage2.Controls.Add(this.labelVerbs);
            this.tabPage2.Controls.Add(this.labelCntNoun);
            this.tabPage2.Controls.Add(this.labelNouns);
            this.tabPage2.Controls.Add(this.labelCntWords);
            this.tabPage2.Controls.Add(this.labelTotal);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1114, 451);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Статистика";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // labelCntMiddle
            // 
            this.labelCntMiddle.AutoSize = true;
            this.labelCntMiddle.Location = new System.Drawing.Point(215, 154);
            this.labelCntMiddle.Name = "labelCntMiddle";
            this.labelCntMiddle.Size = new System.Drawing.Size(0, 17);
            this.labelCntMiddle.TabIndex = 0;
            // 
            // labelF
            // 
            this.labelF.AutoSize = true;
            this.labelF.Location = new System.Drawing.Point(215, 188);
            this.labelF.Name = "labelF";
            this.labelF.Size = new System.Drawing.Size(84, 17);
            this.labelF.TabIndex = 0;
            this.labelF.Text = "не пройден";
            // 
            // labelFail
            // 
            this.labelFail.AutoSize = true;
            this.labelFail.Location = new System.Drawing.Point(19, 188);
            this.labelFail.Name = "labelFail";
            this.labelFail.Size = new System.Drawing.Size(192, 17);
            this.labelFail.TabIndex = 0;
            this.labelFail.Text = "Количество ошибок в тесте";
            // 
            // labelMiddle
            // 
            this.labelMiddle.AutoSize = true;
            this.labelMiddle.Location = new System.Drawing.Point(18, 154);
            this.labelMiddle.Name = "labelMiddle";
            this.labelMiddle.Size = new System.Drawing.Size(159, 17);
            this.labelMiddle.TabIndex = 0;
            this.labelMiddle.Text = "Средняя длинна слова";
            // 
            // labelCntAdj
            // 
            this.labelCntAdj.AutoSize = true;
            this.labelCntAdj.Location = new System.Drawing.Point(215, 122);
            this.labelCntAdj.Name = "labelCntAdj";
            this.labelCntAdj.Size = new System.Drawing.Size(0, 17);
            this.labelCntAdj.TabIndex = 0;
            // 
            // labelAdj
            // 
            this.labelAdj.AutoSize = true;
            this.labelAdj.Location = new System.Drawing.Point(18, 122);
            this.labelAdj.Name = "labelAdj";
            this.labelAdj.Size = new System.Drawing.Size(160, 17);
            this.labelAdj.TabIndex = 0;
            this.labelAdj.Text = "Число прилагательных";
            // 
            // labelCntVerb
            // 
            this.labelCntVerb.AutoSize = true;
            this.labelCntVerb.Location = new System.Drawing.Point(215, 87);
            this.labelCntVerb.Name = "labelCntVerb";
            this.labelCntVerb.Size = new System.Drawing.Size(0, 17);
            this.labelCntVerb.TabIndex = 0;
            // 
            // labelVerbs
            // 
            this.labelVerbs.AutoSize = true;
            this.labelVerbs.Location = new System.Drawing.Point(18, 93);
            this.labelVerbs.Name = "labelVerbs";
            this.labelVerbs.Size = new System.Drawing.Size(110, 17);
            this.labelVerbs.TabIndex = 0;
            this.labelVerbs.Text = "Число глаголов";
            // 
            // labelCntNoun
            // 
            this.labelCntNoun.AutoSize = true;
            this.labelCntNoun.Location = new System.Drawing.Point(215, 59);
            this.labelCntNoun.Name = "labelCntNoun";
            this.labelCntNoun.Size = new System.Drawing.Size(0, 17);
            this.labelCntNoun.TabIndex = 0;
            // 
            // labelNouns
            // 
            this.labelNouns.AutoSize = true;
            this.labelNouns.Location = new System.Drawing.Point(18, 62);
            this.labelNouns.Name = "labelNouns";
            this.labelNouns.Size = new System.Drawing.Size(169, 17);
            this.labelNouns.TabIndex = 0;
            this.labelNouns.Text = "Число существительных";
            // 
            // labelCntWords
            // 
            this.labelCntWords.AutoSize = true;
            this.labelCntWords.Location = new System.Drawing.Point(215, 30);
            this.labelCntWords.Name = "labelCntWords";
            this.labelCntWords.Size = new System.Drawing.Size(0, 17);
            this.labelCntWords.TabIndex = 0;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(18, 31);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(131, 17);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "Общее число слов";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(927, 389);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(165, 45);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseCompatibleTextRendering = true;
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 509);
            this.Controls.Add(this.tabControlDict);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControlDict.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlDict;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.ListBox listBoxWord;
        private System.Windows.Forms.TextBox textBoxTranslate;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelMiddle;
        private System.Windows.Forms.Label labelAdj;
        private System.Windows.Forms.Label labelVerbs;
        private System.Windows.Forms.Label labelNouns;
        private System.Windows.Forms.Label labelCntWords;
        private System.Windows.Forms.Label labelCntMiddle;
        private System.Windows.Forms.Label labelCntAdj;
        private System.Windows.Forms.Label labelCntVerb;
        private System.Windows.Forms.Label labelCntNoun;
        internal System.Windows.Forms.Label labelF;
        private System.Windows.Forms.Label labelFail;
        private System.Windows.Forms.Button buttonExit;
    }
}

