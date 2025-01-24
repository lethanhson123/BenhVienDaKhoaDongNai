namespace Data_eHospital_DongNai_A.Model
{
    public partial class ChiPhiKCBNgoaiTru_BHYT : BaseModel
    {
        [Key]
        public int? Id { get; set; }
public int? TiepNhan_Id { get; set; }
public int? KhamBenh_Id { get; set; }
public int? BenhAn_Id { get; set; }
public int? BenhNhan_Id { get; set; }
public int? DoiTuong_Id { get; set; }
public string? SoBHYT { get; set; }
public DateTime? NgayVao { get; set; }
public DateTime? NgayRa { get; set; }
public DateTime? NgayKham { get; set; }
public string? Loai_IDRef { get; set; }
public int? IDRef { get; set; }
public int? NoiDung_Id { get; set; }
public string? NoiDung { get; set; }
public decimal? SoLuong { get; set; }
public decimal? DonGiaDoanhThu { get; set; }
public decimal? DonGiaHoTro { get; set; }
public decimal? DonGiaHoTroChiTra { get; set; }
public decimal? DonGiaThanhToan { get; set; }
public decimal? SoLuong_New { get; set; }
public decimal? DonGiaHoTroChiTra_New { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public string? Loai { get; set; }

        public ChiPhiKCBNgoaiTru_BHYT()
        {
        }
    }
}

