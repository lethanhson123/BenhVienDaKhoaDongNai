namespace Data_eHospital_DongNai_A.Model
{
    public partial class BienBanHoiChan : BaseModel
    {
        [Key]
        public int? BienBanHoiChan_Id { get; set; }
public int? TiepNhan_Id { get; set; }
public int? CLSYeuCau { get; set; }
public int? BenhNhan_Id { get; set; }
public string? LoaiHoiChan { get; set; }
public string? ChanDoan { get; set; }
public string? TomTat_TienSuBenh { get; set; }
public string? TienCan { get; set; }
public string? KhamLamSang { get; set; }
public string? KPS { get; set; }
public string? TinhTrang { get; set; }
public string? GPB { get; set; }
public string? HinhAnhHoc { get; set; }
public string? TumorMarker { get; set; }
public int? CachXuTri { get; set; }
public string? GiaiDoan { get; set; }
public string? ChanDoan_TuyenDuoi { get; set; }
public string? TomTat_DienBienBenh { get; set; }
public string? BenhSu { get; set; }
public string? HuongXuTri { get; set; }
public string? ChamSoc { get; set; }
public string? KetLuan { get; set; }
public DateTime? NgayHoiChan { get; set; }
public DateTime? ThoiGianDuTinhPT { get; set; }
public DateTime? ThoiGianHenNhapVien { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public string? SoPhieuHoiChan { get; set; }
public int? LoaiHoiChan_Id { get; set; }
public int? BenhAn_Id { get; set; }
public int? LuuTru_Id { get; set; }
public int? PhongBan_Id { get; set; }
public int? BacSi_Id { get; set; }
public int? LyDoHoiChan_Id { get; set; }
public int? HinhThucHoiChan_Id { get; set; }
public string? YeuCauHoiChan { get; set; }
public DateTime? ThoiGianHoiChan { get; set; }
public int? PhatDo_DieuTri_Id { get; set; }

        public BienBanHoiChan()
        {
        }
    }
}

