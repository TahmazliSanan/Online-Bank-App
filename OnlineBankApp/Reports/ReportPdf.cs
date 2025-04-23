using OnlineBankApp.Dtos;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

namespace OnlineBankApp.Reports
{
    public class ReportPdf : IDocument
    {
        public List<ReportDto> Transactions { get; } = null!;

        public ReportPdf(List<ReportDto> transactions)
        {
            Transactions = transactions;
        }

        public void Compose(IDocumentContainer container)
        {
            container.Page(page =>
            {
                page.Margin(30);
                page.Size(PageSizes.A4);
                page.DefaultTextStyle(x => x.FontSize(12));

                page.Header().Border(1).PaddingBottom(20)
                .Text($"{AppSession.LoggedInUser!.Username.ToUpper()} - TRANSACTION REPORT")
                .FontSize(20).Bold().AlignCenter();

                page.Content().Table(table =>
                {
                    table.ColumnsDefinition(columns =>
                    {
                        columns.RelativeColumn(2);
                        columns.RelativeColumn(2);
                        columns.RelativeColumn(1);
                        columns.RelativeColumn(2);
                    });

                    table.Header(header =>
                    {
                        header.Cell().Background(Colors.Black).Border(1)
                        .Text("From Card").FontColor(Colors.White).Bold().AlignCenter();
                        
                        header.Cell().Background(Colors.Black).Border(1)
                        .Text("To Card").FontColor(Colors.White).Bold().AlignCenter();
                        
                        header.Cell().Background(Colors.Black).Border(1)
                        .Text("Transaction Type").FontColor(Colors.White).Bold().AlignCenter();
                        
                        header.Cell().Background(Colors.Black).Border(1)
                        .Text("Date").FontColor(Colors.White).Bold().AlignCenter();
                    });

                    foreach (var transaction in Transactions)
                    {
                        table.Cell().Border(1).Text(transaction.SenderCardNumber ?? "-").AlignCenter();
                        table.Cell().Border(1).Text(transaction.ReceiverCardNumber ?? "-").AlignCenter();
                        table.Cell().Border(1).Text(transaction.TransactionType.ToString()).AlignCenter();
                        table.Cell().Border(1).Text(transaction.ProcessedDate.ToString()).AlignCenter();
                    }
                });

                page.Footer().AlignCenter().Text(text =>
                {
                    text.Span("Generated on ");
                    text.Span(DateTime.Now.ToString()).Bold();
                });
            });
        }
    }
}
