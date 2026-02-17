using ReportGenerator.Builders;

var builder = new SalesReportBuilder();

var pdfReport = builder
    .WithFormat("PDF")
    .WithHeader("Vendas PDF")
    .WithEndDate(new DateTime(2020, 01, 03))
    .WithStartDate(new DateTime(2020, 01, 01))
    .WithColumns(["Produto", "Valor"])
    .Build();

pdfReport.Generate();
    