namespace ExceptionHandling
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
            this.btnGetUrl = new System.Windows.Forms.Button();
            this.btnGetUrlHandled = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGetUrl
            // 
            this.btnGetUrl.Location = new System.Drawing.Point(13, 13);
            this.btnGetUrl.Name = "btnGetUrl";
            this.btnGetUrl.Size = new System.Drawing.Size(147, 23);
            this.btnGetUrl.TabIndex = 0;
            this.btnGetUrl.Text = "Get Url Unhandled";
            this.btnGetUrl.UseVisualStyleBackColor = true;
            this.btnGetUrl.Click += new System.EventHandler(this.btnGetUrl_Click);
            // 
            // btnGetUrlHandled
            // 
            this.btnGetUrlHandled.Location = new System.Drawing.Point(13, 42);
            this.btnGetUrlHandled.Name = "btnGetUrlHandled";
            this.btnGetUrlHandled.Size = new System.Drawing.Size(147, 23);
            this.btnGetUrlHandled.TabIndex = 1;
            this.btnGetUrlHandled.Text = "Get Url Handled";
            this.btnGetUrlHandled.UseVisualStyleBackColor = true;
            this.btnGetUrlHandled.Click += new System.EventHandler(this.btnGetUrlHandled_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 251);
            this.Controls.Add(this.btnGetUrlHandled);
            this.Controls.Add(this.btnGetUrl);
            this.Name = "Form1";
            this.Text = "Exception Handling";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetUrl;
        private System.Windows.Forms.Button btnGetUrlHandled;
    }
}

