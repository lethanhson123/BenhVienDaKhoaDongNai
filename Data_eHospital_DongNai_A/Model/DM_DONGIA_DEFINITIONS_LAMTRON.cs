namespace Data_eHospital_DongNai_A.Model
{
    public partial class DM_DONGIA_DEFINITIONS_LAMTRON : BaseModel
    {
        [Key]
        public int? DONGIA_DEFINITIONS_Tron { get; set; }
public decimal? DonGia { get; set; }
public int? LamTron { get; set; }

        public DM_DONGIA_DEFINITIONS_LAMTRON()
        {
        }
    }
}

