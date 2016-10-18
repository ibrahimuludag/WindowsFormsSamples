namespace Usability
{
    partial class UsableForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsableForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ttName = new System.Windows.Forms.ToolTip(this.components);
            this.errorTxtName = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorTxtName)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.errorTxtName.SetError(this.label1, resources.GetString("label1.Error"));
            this.errorTxtName.SetIconAlignment(this.label1, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label1.IconAlignment"))));
            this.errorTxtName.SetIconPadding(this.label1, ((int)(resources.GetObject("label1.IconPadding"))));
            this.label1.Name = "label1";
            this.ttName.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.errorTxtName.SetError(this.txtName, resources.GetString("txtName.Error"));
            this.errorTxtName.SetIconAlignment(this.txtName, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtName.IconAlignment"))));
            this.errorTxtName.SetIconPadding(this.txtName, ((int)(resources.GetObject("txtName.IconPadding"))));
            this.txtName.Name = "txtName";
            this.ttName.SetToolTip(this.txtName, resources.GetString("txtName.ToolTip"));
            // 
            // txtAddress
            // 
            resources.ApplyResources(this.txtAddress, "txtAddress");
            this.errorTxtName.SetError(this.txtAddress, resources.GetString("txtAddress.Error"));
            this.errorTxtName.SetIconAlignment(this.txtAddress, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("txtAddress.IconAlignment"))));
            this.errorTxtName.SetIconPadding(this.txtAddress, ((int)(resources.GetObject("txtAddress.IconPadding"))));
            this.txtAddress.Name = "txtAddress";
            this.ttName.SetToolTip(this.txtAddress, resources.GetString("txtAddress.ToolTip"));
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.errorTxtName.SetError(this.label2, resources.GetString("label2.Error"));
            this.errorTxtName.SetIconAlignment(this.label2, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label2.IconAlignment"))));
            this.errorTxtName.SetIconPadding(this.label2, ((int)(resources.GetObject("label2.IconPadding"))));
            this.label2.Name = "label2";
            this.ttName.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.errorTxtName.SetError(this.label3, resources.GetString("label3.Error"));
            this.errorTxtName.SetIconAlignment(this.label3, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("label3.IconAlignment"))));
            this.errorTxtName.SetIconPadding(this.label3, ((int)(resources.GetObject("label3.IconPadding"))));
            this.label3.Name = "label3";
            this.ttName.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // cbGender
            // 
            resources.ApplyResources(this.cbGender, "cbGender");
            this.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.errorTxtName.SetError(this.cbGender, resources.GetString("cbGender.Error"));
            this.cbGender.FormattingEnabled = true;
            this.errorTxtName.SetIconAlignment(this.cbGender, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("cbGender.IconAlignment"))));
            this.errorTxtName.SetIconPadding(this.cbGender, ((int)(resources.GetObject("cbGender.IconPadding"))));
            this.cbGender.Items.AddRange(new object[] {
            resources.GetString("cbGender.Items"),
            resources.GetString("cbGender.Items1")});
            this.cbGender.Name = "cbGender";
            this.ttName.SetToolTip(this.cbGender, resources.GetString("cbGender.ToolTip"));
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.errorTxtName.SetError(this.btnSave, resources.GetString("btnSave.Error"));
            this.errorTxtName.SetIconAlignment(this.btnSave, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnSave.IconAlignment"))));
            this.errorTxtName.SetIconPadding(this.btnSave, ((int)(resources.GetObject("btnSave.IconPadding"))));
            this.btnSave.Name = "btnSave";
            this.ttName.SetToolTip(this.btnSave, resources.GetString("btnSave.ToolTip"));
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.errorTxtName.SetError(this.btnCancel, resources.GetString("btnCancel.Error"));
            this.errorTxtName.SetIconAlignment(this.btnCancel, ((System.Windows.Forms.ErrorIconAlignment)(resources.GetObject("btnCancel.IconAlignment"))));
            this.errorTxtName.SetIconPadding(this.btnCancel, ((int)(resources.GetObject("btnCancel.IconPadding"))));
            this.btnCancel.Name = "btnCancel";
            this.ttName.SetToolTip(this.btnCancel, resources.GetString("btnCancel.ToolTip"));
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // ttName
            // 
            this.ttName.Tag = "";
            // 
            // errorTxtName
            // 
            this.errorTxtName.ContainerControl = this;
            resources.ApplyResources(this.errorTxtName, "errorTxtName");
            // 
            // UsableForm
            // 
            this.AcceptButton = this.btnSave;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "UsableForm";
            this.ttName.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.Load += new System.EventHandler(this.UsableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorTxtName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ToolTip ttName;
        private System.Windows.Forms.ErrorProvider errorTxtName;
    }
}

