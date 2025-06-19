using System;

interface IDocument
{
    void Open();
}

class WordDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Word Document opened.");
    }
}

class PdfDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("PDF Document opened.");
    }
}

class ExcelDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Excel Document opened.");
    }
}

abstract class DocumentFactory
{
    public abstract IDocument CreateDocument();
}

class WordFactory : DocumentFactory
{
    public override IDocument CreateDocument()
    {
        return new WordDocument();
    }
}

class PdfFactory : DocumentFactory
{
    public override IDocument CreateDocument()
    {
        return new PdfDocument();
    }
}

class ExcelFactory : DocumentFactory
{
    public override IDocument CreateDocument()
    {
        return new ExcelDocument();
    }
}

class Program
{
    static void Main(string[] args)
    {
        DocumentFactory wordFactory = new WordFactory();
        IDocument word = wordFactory.CreateDocument();
        word.Open();

        DocumentFactory pdfFactory = new PdfFactory();
        IDocument pdf = pdfFactory.CreateDocument();
        pdf.Open();

        DocumentFactory excelFactory = new ExcelFactory();
        IDocument excel = excelFactory.CreateDocument();
        excel.Open();

        Console.WriteLine("Factory Method Pattern implemented by Ashutosh Dash");
    }
}
