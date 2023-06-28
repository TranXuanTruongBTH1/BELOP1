using System.ComponentModel.DataAnnotations;

namespace CayLapBu.Models
{
    public class TXTSinhVien
    {
        [Key]
        [Display(Name ="Mã Lớp Học")]
        public int? MaLop {get;set;}
        [Display(Name ="Tên Sinh Viên")]
        public string? TenSV {get;set;}
        [Display(Name ="Mã Sinh Viên")]
        public int? MaSV {get;set;}
        
    }
}