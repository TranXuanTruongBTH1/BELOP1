using System.ComponentModel.DataAnnotations;
namespace CayLapBu.Models
{
    public class TXTLopHoc
    {
        [Key]
        [MaxLength(20)]
        [Display(Name ="Mã lớp học")]
        public int? MaLopHoc {get;set;}
        [MaxLength(50)]
        [Display(Name ="Tên lớp học")]
        public string? TenLophoc {get;set;}
    }
}