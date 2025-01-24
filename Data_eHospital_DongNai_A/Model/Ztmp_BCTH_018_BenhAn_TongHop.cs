namespace Data_eHospital_DongNai_A.Model
{
    public partial class Ztmp_BCTH_018_BenhAn_TongHop : BaseModel
    {
        [Key]
        public int? BenhAn_Id { get; set; }
public DateTime? NgayVaoVien { get; set; }
public DateTime? ThoiGianVaoVien { get; set; }
public DateTime? NgayRaVien { get; set; }
public DateTime? ThoiGianRaVien { get; set; }
public int? ICD_BenhChinh { get; set; }
public int? KetQuaDieuTri_Id { get; set; }
public string? SoCapCuu { get; set; }
public string? SoBenhAn { get; set; }
public DateTime? ThoiGianTuVong { get; set; }
public DateTime? NgayTiepNhan { get; set; }
public DateTime? ThoiGianTiepNhan { get; set; }
public int? NamSinh { get; set; }
public string? GioiTinh { get; set; }
public int? DoiTuong_Id { get; set; }
public int? KhoaVao_Id { get; set; }
public int? KhoaRa_Id { get; set; }
public int? NoiLap_Id { get; set; }
public int? NgheNghiep_Id { get; set; }
public int? BenhNhan_Id { get; set; }
public int? TinhThanh_Id { get; set; }
public int? QuanHuyen_Id { get; set; }
public int? LyDoXuatVien_Id { get; set; }

        public Ztmp_BCTH_018_BenhAn_TongHop()
        {
        }
    }
}

