namespace Data_eHospital_DongNai_A.Model
{
    public partial class BenhAnSanKhoa_ChiTiet : BaseModel
    {
        [Key]
        public int? BenhAnSanKhoa_ChiTiet_Id { get; set; }
public int? BenhAn_Id { get; set; }
public int? SoLanCoThai { get; set; }
public int? Nam { get; set; }
public bool? DeDuThang { get; set; }
public bool? DeThieuThang { get; set; }
public decimal? CanNang { get; set; }
public string? GioiTinh { get; set; }
public bool? NgatSauSinh { get; set; }
public bool? TreChetKhiSinh { get; set; }
public bool? ThaiChetTu22Tuan { get; set; }
public bool? ThaiChetLuu { get; set; }
public string? GhiChu { get; set; }
public string? LyDoSoSinhChet { get; set; }
public DateTime? NgaySinh { get; set; }
public bool? VitaminK { get; set; }
public bool? ViemGanB { get; set; }

        public BenhAnSanKhoa_ChiTiet()
        {
        }
    }
}

