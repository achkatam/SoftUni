namespace P03.DetailPrinter
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using P03.Detail_Printer.Contracts;

    public class Manager : IManager
    {

        public Manager(string name, ICollection<string> documents) 
        {
            this.Name = name;
            this.Documents = new List<string>(documents);
        }

        public IReadOnlyCollection<string> Documents { get; set; }

        public string Name { get; set; }

        public string PrintEmployee()
        {
            var sb = new StringBuilder();

            sb
                .AppendLine(this.Name)
                .AppendLine("Documents:");

            foreach (var item in this.Documents)
            {
                sb.AppendLine(item);
            }

            return sb.ToString().TrimEnd();
        }
    }
}
