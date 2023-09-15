namespace InterfaceToXML
{
    public class configListBoxItem
    {
        public string serviceName { get; set; }
        public string path { get; set; }

        public configListBoxItem(string serviceName, string path)
        {
            this.serviceName = serviceName;
            this.path = path;
        }

        public override string ToString()
        {
            return serviceName;
        }
    }
}