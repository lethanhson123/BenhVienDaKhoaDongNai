namespace Data_eHospital_DongNai_A.Model
{
    public partial class MienGiamNoiTru : BaseModel
    {
        [Key]
        public int? MienGiam_Id { get; set; }
public string? MaMienGiam { get; set; }
public string? SoPhieuMienGiam { get; set; }
public int? BenhAn_Id { get; set; }
public int? BenhNhan_Id { get; set; }
public decimal? GiaTri { get; set; }
public DateTime? NgayLap { get; set; }
public int? NguoiLap_Id { get; set; }
public string? GhiChu { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public bool? Huy { get; set; }
public int? LyDo_ID { get; set; }

        public MienGiamNoiTru()
        {
        }
    }
}

