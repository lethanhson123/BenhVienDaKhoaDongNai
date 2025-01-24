namespace Data_eHospital_DongNai_A.Model
{
    public partial class KhamBenh_ICD : BaseModel
    {
        [Key]
        public int? KhamBenh_ICD_Id { get; set; }
public int? KhamBenh_Id { get; set; }
public int? ICD_Id { get; set; }
public int? idx { get; set; }

        public KhamBenh_ICD()
        {
        }
    }
}

