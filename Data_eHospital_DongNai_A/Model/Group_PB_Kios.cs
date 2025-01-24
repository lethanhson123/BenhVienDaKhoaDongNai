namespace Data_eHospital_DongNai_A.Model
{
    public partial class Group_PB_Kios : BaseModel
    {
        [Key]
        public int? Group_PB_Kios_Id { get; set; }
public string? MaGroup { get; set; }
public string? TenGroup { get; set; }

        public Group_PB_Kios()
        {
        }
    }
}

