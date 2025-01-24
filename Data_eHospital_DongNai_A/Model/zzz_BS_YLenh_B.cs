namespace Data_eHospital_DongNai_A.Model
{
    public partial class zzz_BS_YLenh_B : BaseModel
    {
        [Key]
        public int? STT { get; set; }
public string? MaBS { get; set; }
public DateTime? NgayYL { get; set; }
public string? NgayYL2 { get; set; }

        public zzz_BS_YLenh_B()
        {
        }
    }
}

