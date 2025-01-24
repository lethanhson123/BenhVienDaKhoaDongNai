namespace Data_eHospital_DongNai_A.Model
{
    public partial class NoiTru_ChuyenKhu : BaseModel
    {
        [Key]
        public int? NoiTru_ChuyenKhu_ID { get; set; }
public int? TiepNhan_ID { get; set; }
public int? BenhNhan_ID { get; set; }
public int? BenhAn_ID { get; set; }
public string? SoBenhAn { get; set; }
public int? BacSiChiDinhChuyen_ID { get; set; }
public int? DoiTuongChuyen_ID { get; set; }
public int? KhoaChuyen_ID { get; set; }
public int? LoaiBenhAnChuyen_ID { get; set; }
public int? ICD_Chuyen_ID { get; set; }
public string? NgayChuyen { get; set; }
public DateTime? ThoiGianChuyen { get; set; }
public int? NguoiChuyen_ID { get; set; }
public int? KhoaDen_ID { get; set; }
public int? BacSiDen_ID { get; set; }
public int? BacSiChiDinhNhan_ID { get; set; }
public int? KhoaDieuTri_ID { get; set; }
public int? LoaiBenhAnNhan_ID { get; set; }
public int? NguoiNhan_ID { get; set; }
public string? NgayNhan { get; set; }
public DateTime? ThoiGianNhan { get; set; }
public string? SiteCode { get; set; }
public bool? IsHuy { get; set; }
public string? SoLuuTru { get; set; }
public int? BenhVien_KCB_Id { get; set; }
public int? TuyenKhamBenh_Id { get; set; }
public string? ChanDoan { get; set; }
public decimal? TongTamUng { get; set; }
public decimal? TongChiPhi { get; set; }
public string? SoBHYT { get; set; }
public bool? CoPhatSinhCLS { get; set; }
public bool? CoPhatSinhThuoc { get; set; }
public decimal? TongTienHoTro { get; set; }
public DateTime? NgayLap { get; set; }
public DateTime? ThoiGianLap { get; set; }
public DateTime? NgayVaoVien { get; set; }
public DateTime? ThoiGianVaoVien { get; set; }
public string? ChanDoanKhamBenh { get; set; }
public int? DoiTuongDen_ID { get; set; }

        public NoiTru_ChuyenKhu()
        {
        }
    }
}

