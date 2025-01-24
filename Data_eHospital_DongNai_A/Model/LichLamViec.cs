namespace Data_eHospital_DongNai_A.Model
{
    public partial class LichLamViec : BaseModel
    {
        [Key]
        public int? LichKham_Id { get; set; }
public int? NhanVien_Id { get; set; }
public int? PhongBan_Id { get; set; }
public int? CongViec_Id { get; set; }
public DateTime? NgayBatDau { get; set; }
public DateTime? ThoiGianBatDau { get; set; }
public DateTime? NgayKetThuc { get; set; }
public DateTime? ThoiGianKetThuc { get; set; }
public string? GhiChu { get; set; }
public bool? TamNgung { get; set; }

        public LichLamViec()
        {
        }
    }
}

