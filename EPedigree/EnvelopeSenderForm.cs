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
    public partial class EnvelopeSenderForm : Form
    {
        public EnvelopeSenderForm()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var saveForm = new SaveMessageForm();
            saveForm.Show();
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            var cancelForm = new CancelForm();
            cancelForm.Show();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            var helpForm = new HelpForm();
            helpForm.Show();
        }
    }
}
