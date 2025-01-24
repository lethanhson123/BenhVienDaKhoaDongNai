namespace Data_eHospital_DongNai_A.Model
{
    public partial class me_GoiSo : BaseModel
    {
        [Key]
        public int? KhuVuc_id { get; set; }
public int? Cua_id { get; set; }
public int? SoDaGoi { get; set; }
public bool? TamNgung { get; set; }
public DateTime? NgayTao { get; set; }
public int? Mac_id { get; set; }

        public me_GoiSo()
        {
        }
    }
}

