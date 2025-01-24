namespace Data_eHospital_DongNai_A.Model
{
    public partial class CSKH_The_GiamGiaTheoTG : BaseModel
    {
        [Key]
        public int? The_GiamGiaTheoTG_Id { get; set; }
public int? The_Id { get; set; }
public int? LoaiKhachHang_Id { get; set; }
public int? The_DSDoiTuongKM_Id { get; set; }
public int? DichVu_Id { get; set; }
public decimal? TyLe { get; set; }
public DateTime? ThoiGianMin { get; set; }
public DateTime? ThoiGianMax { get; set; }
public int? SoNgay { get; set; }
public bool? TatCaDichVu { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public CSKH_The_GiamGiaTheoTG()
        {
        }
    }
}

