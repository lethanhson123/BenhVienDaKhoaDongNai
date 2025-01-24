namespace Data_eHospital_DongNai_A.Model
{
    public partial class me_CapSo : BaseModel
    {
        [Key]
        public int? KhuVuc_id { get; set; }
public int? Cua_id { get; set; }
public int? SoDaCap { get; set; }
public DateTime? ThoiGianCapSo { get; set; }
public int? Mac_id { get; set; }
public bool? TamNgung { get; set; }

        public me_CapSo()
        {
        }
    }
}

