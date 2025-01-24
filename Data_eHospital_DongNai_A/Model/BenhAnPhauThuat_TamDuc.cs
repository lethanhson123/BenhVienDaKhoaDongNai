namespace Data_eHospital_DongNai_A.Model
{
    public partial class BenhAnPhauThuat_TamDuc : BaseModel
    {
        [Key]
        public int? BenhAnPhauThuat_Id { get; set; }
public int? CLSYeuCau_Id { get; set; }
public int? TiepNhan_Id { get; set; }
public int? BenhAn_Id { get; set; }
public int? LuuTru_Id { get; set; }
public string? SoPhieuPhauThuat { get; set; }
public string? Loai { get; set; }
public int? PhanNhom_Id { get; set; }
public int? Loai_Id { get; set; }
public int? ChanDoan_Id { get; set; }
public DateTime? NgayThucHien { get; set; }
public DateTime? ThoiGianBatDau { get; set; }
public DateTime? ThoiGianKetThuc { get; set; }
public int? ICD_VaoKhoa { get; set; }
public string? ICD_VaoKhoa_MoTa { get; set; }
public int? ICD_TruocPhauThuat { get; set; }
public string? ICD_TruocPhauThuat_MoTa { get; set; }
public int? ICD_SauPhauThuat { get; set; }
public string? ICD_SauPhauThuat_MoTa { get; set; }
public int? DichVu_Id { get; set; }
public int? PhuongPhap_Id { get; set; }
public int? PhuongPhapVoCam_Id { get; set; }
public int? TaiBien_Id { get; set; }
public int? CheDo_Id { get; set; }
public int? TuVong_Id { get; set; }
public string? TrinhTuThucHien { get; set; }
public string? MoTa { get; set; }
public string? KetQua { get; set; }
public int? LoaiGia_Id { get; set; }
public string? DonGiaPhaiThu { get; set; }
public string? TyleVAT { get; set; }
public string? GiaTriVAT { get; set; }
public decimal? SoTien { get; set; }
public string? LoaiTien_Id { get; set; }
public decimal? TyGia { get; set; }
public bool? BenhNhanBenNgoai { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public int? NguonBenh_Id { get; set; }
public int? PhongBanThucHien_Id { get; set; }
public string? DanLuu { get; set; }
public DateTime? NgayRut { get; set; }
public DateTime? NgayCatChi { get; set; }
public string? Khac { get; set; }
public int? KyThuat_Id { get; set; }
public string? GhiChu { get; set; }
public int? TuDienKetQua_Id { get; set; }
public bool? MoLai { get; set; }

        public BenhAnPhauThuat_TamDuc()
        {
        }
    }
}

