namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_DM_DinhSuat : BaseModel
    {
        [Key]
        public int? ID { get; set; }
public string? MaDinhSuat { get; set; }
public string? TenDinhSuat { get; set; }
public string? DonGia { get; set; }
public string? GhiChu { get; set; }

        public NS_DM_DinhSuat()
        {
        }
    }
}

