using DesignPatternChallenge;
using ReportGenerator.Interfaces;
using ReportGenerator.Models;
using SalesReport = ReportGenerator.Models.SalesReport;

namespace ReportGenerator.Builders;

public class SalesReportBuilder : ISalesReportBuilder
{
    private readonly SalesReport _salesReport = new SalesReport();
    public SalesReport Build() => _salesReport;
    
    public ISalesReportBuilder WithTitle(string title)
    {
        _salesReport.Title = title;
        return this;
    }

    public ISalesReportBuilder WithFormat(string format)
    {
        _salesReport.Format = format;
        return this;
    }

    public ISalesReportBuilder WithStartDate(DateTime date)
    {
        _salesReport.StartDate = date;
        return this;
    }

    public ISalesReportBuilder WithEndDate(DateTime date)
    {
        _salesReport.EndDate = date;
        return this;
    }

    public ISalesReportBuilder WithHeader(string headerText)
    {
        _salesReport.IncludeFooter = true;
        _salesReport.HeaderText = headerText;
        return this;
    }

    public ISalesReportBuilder WithFooter(string footerText)
    {
        _salesReport.IncludeFooter = true;
        _salesReport.FooterText = footerText;
        return this;
    }

    public ISalesReportBuilder WithChartType(string chartType)
    {
        _salesReport.IncludeCharts = true;
        _salesReport.ChartType = chartType;
        return this;
    }

    public ISalesReportBuilder WithColumns(List<string> columns)
    {
        _salesReport.Columns.AddRange(columns);
        return this;
    }

    public ISalesReportBuilder WithFilters(List<string> filters)
    {
        _salesReport.Filters.AddRange(filters);
        return this;
    }

    public ISalesReportBuilder WithSortBy(string sortBy)
    {
        _salesReport.SortBy = sortBy;
        return this;
    }

    public ISalesReportBuilder WithIncludeTotals(bool includeTotals)
    {
        _salesReport.IncludeTotals = includeTotals;
        return this;
    }

    public ISalesReportBuilder WithOrientation(string orientation)
    {
        _salesReport.Orientation = orientation;
        return this;
    }

    public ISalesReportBuilder WithPageSize(string pageSize)
    {
        _salesReport.PageSize = pageSize;
        return this;
    }

    public ISalesReportBuilder WithCompanyLogo(string companyLogo)
    {
        _salesReport.CompanyLogo = companyLogo;
        return this;
    }

    public ISalesReportBuilder WithWaterMark(string waterMark)
    {
        _salesReport.WaterMark = waterMark;
        return this;
    }
    
}