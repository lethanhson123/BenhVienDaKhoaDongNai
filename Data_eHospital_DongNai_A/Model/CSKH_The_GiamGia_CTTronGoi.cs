namespace Data_eHospital_DongNai_A.Model
{
    public partial class CSKH_The_GiamGia_CTTronGoi : BaseModel
    {
        [Key]
        public int? The_GiamGia_CTTronGoi_Id { get; set; }
public int? The_Id { get; set; }
public int? LoaiKhachHang_Id { get; set; }
public decimal? TyLe { get; set; }
public int? CTTronGoi_Id { get; set; }
public DateTime? ThoiGianMin { get; set; }
public DateTime? ThoiGianMax { get; set; }
public bool? TatCaChuongTrinh { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public CSKH_The_GiamGia_CTTronGoi()
        {
        }
    }
}

