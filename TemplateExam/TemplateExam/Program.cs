// See https://aka.ms/new-console-template for more information
using TemplateExam.BasicExample;

Console.WriteLine("Hello, World!");
//Data Process
DataExport dataExport = new ExcelExport();
dataExport.ReadData();
dataExport.ProcessData();

DataExport dataExport2 = new CsvExport();
dataExport2.ReadData();
dataExport2.ExportData();