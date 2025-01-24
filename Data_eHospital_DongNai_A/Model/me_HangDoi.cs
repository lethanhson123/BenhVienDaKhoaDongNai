namespace Data_eHospital_DongNai_A.Model
{
    public partial class me_HangDoi : BaseModel
    {
        [Key]
        public int? HangDoi_id { get; set; }
public int? KhuVuc_id { get; set; }
public int? Cua_id { get; set; }
public int? SoTT { get; set; }
public int? MacCapSo_id { get; set; }
public DateTime? ThoiGianCap { get; set; }
public int? MacGoiSo_id { get; set; }
public DateTime? ThoiGianGoi { get; set; }
public int? TiepNhan_id { get; set; }

        public me_HangDoi()
        {
        }
    }
}

