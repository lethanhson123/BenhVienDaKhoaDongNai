namespace Data_eHospital_DongNai_A.Model
{
    public partial class DM_CDT_Loai : BaseModel
    {
        [Key]
        public int? CDT_Loai_Id { get; set; }
public string? MaLoaiCDT { get; set; }
public string? TenLoaiCDT { get; set; }
public int? STT { get; set; }
public int? Cap { get; set; }
public int? CapTren_Id { get; set; }
public bool? TamNgung { get; set; }
public int? NguoiTao_ID { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }

        public DM_CDT_Loai()
        {
        }
    }
}

