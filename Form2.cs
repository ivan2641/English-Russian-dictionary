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
    public partial class AddWordFrom : Form
    {
        private Form1 form1;
        public AddWordFrom()
        {
            InitializeComponent();
            InitTypeBox();
            buttonAdd.Click += ButtonAdd_Click;
            buttonCancel.Click += ButtonCancel_Click;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            form1 = new Form1();
            if (addLabel.Text != "")
            {
                List<string> listTr = new List<string>();
                string[] tmpTr = this.translateLabel.Lines;
                listTr = tmpTr.ToList();
                Words newWord = new Words(addLabel.Text, listTr, (Words.Type)typeBox.SelectedItem);
                (this.Owner as Form1).AddWord(newWord);
                addLabel.Text = null;
                translateLabel.Text = null;
                this.Close();
            }
            else
                MessageBox.Show("Вы не ввели слово", "Внимание");
        }
        private void InitTypeBox()
        {
            typeBox.DataSource = Enum.GetValues(typeof(Words.Type));
            typeBox.SelectedItem = Words.Type.noun;
        }
    }
}
