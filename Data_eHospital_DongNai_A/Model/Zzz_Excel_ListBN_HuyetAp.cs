namespace Data_eHospital_DongNai_A.Model
{
    public partial class Zzz_Excel_ListBN_HuyetAp : BaseModel
    {
        [Key]
        public string? MaYTe { get; set; }
public string? TenBN { get; set; }
public int? NamSinh { get; set; }
public string? GioiTinh { get; set; }

        public Zzz_Excel_ListBN_HuyetAp()
        {
        }
    }
}

