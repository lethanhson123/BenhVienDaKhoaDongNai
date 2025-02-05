namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_DM_LyDoNghiViec : BaseModel
    {
        [Key]
        public string? MaLyDoNghi { get; set; }
public string? TenLyDoNghi { get; set; }

        public NS_DM_LyDoNghiViec()
        {
        }
    }
}

