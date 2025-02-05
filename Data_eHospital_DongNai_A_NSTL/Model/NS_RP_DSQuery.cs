namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_RP_DSQuery : BaseModel
    {
        [Key]
        public string? Ma { get; set; }
public string? Clause { get; set; }

        public NS_RP_DSQuery()
        {
        }
    }
}

