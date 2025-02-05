namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_DM_TRINHDO : BaseModel
    {
        [Key]
        public string? MaTrinhdo { get; set; }
public string? TenTrinhDo { get; set; }
public int? TrinhDo_Id { get; set; }

        public NS_DM_TRINHDO()
        {
        }
    }
}

