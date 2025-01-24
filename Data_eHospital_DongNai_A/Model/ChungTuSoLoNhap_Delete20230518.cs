namespace Data_eHospital_DongNai_A.Model
{
    public partial class ChungTuSoLoNhap_Delete20230518 : BaseModel
    {
        [Key]
        public int? SoLoNhap_Id { get; set; }
public string? SoLoNhap { get; set; }
public int? Duoc_Id { get; set; }
public DateTime? NgayNhap { get; set; }
public DateTime? HanSuDung { get; set; }
public int? NguonDuoc_Id { get; set; }
public string? DonGiaMua { get; set; }
public string? DonGiaVon { get; set; }
public string? TienTe_Id { get; set; }
public string? TyGia { get; set; }
public int? Thang { get; set; }
public int? Nam { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public string? SoKiemSoat { get; set; }
public string? SoVisa { get; set; }
public int? NguonHang_Id { get; set; }
public decimal? DonGiaThau { get; set; }
public decimal? TyLeVAT { get; set; }
public decimal? DonGiaBanTruocVAT { get; set; }
public decimal? DonGiaBanSauVAT { get; set; }
public string? MaThongTu { get; set; }
public string? MaQuyetDinh { get; set; }
public string? SoNamHopDong { get; set; }

        public ChungTuSoLoNhap_Delete20230518()
        {
        }
    }
}

