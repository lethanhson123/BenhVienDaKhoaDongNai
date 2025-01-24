namespace Data_eHospital_DongNai_A.Model
{
    public partial class zzzzBangKe_BHYT_All : BaseModel
    {
        [Key]
        public string? Ma_lk { get; set; }
public int? NoiDung_id { get; set; }
public decimal? So_Luong { get; set; }
public decimal? Don_Gia_BV { get; set; }
public decimal? Don_Gia_BH { get; set; }
public decimal? Thanh_Tien_BV { get; set; }
public decimal? Thanh_Tien_BH { get; set; }
public decimal? T_BHTT { get; set; }
public decimal? T_BNCCT { get; set; }
public decimal? T_KHAC { get; set; }
public decimal? T_BNTT { get; set; }
public string? Loai_IDRef { get; set; }

        public zzzzBangKe_BHYT_All()
        {
        }
    }
}

