namespace EPedigree
{
    partial class CancelForm
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
            this.cancelFormButton = new System.Windows.Forms.Button();
            this.cancelMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelFormButton
            // 
            this.cancelFormButton.Location = new System.Drawing.Point(126, 76);
            this.cancelFormButton.Name = "cancelFormButton";
            this.cancelFormButton.Size = new System.Drawing.Size(80, 33);
            this.cancelFormButton.TabIndex = 0;
            this.cancelFormButton.Text = "OK";
            this.cancelFormButton.UseVisualStyleBackColor = true;
            this.cancelFormButton.Click += new System.EventHandler(this.cancelFormButton_Click);
            // 
            // cancelMessage
            // 
            this.cancelMessage.AutoSize = true;
            this.cancelMessage.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelMessage.Location = new System.Drawing.Point(80, 37);
            this.cancelMessage.Name = "cancelMessage";
            this.cancelMessage.Size = new System.Drawing.Size(174, 15);
            this.cancelMessage.TabIndex = 1;
            this.cancelMessage.Text = "Your work has been cancelled!";
            this.cancelMessage.Click += new System.EventHandler(this.label1_Click);
            // 
            // CancelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 135);
            this.Controls.Add(this.cancelMessage);
            this.Controls.Add(this.cancelFormButton);
            this.Name = "CancelForm";
            this.Text = "Message";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelFormButton;
        private System.Windows.Forms.Label cancelMessage;
    }
}