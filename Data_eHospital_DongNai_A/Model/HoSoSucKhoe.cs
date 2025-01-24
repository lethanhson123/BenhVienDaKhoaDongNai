namespace Data_eHospital_DongNai_A.Model
{
    public partial class HoSoSucKhoe : BaseModel
    {
        [Key]
        public int? HoSoSucKhoe_Id { get; set; }
public int? BenhNhan_Id { get; set; }
public string? SoHoSoSucKhoe { get; set; }
public string? KyHieuDonViCongTac { get; set; }
public int? NhomBenhQuanLy_Id { get; set; }
public string? NhomBenhQuanLy_Code { get; set; }
public DateTime? NgayLapHoSo { get; set; }
public int? NguoiLapHoSo_Id { get; set; }
public int? NgheNghiep_Id { get; set; }
public string? TinhChatNgheNghiep { get; set; }
public string? NgheNghiepCu { get; set; }
public DateTime? NgheNghiepCu_TuNgay { get; set; }
public DateTime? NgheNghiepCu_DenNgay { get; set; }
public int? TrinhDo_Id { get; set; }
public int? ChucVu_Id { get; set; }
public decimal? LuongChinh { get; set; }
public DateTime? NgayVaoBienChe { get; set; }
public DateTime? NgayBatDauLamViec { get; set; }
public string? BenhSu { get; set; }
public string? TienSuDiUng { get; set; }
public string? TienSuThuocLa { get; set; }
public string? DiaChi { get; set; }
public string? CachXaNoiLam { get; set; }
public bool? CoGiaDinh { get; set; }
public int? SoCon { get; set; }
public int? SoNguoiTrongGiaDinh { get; set; }
public decimal? ThuNhapBinhQuan { get; set; }
public string? NhaLoai { get; set; }
public decimal? DienTichDauNguoi { get; set; }
public bool? BenhTruyenNhiem { get; set; }
public bool? BenhXaHoi { get; set; }
public string? BenhGiaDinh { get; set; }
public string? GhiChu { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public HoSoSucKhoe()
        {
        }
    }
}

