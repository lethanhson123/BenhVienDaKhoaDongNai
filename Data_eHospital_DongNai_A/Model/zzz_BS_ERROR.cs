namespace Data_eHospital_DongNai_A.Model
{
    public partial class zzz_BS_ERROR : BaseModel
    {
        [Key]
        public string? SoVaoVien { get; set; }
public string? TenBenhNhan { get; set; }
public string? LoaiKCB { get; set; }
public DateTime? NgayVao { get; set; }
public DateTime? NgayRa { get; set; }

        public zzz_BS_ERROR()
        {
        }
    }
}

