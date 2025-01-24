namespace Data_eHospital_DongNai_A.Model
{
    public partial class PhieuMoPhongChiTiet : BaseModel
    {
        [Key]
        public int? PhieuMoPhongChiTiet_ID { get; set; }
public int? PhieuMoPhong_ID { get; set; }
public string? TenTruongChieu { get; set; }
public string? MayDieuTri { get; set; }
public string? TuTheBenhNhan { get; set; }
public string? SSD { get; set; }
public string? SFD { get; set; }
public string? GocGantry { get; set; }
public string? GocCollimator { get; set; }
public string? X { get; set; }
public string? Y { get; set; }
public string? Y1 { get; set; }
public string? Y2 { get; set; }
public string? DiemLaser { get; set; }
public int? TruongChieu_ID { get; set; }
public int? MayDieuTri_ID { get; set; }
public int? TuThe_ID { get; set; }
public decimal? SoPhim { get; set; }
public decimal? PhimThang { get; set; }
public decimal? PhimNghieng { get; set; }
public decimal? PhimKhac { get; set; }

        public PhieuMoPhongChiTiet()
        {
        }
    }
}

