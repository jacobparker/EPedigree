namespace EPedigree
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pedigreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedigreeCreateMenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.pedigreeCancelButton = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envelopeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.senderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receiverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envelopeCancelButton = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productCancelButton = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.manufacturerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.manufacturerCancelButton = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedigreeToolStripMenuItem,
            this.envelopeToolStripMenuItem,
            this.productToolStripMenuItem,
            this.manufacturerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(426, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pedigreeToolStripMenuItem
            // 
            this.pedigreeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedigreeCreateMenuButton,
            this.pedigreeCancelButton,
            this.helpToolStripMenuItem});
            this.pedigreeToolStripMenuItem.Name = "pedigreeToolStripMenuItem";
            this.pedigreeToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.pedigreeToolStripMenuItem.Text = "Pedigree";
            // 
            // pedigreeCreateMenuButton
            // 
            this.pedigreeCreateMenuButton.Name = "pedigreeCreateMenuButton";
            this.pedigreeCreateMenuButton.Size = new System.Drawing.Size(152, 22);
            this.pedigreeCreateMenuButton.Text = "Create";
            this.pedigreeCreateMenuButton.Click += new System.EventHandler(this.pedigreeCreateMenu);
            // 
            // pedigreeCancelButton
            // 
            this.pedigreeCancelButton.Name = "pedigreeCancelButton";
            this.pedigreeCancelButton.Size = new System.Drawing.Size(152, 22);
            this.pedigreeCancelButton.Text = "Cancel";
            this.pedigreeCancelButton.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // envelopeToolStripMenuItem
            // 
            this.envelopeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.senderToolStripMenuItem,
            this.receiverToolStripMenuItem,
            this.mergeToolStripMenuItem,
            this.envelopeCancelButton,
            this.helpToolStripMenuItem1});
            this.envelopeToolStripMenuItem.Name = "envelopeToolStripMenuItem";
            this.envelopeToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.envelopeToolStripMenuItem.Text = "Envelope";
            // 
            // senderToolStripMenuItem
            // 
            this.senderToolStripMenuItem.Name = "senderToolStripMenuItem";
            this.senderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.senderToolStripMenuItem.Text = "Sender";
            this.senderToolStripMenuItem.Click += new System.EventHandler(this.senderToolStripMenuItem_Click);
            // 
            // receiverToolStripMenuItem
            // 
            this.receiverToolStripMenuItem.Name = "receiverToolStripMenuItem";
            this.receiverToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.receiverToolStripMenuItem.Text = "Receiver";
            this.receiverToolStripMenuItem.Click += new System.EventHandler(this.receiverToolStripMenuItem_Click);
            // 
            // mergeToolStripMenuItem
            // 
            this.mergeToolStripMenuItem.Name = "mergeToolStripMenuItem";
            this.mergeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mergeToolStripMenuItem.Text = "Merge";
            this.mergeToolStripMenuItem.Click += new System.EventHandler(this.mergeToolStripMenuItem_Click);
            // 
            // envelopeCancelButton
            // 
            this.envelopeCancelButton.Name = "envelopeCancelButton";
            this.envelopeCancelButton.Size = new System.Drawing.Size(118, 22);
            this.envelopeCancelButton.Text = "Cancel";
            this.envelopeCancelButton.Click += new System.EventHandler(this.envelopeCancelButton_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.helpToolStripMenuItem1.Text = "Help";
            this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem1,
            this.productCancelButton,
            this.helpToolStripMenuItem2});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.productToolStripMenuItem.Text = "Product";
            // 
            // createToolStripMenuItem1
            // 
            this.createToolStripMenuItem1.Name = "createToolStripMenuItem1";
            this.createToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.createToolStripMenuItem1.Text = "Create";
            this.createToolStripMenuItem1.Click += new System.EventHandler(this.createToolStripMenuItem1_Click);
            // 
            // productCancelButton
            // 
            this.productCancelButton.Name = "productCancelButton";
            this.productCancelButton.Size = new System.Drawing.Size(110, 22);
            this.productCancelButton.Text = "Cancel";
            this.productCancelButton.Click += new System.EventHandler(this.productCancelButton_Click);
            // 
            // helpToolStripMenuItem2
            // 
            this.helpToolStripMenuItem2.Name = "helpToolStripMenuItem2";
            this.helpToolStripMenuItem2.Size = new System.Drawing.Size(110, 22);
            this.helpToolStripMenuItem2.Text = "Help";
            this.helpToolStripMenuItem2.Click += new System.EventHandler(this.helpToolStripMenuItem2_Click);
            // 
            // manufacturerToolStripMenuItem
            // 
            this.manufacturerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem2,
            this.manufacturerCancelButton,
            this.helpToolStripMenuItem3});
            this.manufacturerToolStripMenuItem.Name = "manufacturerToolStripMenuItem";
            this.manufacturerToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.manufacturerToolStripMenuItem.Text = "Manufacturer";
            // 
            // createToolStripMenuItem2
            // 
            this.createToolStripMenuItem2.Name = "createToolStripMenuItem2";
            this.createToolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.createToolStripMenuItem2.Text = "Create";
            this.createToolStripMenuItem2.Click += new System.EventHandler(this.createToolStripMenuItem2_Click);
            // 
            // manufacturerCancelButton
            // 
            this.manufacturerCancelButton.Name = "manufacturerCancelButton";
            this.manufacturerCancelButton.Size = new System.Drawing.Size(110, 22);
            this.manufacturerCancelButton.Text = "Cancel";
            this.manufacturerCancelButton.Click += new System.EventHandler(this.manufacturerCancelButton_Click);
            // 
            // helpToolStripMenuItem3
            // 
            this.helpToolStripMenuItem3.Name = "helpToolStripMenuItem3";
            this.helpToolStripMenuItem3.Size = new System.Drawing.Size(110, 22);
            this.helpToolStripMenuItem3.Text = "Help";
            this.helpToolStripMenuItem3.Click += new System.EventHandler(this.helpToolStripMenuItem3_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(145, 53);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(120, 27);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Welcome!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please select a menu to begin.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(426, 194);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "E-Pedigree Application";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pedigreeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envelopeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manufacturerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedigreeCreateMenuButton;
        private System.Windows.Forms.ToolStripMenuItem pedigreeCancelButton;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem senderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receiverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mergeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envelopeCancelButton;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productCancelButton;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem manufacturerCancelButton;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem3;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label label1;
    }
}

