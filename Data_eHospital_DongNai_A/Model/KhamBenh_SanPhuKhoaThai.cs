namespace Data_eHospital_DongNai_A.Model
{
    public partial class KhamBenh_SanPhuKhoaThai : BaseModel
    {
        [Key]
        public int? KhamBenh_SanPhuKhoaThai_Id { get; set; }
public int? BenhNhan_Id { get; set; }
public int? KhamBenh_Id { get; set; }
public DateTime? NgayKinhCuoiDS { get; set; }
public string? TienCanBenhLy { get; set; }
public decimal? ChieuCao { get; set; }
public decimal? CanNang { get; set; }
public int? NgayTuoiThai { get; set; }
public string? HA { get; set; }
public string? Phu { get; set; }
public string? BCTC { get; set; }
public string? ThaiMay { get; set; }
public string? TimThay { get; set; }
public string? NgoiThai { get; set; }
public string? CTC { get; set; }
public string? KetLuan { get; set; }
public int? NguoiKham_Id { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public KhamBenh_SanPhuKhoaThai()
        {
        }
    }
}

