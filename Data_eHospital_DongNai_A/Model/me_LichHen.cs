namespace Data_eHospital_DongNai_A.Model
{
    public partial class me_LichHen : BaseModel
    {
        [Key]
        public int? LichHen_id { get; set; }
public DateTime? NgayHen { get; set; }
public string? PhieuHen { get; set; }
public int? BenhNhan_id { get; set; }
public string? GhiChu { get; set; }
public int? NoiTao_id { get; set; }
public int? NguoiTao_id { get; set; }
public string? NgayTao { get; set; }
public DateTime? ThoiGianTao { get; set; }
public int? NoiCapNhat_id { get; set; }
public int? NguoiCapNhat_id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public bool? IsLocked { get; set; }

        public me_LichHen()
        {
        }
    }
}

