namespace WindowsFormsSamples
{
    partial class Sample1
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
            this.lsbItems = new System.Windows.Forms.ListBox();
            this.btnShowMe = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsbItems
            // 
            this.lsbItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsbItems.FormattingEnabled = true;
            this.lsbItems.Location = new System.Drawing.Point(12, 12);
            this.lsbItems.Name = "lsbItems";
            this.lsbItems.Size = new System.Drawing.Size(260, 95);
            this.lsbItems.TabIndex = 0;
            // 
            // btnShowMe
            // 
            this.btnShowMe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShowMe.Location = new System.Drawing.Point(12, 113);
            this.btnShowMe.Name = "btnShowMe";
            this.btnShowMe.Size = new System.Drawing.Size(75, 23);
            this.btnShowMe.TabIndex = 1;
            this.btnShowMe.Text = "Show Me Selected Item";
            this.btnShowMe.UseVisualStyleBackColor = true;
            this.btnShowMe.Click += new System.EventHandler(this.btnShowMe_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(12, 153);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 2;
            // 
            // Anchor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 179);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnShowMe);
            this.Controls.Add(this.lsbItems);
            this.Name = "Anchor";
            this.Text = "Lifecycle";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Anchor_FormClosing);
            this.Load += new System.EventHandler(this.Lifecycle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbItems;
        private System.Windows.Forms.Button btnShowMe;
        private System.Windows.Forms.Label lblMessage;
    }
}