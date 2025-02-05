namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_RP_DSOperator : BaseModel
    {
        [Key]
        public string? Ma { get; set; }
public string? OperatorCode { get; set; }
public string? OperatorName { get; set; }
public string? Type { get; set; }

        public NS_RP_DSOperator()
        {
        }
    }
}

