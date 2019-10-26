using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson_8_1
{
    public partial class MVCForm : Form
    {
        private IController controller;
        private IModel model;

        public MVCForm(IController contr, IModel model)
        {
            if (contr == null)
            {
                throw new Exception("Bad controller!");
            }
            controller = contr;
            if (model == null)
            {
                throw new NullReferenceException("Model not present in form");
            }
            this.model = model;
            model.DataChanged += Model_DataChanged;
            InitializeComponent();
        }

        private void Model_DataChanged()
        {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(model.GetData() as object[]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                return;
            }
            controller.AddData(textBox1.Text);
            textBox1.Text = "";
        }

    }
}
