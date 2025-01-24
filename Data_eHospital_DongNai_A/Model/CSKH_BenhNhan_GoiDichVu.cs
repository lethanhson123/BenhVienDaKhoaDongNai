namespace Data_eHospital_DongNai_A.Model
{
    public partial class CSKH_BenhNhan_GoiDichVu : BaseModel
    {
        [Key]
        public int? BenhNhanGoiDichVu_Id { get; set; }
public int? BenhNhan_Id { get; set; }
public int? GoiDichVu_Id { get; set; }
public string? TienTe_Id { get; set; }
public decimal? GiaTriGoiDichVu { get; set; }
public DateTime? NgayDangKy { get; set; }
public DateTime? ThoiGianDangKy { get; set; }
public DateTime? NgayHetHan { get; set; }
public int? NoiDangKy { get; set; }
public bool? DaThuTien { get; set; }
public bool? TamNgung { get; set; }
public bool? HuyGoiDV { get; set; }
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
public decimal? GiaTriThucThu { get; set; }
public decimal? GiaTriMienGiamThe { get; set; }
public int? The_Id { get; set; }
public int? LoaiKhachHang_Id { get; set; }
public decimal? GiaTriMienGiam { get; set; }
public decimal? GiaTriThatThu { get; set; }
public decimal? GiaTriDaThanhToan { get; set; }
public bool? DaThanhToan_MotPhan { get; set; }
public bool? DaThanhToan_HoanTat { get; set; }
public bool? DuocPhepThucHien { get; set; }
public int? TiepNhan_ID { get; set; }
public int? BenhAn_ID { get; set; }
public int? NguoiChiDinh_Id { get; set; }
public int? BenhNhanGoiDichVuChuyen_Id { get; set; }
public int? NhanVienChuyen_Id { get; set; }
public decimal? GiaTriGoiSauKhiChuyen { get; set; }
public decimal? TongGiaTriDichVu { get; set; }
public bool? Khoa { get; set; }
public DateTime? NgayKhoa { get; set; }
public DateTime? ThoiGianKhoa { get; set; }
public int? NguoiKhoa_Id { get; set; }
public string? LyDoKhoa { get; set; }
public bool? isActive { get; set; }
public DateTime? NgayKichHoat { get; set; }
public int? VAT_ID { get; set; }
public int? Vip_Id { get; set; }
public decimal? DonGiaVIP { get; set; }
public decimal? DonGiaVIPChiTra { get; set; }
public decimal? TyLeVip { get; set; }
public int? TapDoan_Id { get; set; }
public decimal? DonGiaTapDoan { get; set; }
public decimal? DonGiaTapDoanChiTra { get; set; }
public decimal? TyLeTapDoan { get; set; }
public int? xacnhanhotrobaohiem_id { get; set; }
public int? xacnhanhotrobaohiemchitiet_id { get; set; }
public decimal? dongiabaohiemhotro { get; set; }
public decimal? ThanhTienBaoHiemHoTro { get; set; }
public int? NguoiHuyKhoa_Id { get; set; }
public DateTime? ThoiGianHuyKhoa { get; set; }

        public CSKH_BenhNhan_GoiDichVu()
        {
        }
    }
}

