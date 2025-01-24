namespace Data_eHospital_DongNai_A.Model
{
    public partial class zzzzBenhAnMienGiam : BaseModel
    {
        [Key]
        public int? BenhAn_id { get; set; }
public string? so_benh_an { get; set; }
public int? duoc_id { get; set; }
public string? LyDo { get; set; }
public string? GhiChu { get; set; }
public decimal? GiaTriMienGiam { get; set; }

        public zzzzBenhAnMienGiam()
        {
        }
    }
}

