namespace Data_eHospital_DongNai_A.Model
{
    public partial class XepLich : BaseModel
    {
        [Key]
        public int? XepLich_ID { get; set; }
public int? NhanVien_Id { get; set; }
public DateTime? NgayXepLich { get; set; }
public int? NgayTrongTuan_ID { get; set; }
public DateTime? ThoiGianBatDau { get; set; }
public DateTime? ThoiGianKetThuc { get; set; }
public decimal? SoGio { get; set; }
public int? PhongBan_ID { get; set; }
public int? CaTruc_ID { get; set; }
public bool? Truc { get; set; }
public bool? CaGay { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? LyDoChamCong_Id { get; set; }
public float? GioThem { get; set; }
public float? GioCongChuan { get; set; }
public bool? Lock { get; set; }
public int? GioCongChuan_Id { get; set; }
public float? Balance { get; set; }

        public XepLich()
        {
        }
    }
}

