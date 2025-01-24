namespace Data_eHospital_DongNai_A.Model
{
    public partial class zzzThietBi : BaseModel
    {
        [Key]
        public string? MaThietBi { get; set; }
public string? TenThietBi { get; set; }
public int? NhomThietBi_Id { get; set; }
public string? SoSeri { get; set; }
public string? MaMay { get; set; }

        public zzzThietBi()
        {
        }
    }
}

