namespace InterfaceSegregationPrinciple
{
    public interface IPrintTasks
    {
        bool PrintContent(string content);
        bool ScanContent(string content);
        bool PhotoCopyContent(string content);

        /// <summary>
        /// There is a possibility that all printer doesnot support the FaxContnent Tasks and Print Duplex Content
        /// task in that case we need to implement Fax Content and Print Duplex job irrespective of the printer doesnot 
        /// support the the Fax Content and Print Duplex Content Task to solve this problem the inteface segregation principle
        /// comes handy, where we put the common functionality in one interface and other non common task should be put in
        /// other interface
        /// </summary>

        //bool FaxContent(string content);
        //bool PrintDuplexContent(string content);
    }

    public interface IFax
    {
        bool FaxContent(string content);
    }

    public interface IPrintDuplex 
    {
        bool PrintDuplexContent(string content);
    }
}
