namespace Data_eHospital_DongNai_A.Model
{
    public partial class CLSKetQua_VTYT : BaseModel
    {
        [Key]
        public int? CLSKetQua_VTYT_Id { get; set; }
public int? CLSKetQua_Id { get; set; }
public int? Duoc_Id { get; set; }
public string? SoLuong { get; set; }
public int? LoaiGia_Id { get; set; }
public string? DonGiaPhaiThu { get; set; }
public string? DonGia { get; set; }
public string? TyLeVAT { get; set; }
public string? GiaTriVAT { get; set; }
public string? TienTe_Id { get; set; }
public string? TyGia { get; set; }
public int? ChungTu_Id { get; set; }
public string? GhiChu { get; set; }
public int? ChungTuTongHop_Id { get; set; }
public int? KhoSuDung_Id { get; set; }
public bool? TinhTien { get; set; }
public DateTime? NgaySuDung { get; set; }
public DateTime? ThoiGianSuDung { get; set; }
public int? NguonHang_Id { get; set; }
public int? PhieuLinh_Id { get; set; }

        public CLSKetQua_VTYT()
        {
        }
    }
}

