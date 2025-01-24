namespace Data_eHospital_DongNai_A.Model
{
    public partial class ztmp_BCTN_003 : BaseModel
    {
        [Key]
        public string? SoVaoVien { get; set; }
public string? TenBenhNhan { get; set; }
public string? DiaChiBenhNhan { get; set; }
public int? Trai { get; set; }
public int? Gai { get; set; }
public string? ChanDoan1 { get; set; }
public string? TenPhongBan { get; set; }
public string? MaGiuong { get; set; }
public string? MaPhong { get; set; }
public DateTime? NgayVaoVien { get; set; }
public DateTime? NgayRa { get; set; }

        public ztmp_BCTN_003()
        {
        }
    }
}

