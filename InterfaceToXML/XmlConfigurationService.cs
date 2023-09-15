using System;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Linq;

namespace InterfaceToXML
{
    public class XmlConfigurationService
    {
        public Configuration ConvertFromXml(XDocument xdoc)
        {
            if (xdoc == null)
            {
                throw new ArgumentNullException(nameof(XmlDocument));
            }

            // Check if the document has a root element
            XElement rootElement = xdoc.Root;
            if (rootElement == null)
            {
                throw new ArgumentException("XML document does not have a root element.");
            }

            // Grab all the data from the XML file
            string serviceName = rootElement.Element("ServiceName")?.Value;
            string connectionString = rootElement.Element("ConnectionString")?.Value;
            LogSettings logSettings = new LogSettings
            {
                MinimumLogLevel = rootElement.Element("LogSettings")?.Element("LogMinimumLevel")?.Value,
                LogStartAndStop = Convert.ToBoolean(rootElement.Element("LogSettings")?.Element("LogStartAndStop")?.Value),
                LogRunStartAndStop = Convert.ToBoolean(rootElement.Element("LogSettings")?.Element("LogRunStartAndStop")?.Value),
                LogRunBody = Convert.ToBoolean(rootElement.Element("LogSettings")?.Element("LogRunBody")?.Value)
            };

            // Check if all necessary data is filled in (ServiceName and at least 1 run-scheme are mandatory)
            if (string.IsNullOrWhiteSpace(serviceName))
            {
                throw new ArgumentException("ServiceName element not found or it is empty in the XML.");
            }

            return new Configuration
            {
                ServiceName = serviceName,
                ConnectionString = connectionString,
                logSettings = logSettings
            };
        }
        
        public bool CreateDocument(string filePath, string directoryPath, Configuration config)
        {
            // If no filePath was given, create a new filePath
            if (string.IsNullOrWhiteSpace(filePath))
            {
                // Create a new file
                // Set the directory and file name
                filePath = Path.Combine(Directory.GetCurrentDirectory() + directoryPath,
                    FormatFileName(config.ServiceName) + ".xml");
            }

            // Create settings for the xmlWriter
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "    ",
                NewLineChars = "\n",
                NewLineHandling = NewLineHandling.Replace
            };
            
            // Create the file and XmlWriter
            using (XmlWriter writer = XmlWriter.Create(filePath, settings))
            {
                // Start writing the document
                writer.WriteStartDocument();
                writer.WriteStartElement("Configuration");
            
                // Mandatory
                writer.WriteStartElement("ServiceName");
                writer.WriteString(config.ServiceName);
                writer.WriteEndElement();

                if (!string.IsNullOrWhiteSpace(config.ConnectionString))
                {
                    writer.WriteStartElement("ConnectionString");
                    writer.WriteString(config.ConnectionString);
                    writer.WriteEndElement();
                }

                // LogSettings
                writer.WriteStartElement("LogSettings");
                if (!string.IsNullOrWhiteSpace(config.logSettings.MinimumLogLevel))
                {
                    writer.WriteStartElement("LogMinimumLevel");
                    writer.WriteString(config.logSettings.MinimumLogLevel);
                    writer.WriteEndElement();
                }
                writer.WriteStartElement("LogStartAndStop");
                writer.WriteString(config.logSettings.LogStartAndStop.ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("LogRunStartAndStop");
                writer.WriteString(config.logSettings.LogRunStartAndStop.ToString());
                writer.WriteEndElement();

                writer.WriteStartElement("LogRunBody");
                writer.WriteString(config.logSettings.LogRunBody.ToString());
                writer.WriteEndElement();

                writer.WriteEndElement();
                // End LogSettings

                writer.WriteEndDocument();
                writer.Close();
            }
            
            return true;
        }
        
        public void ChangeDocument(string filePath, Configuration config)
        {
            // Get the XML File
            XDocument xdoc = XDocument.Load(filePath);
            
            // Find the element
            XElement serviceNameElement = xdoc
                .Descendants("ServiceName")
                .Single();
            
            // Modify the elements value
            serviceNameElement.SetValue(config.ServiceName);
            
            // Save the changes into the same file that was opened
            xdoc.Save(filePath);
        }
        
        public string FormatFileName(string input)
        {
            // Trim spaces before and after
            input = input.Trim();
            
            // Replace any character that filename doesn't allow
            foreach (char c in System.IO.Path.GetInvalidFileNameChars ())
            {
                input = input.Replace (c, '_');
            }

            // Return the string
            return input;
        }
    }
}