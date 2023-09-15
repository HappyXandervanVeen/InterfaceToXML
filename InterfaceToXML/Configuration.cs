namespace InterfaceToXML
{
    public class Configuration
    {
        public string ServiceName { get; set; }
        public string ConnectionString { get; set; }
        public LogSettings logSettings { get; set; }

        public Configuration()
        {
            logSettings = new LogSettings();
        }
    }
}