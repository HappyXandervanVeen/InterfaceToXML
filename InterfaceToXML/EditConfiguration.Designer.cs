using System.ComponentModel;

namespace InterfaceToXML
{
    partial class EditConfiguration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditConfiguration));
            this.serviceNameLabel = new System.Windows.Forms.Label();
            this.serviceNameTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.connectionStringTextBox = new System.Windows.Forms.TextBox();
            this.connectionStringLabel = new System.Windows.Forms.Label();
            this.minimalLogLevelComboBox = new System.Windows.Forms.ComboBox();
            this.minimalLogLevelLabel = new System.Windows.Forms.Label();
            this.logStartAndStopCheckBox = new System.Windows.Forms.CheckBox();
            this.logRunStartAndStopCheckBox = new System.Windows.Forms.CheckBox();
            this.logRunBodyCheckBox = new System.Windows.Forms.CheckBox();
            this.deselectMinimalLogLevelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serviceNameLabel
            // 
            this.serviceNameLabel.Location = new System.Drawing.Point(9, 7);
            this.serviceNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.serviceNameLabel.Name = "serviceNameLabel";
            this.serviceNameLabel.Size = new System.Drawing.Size(264, 22);
            this.serviceNameLabel.TabIndex = 0;
            this.serviceNameLabel.Text = "Service name";
            this.serviceNameLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // serviceNameTextBox
            // 
            this.serviceNameTextBox.Location = new System.Drawing.Point(9, 32);
            this.serviceNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.serviceNameTextBox.Name = "serviceNameTextBox";
            this.serviceNameTextBox.Size = new System.Drawing.Size(264, 20);
            this.serviceNameTextBox.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(496, 328);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(91, 29);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // connectionStringTextBox
            // 
            this.connectionStringTextBox.Location = new System.Drawing.Point(11, 79);
            this.connectionStringTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.connectionStringTextBox.Name = "connectionStringTextBox";
            this.connectionStringTextBox.Size = new System.Drawing.Size(576, 20);
            this.connectionStringTextBox.TabIndex = 3;
            // 
            // connectionStringLabel
            // 
            this.connectionStringLabel.Location = new System.Drawing.Point(11, 54);
            this.connectionStringLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.connectionStringLabel.Name = "connectionStringLabel";
            this.connectionStringLabel.Size = new System.Drawing.Size(576, 22);
            this.connectionStringLabel.TabIndex = 3;
            this.connectionStringLabel.Text = "Connection string";
            this.connectionStringLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // minimalLogLevelComboBox
            // 
            this.minimalLogLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.minimalLogLevelComboBox.FormattingEnabled = true;
            this.minimalLogLevelComboBox.Location = new System.Drawing.Point(12, 126);
            this.minimalLogLevelComboBox.Name = "minimalLogLevelComboBox";
            this.minimalLogLevelComboBox.Size = new System.Drawing.Size(261, 21);
            this.minimalLogLevelComboBox.TabIndex = 4;
            // 
            // minimalLogLevelLabel
            // 
            this.minimalLogLevelLabel.Location = new System.Drawing.Point(11, 101);
            this.minimalLogLevelLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.minimalLogLevelLabel.Name = "minimalLogLevelLabel";
            this.minimalLogLevelLabel.Size = new System.Drawing.Size(262, 22);
            this.minimalLogLevelLabel.TabIndex = 7;
            this.minimalLogLevelLabel.Text = "Minimal Log Level";
            this.minimalLogLevelLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // logStartAndStopCheckBox
            // 
            this.logStartAndStopCheckBox.AutoSize = true;
            this.logStartAndStopCheckBox.Location = new System.Drawing.Point(12, 153);
            this.logStartAndStopCheckBox.Name = "logStartAndStopCheckBox";
            this.logStartAndStopCheckBox.Size = new System.Drawing.Size(234, 17);
            this.logStartAndStopCheckBox.TabIndex = 8;
            this.logStartAndStopCheckBox.Text = "Log messages sent at startup and shutdown";
            this.logStartAndStopCheckBox.UseVisualStyleBackColor = true;
            // 
            // logRunStartAndStopCheckBox
            // 
            this.logRunStartAndStopCheckBox.AutoSize = true;
            this.logRunStartAndStopCheckBox.Location = new System.Drawing.Point(12, 176);
            this.logRunStartAndStopCheckBox.Name = "logRunStartAndStopCheckBox";
            this.logRunStartAndStopCheckBox.Size = new System.Drawing.Size(286, 17);
            this.logRunStartAndStopCheckBox.TabIndex = 9;
            this.logRunStartAndStopCheckBox.Text = "Log messages sent at the beginning and end of the run";
            this.logRunStartAndStopCheckBox.UseVisualStyleBackColor = true;
            // 
            // logRunBodyCheckBox
            // 
            this.logRunBodyCheckBox.AutoSize = true;
            this.logRunBodyCheckBox.Location = new System.Drawing.Point(12, 199);
            this.logRunBodyCheckBox.Name = "logRunBodyCheckBox";
            this.logRunBodyCheckBox.Size = new System.Drawing.Size(549, 17);
            this.logRunBodyCheckBox.TabIndex = 10;
            this.logRunBodyCheckBox.Text = "Log messages sent during the run (For example, the query being executed or the UR" +
    "L of an HTTP API request)";
            this.logRunBodyCheckBox.UseVisualStyleBackColor = true;
            // 
            // deselectMinimalLogLevelButton
            // 
            this.deselectMinimalLogLevelButton.Location = new System.Drawing.Point(279, 126);
            this.deselectMinimalLogLevelButton.Name = "deselectMinimalLogLevelButton";
            this.deselectMinimalLogLevelButton.Size = new System.Drawing.Size(27, 21);
            this.deselectMinimalLogLevelButton.TabIndex = 11;
            this.deselectMinimalLogLevelButton.Text = "x";
            this.deselectMinimalLogLevelButton.UseVisualStyleBackColor = true;
            this.deselectMinimalLogLevelButton.Click += new System.EventHandler(this.deselectMinimalLogLevelButton_Click);
            // 
            // EditConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.deselectMinimalLogLevelButton);
            this.Controls.Add(this.logRunBodyCheckBox);
            this.Controls.Add(this.logRunStartAndStopCheckBox);
            this.Controls.Add(this.logStartAndStopCheckBox);
            this.Controls.Add(this.minimalLogLevelLabel);
            this.Controls.Add(this.minimalLogLevelComboBox);
            this.Controls.Add(this.connectionStringTextBox);
            this.Controls.Add(this.connectionStringLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.serviceNameTextBox);
            this.Controls.Add(this.serviceNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EditConfiguration";
            this.Text = "EditConfiguration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox minimalLogLevelComboBox;
        private System.Windows.Forms.Label minimalLogLevelLabel;

        private System.Windows.Forms.TextBox connectionStringTextBox;
        private System.Windows.Forms.Label connectionStringLabel;

        private System.Windows.Forms.Button saveButton;

        private System.Windows.Forms.Label serviceNameLabel;
        private System.Windows.Forms.TextBox serviceNameTextBox;

        #endregion

        private System.Windows.Forms.CheckBox logStartAndStopCheckBox;
        private System.Windows.Forms.CheckBox logRunStartAndStopCheckBox;
        private System.Windows.Forms.CheckBox logRunBodyCheckBox;
        private System.Windows.Forms.Button deselectMinimalLogLevelButton;
    }
}