namespace Data_eHospital_DongNai_A.Model
{
    public partial class ChungTuChiPhi : BaseModel
    {
        [Key]
        public int? ChungTuChiPhi_Id { get; set; }
public int? ChungTu_Id { get; set; }
public int? LoaiPhi_Id { get; set; }
public DateTime? NgayHoaDon { get; set; }
public string? SoSeri { get; set; }
public string? SoHoaDon { get; set; }
public string? Tyle { get; set; }
public string? GiaTri { get; set; }
public string? TienTe_Id { get; set; }
public string? TyGia { get; set; }
public string? GiaTriVND { get; set; }
public string? GhiChu { get; set; }
public int? KhachHang_Id { get; set; }
public decimal? TyLeVAT { get; set; }
public decimal? GiaTriVAT { get; set; }
public decimal? GiaTriSauVAT { get; set; }

        public ChungTuChiPhi()
        {
        }
    }
}

