namespace Data_eHospital_DongNai_A.Model
{
    public partial class me_PhongBan : BaseModel
    {
        [Key]
        public int? PhongBan_id { get; set; }
public string? SoPhong { get; set; }
public string? TenPhongBan { get; set; }
public int? KhuVuc_id { get; set; }
public int? Mapping_EHOS { get; set; }
public int? STTHienTai { get; set; }
public DateTime? ThoiGianTaoSo { get; set; }
public DateTime? NgayTao { get; set; }
public DateTime? NgaycapNhat { get; set; }

        public me_PhongBan()
        {
        }
    }
}

