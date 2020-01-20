﻿using System;
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
    public partial class ManufacturerForm : Form
    {
        public ManufacturerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var saveForm = new SaveMessageForm();
            saveForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cancelForm = new CancelForm();
            cancelForm.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var helpForm = new HelpForm();
            helpForm.Show();
        }
    }
}
