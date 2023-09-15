using System;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace InterfaceToXML
{
    public partial class EditConfiguration : Form
    {
        private string filePath;
        private Configuration config = new Configuration();
        private const string directoryPath = @"\configurations";
        XmlConfigurationService configService = new XmlConfigurationService();
        
        public EditConfiguration(string _filePath, Configuration _config)
        {
            // Create all the form components first
            InitializeComponent();
            
            // Fill in combobox with all minimum log levels
            minimalLogLevelComboBox.Items.Add("Debug");
            minimalLogLevelComboBox.Items.Add("Information");
            minimalLogLevelComboBox.Items.Add("Warning");
            minimalLogLevelComboBox.Items.Add("Error");
            minimalLogLevelComboBox.Items.Add("Critical");
            
            // If we're opening a file, fill the existing data into the form
            if (!string.IsNullOrWhiteSpace(_filePath))
            {
                this.filePath = _filePath;
                this.config = _config;
                fillInFormData();
            }

            // Set the button text accordingly
            if (filePath == null)
            {
                saveButton.Text = "Create";
            }
        }

        private void fillInFormData()
        {
            serviceNameTextBox.Text = config.ServiceName;
            connectionStringTextBox.Text = config.ConnectionString;
            minimalLogLevelComboBox.Text = config.logSettings.MinimumLogLevel;
            logStartAndStopCheckBox.Checked = config.logSettings.LogStartAndStop;
            logRunStartAndStopCheckBox.Checked = config.logSettings.LogRunStartAndStop;
            logRunBodyCheckBox.Checked = config.logSettings.LogRunBody;
        }

        private void updateConfig()
        {
            config.ServiceName = serviceNameTextBox.Text;
            config.ConnectionString = connectionStringTextBox.Text;
            config.logSettings.MinimumLogLevel = minimalLogLevelComboBox.Text;
            config.logSettings.LogStartAndStop = logStartAndStopCheckBox.Checked;
            config.logSettings.LogRunStartAndStop = logRunStartAndStopCheckBox.Checked;
            config.logSettings.LogRunBody = logRunBodyCheckBox.Checked;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // Update the config file to have all changes made
            updateConfig();
            
            // See if the mandatory data is filled in, if not tell the user
            if (string.IsNullOrWhiteSpace(config.ServiceName))
            {
                MessageBox.Show("The service name has to be filled in");
                return;
            }

            // TODO: Make a check for atleast one runscheme
            
            
            // Create the new file
            try
            {
                configService.CreateDocument(filePath, directoryPath, config);
            } catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
            if (filePath == null)
            {
                MessageBox.Show("Configuration has been created!");
            }
            else
            {
                MessageBox.Show("Configuration has been updated!");
            }
        }

        private void deselectMinimalLogLevelButton_Click(object sender, EventArgs e)
        {
            minimalLogLevelComboBox.SelectedItem = null;
        }
    }
}