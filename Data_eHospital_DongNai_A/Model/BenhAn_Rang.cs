namespace Data_eHospital_DongNai_A.Model
{
    public partial class BenhAn_Rang : BaseModel
    {
        [Key]
        public int? BenhAn_Rang_Id { get; set; }
public int? BenhAnNgoaiTru_Id { get; set; }
public string? Rang_Code { get; set; }
public int? Value_Id { get; set; }

        public BenhAn_Rang()
        {
        }
    }
}

