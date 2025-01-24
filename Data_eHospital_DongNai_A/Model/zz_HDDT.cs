namespace Data_eHospital_DongNai_A.Model
{
    public partial class zz_HDDT : BaseModel
    {
        [Key]
        public string? Fkey { get; set; }
public string? CusCode { get; set; }
public string? CusName { get; set; }
public string? CusAddress { get; set; }
public string? CusPhone { get; set; }

        public zz_HDDT()
        {
        }
    }
}

