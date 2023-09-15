namespace InterfaceToXML
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.configListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // configListBox
            // 
            this.configListBox.FormattingEnabled = true;
            this.configListBox.ItemHeight = 16;
            this.configListBox.Location = new System.Drawing.Point(12, 35);
            this.configListBox.Name = "configListBox";
            this.configListBox.Size = new System.Drawing.Size(357, 164);
            this.configListBox.TabIndex = 4;
            this.configListBox.SelectedIndexChanged += new System.EventHandler(this.configListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Configurations";
            // 
            // selectButton
            // 
            this.selectButton.Enabled = false;
            this.selectButton.Location = new System.Drawing.Point(12, 205);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(131, 33);
            this.selectButton.TabIndex = 6;
            this.selectButton.Text = "Select config";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(238, 205);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(131, 33);
            this.createButton.TabIndex = 7;
            this.createButton.Text = "Create new";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 248);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.configListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Interface to XML";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button createButton;

        private System.Windows.Forms.ListBox configListBox;

        #endregion
    }
}