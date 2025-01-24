namespace Data_eHospital_DongNai_A.Model
{
    public partial class zzzzBenhAnMienGiam_All : BaseModel
    {
        [Key]
        public int? BenhAn_id { get; set; }
public string? so_benh_an { get; set; }
public string? LyDo { get; set; }
public string? GhiChu { get; set; }
public decimal? GiaTriMienGiam { get; set; }
public decimal? T_THUOC { get; set; }
public decimal? T_VTYT { get; set; }
public decimal? T_XN { get; set; }
public decimal? T_CDHA { get; set; }
public decimal? T_MAU { get; set; }
public decimal? T_PTTT { get; set; }
public decimal? T_KHAM { get; set; }
public decimal? T_GIUONG { get; set; }
public decimal? T_VCHUYEN { get; set; }
public decimal? CacLoaiTienKhac { get; set; }
public int? Duoc_id { get; set; }
public int? DichVu_id { get; set; }
public string? Loai_IDRef { get; set; }

        public zzzzBenhAnMienGiam_All()
        {
        }
    }
}

