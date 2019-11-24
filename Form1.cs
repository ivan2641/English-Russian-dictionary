using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Lab4
{
    public partial class Form1 : Form
    {
        internal List<Words> words = new List<Words>();
        private AddWordFrom addWord = new Lab4.AddWordFrom();

        public Form1()
        {
            InitializeComponent();
            buttonOpen.Click += ButtonOpen_Click;
            buttonSave.Click += ButtonSave_Click;
            buttonAdd.Click += ButtonAdd_Click;
            buttonDelete.Click += ButtonDelete_Click;
            listBoxWord.SelectedIndexChanged += ListBoxWord_SelectedIndexChanged;
            tabControlDict.Selected += TabControlDict_Selected;
            buttonTest.Click += ButtonTest_Click;
            buttonExit.Click += ButtonExit_Click;
            //labelCntWords.DataBindings.Add("Text", words, "Count"); //Привязка к свойству или столбцу
            // Count для DataSource невозможна.

        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonTest_Click(object sender, EventArgs e)
        {
            if (words.Count > 0)
            {
                var q = new testForm(words, this);
                q.Show(this);
            }
            else
                MessageBox.Show("Ваш словарь пуст", "Внимание");

        }

        private void TabControlDict_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControlDict.SelectedTab == tabPage2)
            {
                int CntNoun =0, CntVerb =0, CntAdj = 0;
                double sumLetter = 0;
                foreach (var item in words)
                {
                    if (item.type == Words.Type.noun)
                        CntNoun++;
                    else if (item.type == Words.Type.verb)
                        CntVerb++;
                    else if (item.type == Words.Type.adjective)
                        CntAdj++;
                    sumLetter += item.word.Length;
                }
                labelCntWords.Text = words.Count.ToString();
                labelCntNoun.Text = CntNoun.ToString();
                labelCntVerb.Text = CntVerb.ToString();
                labelCntAdj.Text = CntAdj.ToString();
                labelCntMiddle.Text = (sumLetter / words.Count).ToString();
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxWord.SelectedItem != null)
            {
                words.RemoveAt(listBoxWord.SelectedIndex);
                UpdateListBox();
                textBoxTranslate.Text = "";
                textBoxType.Text = "";
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            var save = new SaveFileDialog();
            save.Filter = "XML-files (*.xml)|*.xml|Binary-files (*.bin*)|*.bin*";
            if (save.ShowDialog() == DialogResult.OK)
            {
                if (save.FileName.ToLower().EndsWith("xml"))
                {
                    XmlSerial(save.FileName);
                }
                else
                {
                    BinSerial(save.FileName);
                }
            }
        }

        private void BinSerial(string fileName)
        {
            BinaryFormatter fmt = new BinaryFormatter();
            using (var str =
            new FileStream(fileName, FileMode.Create))
                fmt.Serialize(str, words);
        }

        private void XmlSerial(string fileName)
        {
            Stream sr = new FileStream(fileName, FileMode.Create);
            XmlSerializer xmlSer = new XmlSerializer(typeof(List<Words>));
            xmlSer.Serialize(sr, words);
            sr.Close();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            addWord.ShowDialog(this);
        }

        internal void AddWord(Words newWord)
        {
            words.Add(newWord);
            listBoxWord.Items.Add(newWord.word);
        }

        private void UpdateListBox()
        {
            listBoxWord.Items.Clear();
            foreach (var item in words)
            {
                listBoxWord.Items.Add(item.word);
            }
        }

        private void ListBoxWord_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxWord.SelectedItem == null)
            {
                textBoxTranslate.Text = "";
                textBoxType.Text = "";
                return;
            }
            foreach (var item in words)
            {
                if (listBoxWord.SelectedItem.ToString() == item.word)
                {
                    textBoxTranslate.Text = string.Join("\r\n", item.translate.ToArray());
                    textBoxType.Text = item.type.ToString();
                }
            }
        }

        private void ButtonOpen_Click(object sender, EventArgs e)
        {
            var o = new OpenFileDialog();
            if (o.ShowDialog() == DialogResult.OK)
            {
                if (o.FileName.ToLower().EndsWith("xml"))
                {
                    XmlDeserial(o.FileName);
                }
                else
                {
                    BinDeSerial(o.FileName);
                }
            }
        }

        private void BinDeSerial(string fileName)
        {
            Stream sr = new FileStream(fileName, FileMode.Open);
            IFormatter fmt = new BinaryFormatter();
            words.Clear();
            words = (List <Words>)fmt.Deserialize(sr);
            sr.Close();
            UpdateListBox();
        }

        private void XmlDeserial(string fileName)
        {
            
            Stream sr = new FileStream(fileName, FileMode.Open);
            XmlSerializer xmlSer = new XmlSerializer(typeof(List<Words>));
            words.Clear();
            words = (List<Words>)xmlSer.Deserialize(sr);
            sr.Close();
            UpdateListBox();
        }
    }    
}
