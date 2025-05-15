

namespace TemplateExam.BasicExample
{
    public abstract class DataExport
    {
        protected DataExport()
        {
            ReadData();
            ProcessData();
            ExportData();
        }
        public abstract void ReadData();
        public virtual void ProcessData()
        {
            Console.WriteLine("Processing data...");
        }
        public virtual void ExportData()
        {
            Console.WriteLine("Exporting data...");
        }
    }

    public class ExcelExport : DataExport
    {
        public override void ReadData()
        {
            Console.WriteLine("Reading data from Excel file...");
        }
        public override void ExportData()
        {
            Console.WriteLine("Exporting data to Excel file...");
        }
    }
    public class CsvExport : DataExport
    {
        public override void ReadData()
        {
            Console.WriteLine("Reading data from CSV file...");
        }
        public override void ExportData()
        {
            Console.WriteLine("ExportData data to CSV file...");
        }
    }
}
