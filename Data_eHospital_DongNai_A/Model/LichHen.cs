namespace Data_eHospital_DongNai_A.Model
{
    public partial class LichHen : BaseModel
    {
        [Key]
        public int? LichHen_Id { get; set; }
public string? MaLichHen { get; set; }
public int? KhamBenh_Id { get; set; }
public int? BenhAn_Id { get; set; }
public int? BenhNhan_Id { get; set; }
public DateTime? NgayHen_BatDau { get; set; }
public DateTime? ThoiGianHen_BatDau { get; set; }
public DateTime? NgayHen_KetThuc { get; set; }
public DateTime? ThoiGianHen_KetThuc { get; set; }
public int? PhongBan_Id { get; set; }
public int? BacSi_Id { get; set; }
public int? DichVu_Id { get; set; }
public int? TrangThai_Id { get; set; }
public int? LoaiCuocHen_Id { get; set; }
public int? NguonHen_Id { get; set; }
public int? ThucHien_id { get; set; }
public int? NhanVienHen_Id { get; set; }
public int? NhanVienThayDoi_Id { get; set; }
public DateTime? NgayThayDoi { get; set; }
public string? GhiChu { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public int? TiepNhan_Id { get; set; }
public int? LichHen_Old { get; set; }
public int? LichHen_Prev { get; set; }
public DateTime? NgayTaoCuocHen { get; set; }
public int? TiepNhanThucHien_Id { get; set; }
public bool? GuiSMS { get; set; }
public int? SoNgayGuiTruoc { get; set; }
public int? LichMo_id { get; set; }
public int? xeplichmo_ekipmo_id { get; set; }
public int? KhuHen_Id { get; set; }
public int? GoiDichVu_id { get; set; }
public int? HopDong_Id { get; set; }
public int? CongTy_id { get; set; }
public int? NhanVienThucHien_Id { get; set; }
public DateTime? ThoiGianThucHien { get; set; }
public DateTime? TGnhapvien { get; set; }
public int? NoiNhapVien { get; set; }
public string? ChanDoan { get; set; }
public bool? LichHenDichDanhBacSi { get; set; }
public string? MucDichHen { get; set; }
public string? LyDoThayDoi { get; set; }
public string? GhiChuThayDoi { get; set; }

        public LichHen()
        {
        }
    }
}

