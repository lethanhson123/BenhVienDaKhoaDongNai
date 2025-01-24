namespace Data_eHospital_DongNai_A.Model
{
    public partial class me_MAC_Mapping : BaseModel
    {
        [Key]
        public int? Mapping_id { get; set; }
public int? MAC_id { get; set; }
public int? Cua_id { get; set; }
public int? KhuVuc_id { get; set; }
public bool? TamNgung { get; set; }
public DateTime? NgayMapping { get; set; }
public int? SoDaCap { get; set; }
public DateTime? ThoiGianCap { get; set; }
public int? SoDaGoi { get; set; }
public DateTime? ThoiGianGoi { get; set; }

        public me_MAC_Mapping()
        {
        }
    }
}

