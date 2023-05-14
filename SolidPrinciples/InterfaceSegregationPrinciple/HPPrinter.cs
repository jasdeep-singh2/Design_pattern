namespace InterfaceSegregationPrinciple
{
    public class HPPrinter : IPrintTasks, IFax
    {
        public bool FaxContent(string content)
        {
            throw new NotImplementedException();
        }

        public bool PhotoCopyContent(string content)
        {
            throw new NotImplementedException();
        }

        public bool PrintContent(string content)
        {
            throw new NotImplementedException();
        }

        public bool ScanContent(string content)
        {
            throw new NotImplementedException();
        }
    }
}
