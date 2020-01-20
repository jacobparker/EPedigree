using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPedigree
{
    public partial class CreatePedigreeForm : Form
    {
        public CreatePedigreeForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cancelForm = new CancelForm();
            cancelForm.Show();
            this.Close();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            var helpForm = new HelpForm();
            helpForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var saveForm = new SaveMessageForm();

            saveForm.Show();
            this.Close();
        }
    }
}
