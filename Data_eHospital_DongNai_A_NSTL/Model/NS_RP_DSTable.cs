namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_RP_DSTable : BaseModel
    {
        [Key]
        public string? Ma { get; set; }
public string? Vietnamese { get; set; }
public int? SapXep { get; set; }

        public NS_RP_DSTable()
        {
        }
    }
}

