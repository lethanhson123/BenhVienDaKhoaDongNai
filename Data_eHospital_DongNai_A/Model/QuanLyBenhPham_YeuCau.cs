namespace Data_eHospital_DongNai_A.Model
{
    public partial class QuanLyBenhPham_YeuCau : BaseModel
    {
        [Key]
        public int? QuanLyBenhPham_YeuCau_Id { get; set; }
public int? QuanLyBenhPham_Id { get; set; }
public int? CLSYeuCau_Id { get; set; }
public int? CLSYeuCauChiTiet_Id { get; set; }
public int? NhomDichVu_Id { get; set; }
public int? DichVu_Id { get; set; }
public int? LoaiGia_Id { get; set; }
public decimal? DonGiaDoanhThu { get; set; }
public decimal? DonGiaThanhToan { get; set; }
public string? LoaiTien_Id { get; set; }
public decimal? TyGia { get; set; }
public string? GhiChuLayMau { get; set; }

        public QuanLyBenhPham_YeuCau()
        {
        }
    }
}

