namespace Data_eHospital_DongNai_A.Model
{
    public partial class DuocTonKho : BaseModel
    {
        [Key]
        public int? DuocTonKho_Id { get; set; }
public int? KhoDuoc_Id { get; set; }
public int? Duoc_Id { get; set; }
public int? NguonNhapHang_Id { get; set; }
public int? SoLoNhap_Id { get; set; }
public string? DonGiaMua { get; set; }
public string? SoLuong { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public DuocTonKho()
        {
        }
    }
}

