namespace Data_eHospital_DongNai_A.Model
{
    public partial class NghiPhep : BaseModel
    {
        [Key]
        public int? NghiPhep_Id { get; set; }
public string? SoPhieu { get; set; }
public int? BenhNhan_Id { get; set; }
public int? TiepNhan_Id { get; set; }
public int? KhamBenh_Id { get; set; }
public int? BenhAnNoiTru_Id { get; set; }
public int? BenhAnNgoaiTru_Id { get; set; }
public int? BacSiYeuCau_Id { get; set; }
public int? BacSiTruongKhoa_Id { get; set; }
public int? LyDoNghiPhep_Id { get; set; }
public int? SoNgayNghi { get; set; }
public int? ChanDoanICD_Id { get; set; }
public string? ChanDoan { get; set; }
public string? GhiChu { get; set; }
public DateTime? NgayRaPhieu { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public string? DonViLamViec { get; set; }
public string? SoSeri { get; set; }
public string? SoBHXH { get; set; }
public string? HoTenCha { get; set; }
public string? HoTenMe { get; set; }
public string? SoBHYT { get; set; }

        public NghiPhep()
        {
        }
    }
}

