namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_DM_PHUCAPTRUC : BaseModel
    {
        [Key]
        public int? ID { get; set; }
public string? MaKhoa { get; set; }
public int? TiLeThuong { get; set; }

        public NS_DM_PHUCAPTRUC()
        {
        }
    }
}

