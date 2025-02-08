using Domain.DevelopingEntities;
using Domain.Entities.Common;
using Domain.Entities.Common.Interface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities;

public class Transaction : TimeStampTracking, IResponse<int>
{
    [Key]
    public int Id { get; set; }
    public decimal? Amount { get; set; }
    public string? CreatedBy { get; set; }
    /// <summary>
    /// Nếu transaction này thuộc vào invoice thì khác null và ngược lại
    /// </summary>
    public int? InvoiceId { get; set; }
    /// <summary>
    /// Nếu transaction này thuộc vào Receipt nào đó thì khác null và ngược lại
    /// </summary>
    public int? ReceiptId { get; set; }

    public int? ReservationRoomId { get; set; }
    public int? TransactionCategoryId { get; set; }
    public bool? IsRefundOrPayment { get; set; }
    public int? PaymentMethodId { get; set; }
    public string? Note { get; set; }

    [ForeignKey(nameof(PaymentMethodId))]
    public virtual PaymentMethod? PaymentMethod { get; set; }

    [ForeignKey(nameof(InvoiceId))]
    public virtual Invoice? Invoice { get; set; }

    [ForeignKey(nameof(ReservationRoomId))]
    public virtual ReservationRoom? ReservationRoom { get; set; }

    [ForeignKey(nameof(CreatedBy))]
    public virtual Staff? Staff { get; set; }

    [ForeignKey(nameof(TransactionCategoryId))]
    public virtual TransactionCategory? TransactionCategory { get; set; }

    [ForeignKey(nameof(ReceiptId))]
    public virtual Receipt? Receipt { get; set; }
}
