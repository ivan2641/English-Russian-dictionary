using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class testForm : Form
    {
        internal List<Words> testWords;
        public int failAnswer=0;
        private int cntAnswer =0;
        int testLenght = 0;
        Words newTestWords;
        Form1 j;
        public testForm(List<Words> words, Form1 f)
        {
            InitializeComponent();
            f.Visible = false;
            j = f;
            buttonNext.Click += ButtonNext_Click;
            this.testWords = new List<Words>(words);
            testLenght = testWords.Count > 5 ? 5 : testWords.Count;
            question();
        }


        private void ButtonNext_Click(object sender, EventArgs e)
        {
            if (!newTestWords.translate.Contains(labelAnswer.Text.Trim()))
                failAnswer++;
            textQuestion.Text = "";
            labelAnswer.Text = "";
            cntAnswer++;
            if (cntAnswer >= testLenght)
            {
                (this.Owner as Form1).labelF.Text = failAnswer.ToString();  
                this.Close();
                j.Visible = true;
                MessageBox.Show(failAnswer.ToString(), "Количество ошибок");
            }
            else
                question();
        }

        private void question()
        {
            newTestWords = testWords[new Random().Next(0, testWords.Count)];
            testWords.Remove(newTestWords);
            textQuestion.Text = newTestWords.word;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                ButtonNext_Click(null, null);
                return true;
            }
            else
                return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
