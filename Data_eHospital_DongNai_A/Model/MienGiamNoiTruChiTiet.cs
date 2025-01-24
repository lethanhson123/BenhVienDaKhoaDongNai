namespace Data_eHospital_DongNai_A.Model
{
    public partial class MienGiamNoiTruChiTiet : BaseModel
    {
        [Key]
        public int? MienGiamNoiTruChiTiet_Id { get; set; }
public int? MienGiam_ID { get; set; }
public int? YeuCauChiTiet_Id { get; set; }
public decimal? GiaTriNoiDungMienGiam { get; set; }
public decimal? TyLeMienGiam { get; set; }
public decimal? GiaTriMienGiam { get; set; }
public int? LyDoMienGiam_Id { get; set; }
public string? GhiChu { get; set; }
public int? IDRef { get; set; }
public string? Loai_IDRef { get; set; }
public int? NoiDung_Id { get; set; }
public string? LoaiNoiDung { get; set; }
public decimal? GiaTriMienGiam_ChenhLech { get; set; }
public decimal? GiaTriMienGiam_HoTroChenhLech { get; set; }
public decimal? GiaTriMienGiam_CoPhan { get; set; }
public decimal? SoLuongMienGiam { get; set; }

        public MienGiamNoiTruChiTiet()
        {
        }
    }
}

