namespace Data_eHospital_DongNai_A.Model
{
    public partial class zzzThietBi_4 : BaseModel
    {
        [Key]
        public string? MaThietBi { get; set; }
public string? TenThietBi { get; set; }
public string? MaMay { get; set; }
public int? NhomThietBi_id { get; set; }

        public zzzThietBi_4()
        {
        }
    }
}

