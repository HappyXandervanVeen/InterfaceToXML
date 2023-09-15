using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace InterfaceToXML
{
    public partial class Form1 : Form
    {
        private const string directoryPath = @"\configurations";
        XmlConfigurationService configService = new XmlConfigurationService();
        
        public Form1()
        {
            InitializeComponent();
            
            // When the configurations folder doesn't exist, create one so we can put the configs in there
            if (!Directory.Exists(Directory.GetCurrentDirectory() + directoryPath))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + directoryPath);
            }

            updateConfigsListBox();
        }
        
        private void configListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If nothing is selected, cancel action
            if (configListBox.SelectedIndex == -1)
            {
                // Disable the select config button
                selectButton.Enabled = false;
                return;
            } 
            else
            {
                // Enable the select button
                selectButton.Enabled = true;
            }
        }

        private void updateConfigsListBox()
        {
            // Remove all current items in listbox
            configListBox.Items.Clear();
            
            // Add the paths to the listBox
            foreach (configListBoxItem config in getAllConfigs())
            {
                configListBox.Items.Add(config);
            }
        }

        private List<configListBoxItem> getAllConfigs()
        {
            // Get all configuration files and show them in the list
            List<configListBoxItem> configurations = new List<configListBoxItem>();
            string[] files  = Directory.GetFiles(Directory.GetCurrentDirectory() + directoryPath);
            foreach (string filePath in files)
            {
                try
                {
                    XDocument configuration = XDocument.Load(filePath);
                    string serviceName = configuration
                        .Descendants("ServiceName")
                        .Single().Value;
                    configurations.Add(new configListBoxItem(serviceName, filePath));
                }
                catch (Exception ex)
                {
                    // Any exception here indicates that the file isn't correctly
                    // formatted like an xml file should. Ignore these files
                }
            }
            return configurations;
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            // Get the selected config
            configListBoxItem selectedItem = (configListBoxItem)configListBox.SelectedItem;
            
            // Get the file
            XDocument configDocument = XDocument.Load(selectedItem.path);
            
            // Convert XDocument to Configuration
            Configuration config = configService.ConvertFromXml(configDocument);
            
            // Send the config and the path to the next form
            this.Hide(); // Hide the current form
            EditConfiguration editForm = new EditConfiguration(selectedItem.path, config); // Create the new form
            editForm.Closed += (s, args) => this.Close(); // When opened form is closed also close the hidden form
            editForm.Show(); // Show the new form
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide the current form
            EditConfiguration editForm = new EditConfiguration(null, null); // Create the new form
            editForm.Closed += (s, args) => this.Close(); // When opened form is closed also close the hidden form
            editForm.Show(); // Show the new form
        }
    }
}