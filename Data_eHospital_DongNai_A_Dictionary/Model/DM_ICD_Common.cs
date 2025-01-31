namespace Data_eHospital_DongNai_A_Dictionary.Model
{
    public partial class DM_ICD_Common : BaseModel
    {
        [Key]
        public int? ICD_Common_Id { get; set; }
public int? BacSi_Id { get; set; }
public int? ICD_Id { get; set; }

        public DM_ICD_Common()
        {
        }
    }
}

