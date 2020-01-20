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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cancelForm = new CancelForm();
            cancelForm.Show();
        }

        private void envelopeCancelButton_Click(object sender, EventArgs e)
        {
            var cancelForm = new CancelForm();
            cancelForm.Show();
            
        }

        private void productCancelButton_Click(object sender, EventArgs e)
        {
            var cancelForm = new CancelForm();
            cancelForm.Show();
            
        }

        private void manufacturerCancelButton_Click(object sender, EventArgs e)
        {
            var cancelForm = new CancelForm();
            cancelForm.Show();
            
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var helpForm = new HelpForm();
            helpForm.Show();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var helpForm = new HelpForm();
            helpForm.Show();
        }

        private void helpToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var helpForm = new HelpForm();
            helpForm.Show();
        }

        private void helpToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var helpForm = new HelpForm();
            helpForm.Show();
        }

        private void pedigreeCreateMenu(object sender, EventArgs e)
        {
            var createPedigree = new CreatePedigreeForm();

            createPedigree.Show();
        }

        private void mergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var envelopeMergeForm = new EnvelopeMergeForm();
            envelopeMergeForm.Show();
        }

        private void senderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var envelopeSenderForm = new EnvelopeSenderForm();
            envelopeSenderForm.Show();
        }

        private void receiverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var envelopeReceiverForm = new EnvelopeReceiverForm();
            envelopeReceiverForm.Show();
        }

        private void createToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var productCreateForm = new ProductCreateForm();
            productCreateForm.Show();
        }

        private void createToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var manufacturerCreateForm = new ManufacturerForm();
            manufacturerCreateForm.Show();
        }
    }
}
