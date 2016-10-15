namespace WindowsFormsSamples.UserControlSample
{
    partial class PersonForm
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
            Person person2 = new Person();
            this.personControl1 = new PersonControl();
            this.SuspendLayout();
            // 
            // personControl1
            // 
            this.personControl1.Location = new System.Drawing.Point(12, 22);
            this.personControl1.Name = "personControl1";
            person2.Age = "";
            person2.FirstName = "";
            person2.LastName = "";
            this.personControl1.Person = person2;
            this.personControl1.Size = new System.Drawing.Size(232, 91);
            this.personControl1.TabIndex = 0;
            // 
            // PersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 160);
            this.Controls.Add(this.personControl1);
            this.Name = "PersonForm";
            this.Text = "PersonForm";
            this.Load += new System.EventHandler(this.PersonForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private PersonControl personControl1;
    }
}