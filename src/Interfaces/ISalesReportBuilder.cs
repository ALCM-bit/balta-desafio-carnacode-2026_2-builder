using ReportGenerator.Models;

namespace ReportGenerator.Interfaces;

public interface ISalesReportBuilder
{
    ISalesReportBuilder  WithTitle(string title);
    ISalesReportBuilder  WithFormat(string format);
    ISalesReportBuilder  WithStartDate(DateTime date);
    ISalesReportBuilder  WithEndDate(DateTime date);
    ISalesReportBuilder  WithHeader(string headerText);
    ISalesReportBuilder  WithFooter(string footerText);
    ISalesReportBuilder  WithChartType(string chartType);
    ISalesReportBuilder  WithColumns(List<string> columns);
    ISalesReportBuilder  WithFilters(List<string> filters);
    ISalesReportBuilder  WithSortBy(string sortBy);
    ISalesReportBuilder  WithIncludeTotals(bool includeTotals);
    ISalesReportBuilder  WithOrientation(string orientation);
    ISalesReportBuilder  WithPageSize(string pageSize);
    ISalesReportBuilder  WithCompanyLogo(string companyLogo);
    ISalesReportBuilder  WithWaterMark(string waterMark);
    SalesReport Build();
    
}