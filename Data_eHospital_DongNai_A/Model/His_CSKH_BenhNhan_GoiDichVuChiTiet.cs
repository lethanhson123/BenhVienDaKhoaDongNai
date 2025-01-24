namespace Data_eHospital_DongNai_A.Model
{
    public partial class His_CSKH_BenhNhan_GoiDichVuChiTiet : BaseModel
    {
        [Key]
        public int? History_id { get; set; }
public int? BenhNhanGoiDichVuChiTiet_Id { get; set; }
public int? BenhNhan_Id { get; set; }
public int? GoiDichVu_Id { get; set; }
public int? DichVu_Id { get; set; }
public int? BenhNhanGoiDichVu_Id { get; set; }
public decimal? DonGiaDichVu { get; set; }
public DateTime? NgayThucHien { get; set; }
public DateTime? ThoiGianThucHien { get; set; }
public string? TienTe_Id { get; set; }
public int? SoLanSuDungDichVuTieuChuan { get; set; }
public int? SoLanSuDungDichVu { get; set; }
public int? SoLanSuDungDichVuConLai { get; set; }
public string? GhiChu { get; set; }
public int? GoiDichVuChiTiet_Id { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public decimal? Attribute1 { get; set; }
public decimal? Attribute2 { get; set; }
public int? Attribute3 { get; set; }
public int? Attribute4 { get; set; }
public DateTime? Attribute5 { get; set; }
public DateTime? Attribute6 { get; set; }
public string? Attribute7 { get; set; }
public string? Attribute8 { get; set; }
public bool? Attribute9 { get; set; }
public bool? Attribute10 { get; set; }
public decimal? SoLuong { get; set; }
public int? LuuTruChiTiet_Id { get; set; }
public int? QuanHe { get; set; }
public decimal? DonGiaDichVuTrongGoi { get; set; }
public decimal? PhanTram { get; set; }
public decimal? SoLuongSauKhiChuyen { get; set; }
public bool? IsTuChoi { get; set; }
public DateTime? NgayTuChoi { get; set; }
public DateTime? ThoiGianTuChoi { get; set; }
public int? NguoiTuChoi_Id { get; set; }
public bool? FollowUp { get; set; }
public int? NhanVien_FollowUp_Id { get; set; }
public DateTime? Ngay_FollowUp { get; set; }
public DateTime? ThoiGian_FollowUp { get; set; }
public int? IDChuyen { get; set; }

        public His_CSKH_BenhNhan_GoiDichVuChiTiet()
        {
        }
    }
}

