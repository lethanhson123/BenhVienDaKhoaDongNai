namespace Data_eHospital_DongNai_A.Model
{
    public partial class DuocTonDauKy_20241230 : BaseModel
    {
        [Key]
        public int? DuocTonDauKy_Id { get; set; }
public int? DuocKyTonKho_Id { get; set; }
public int? KhoDuoc_Id { get; set; }
public int? Duoc_Id { get; set; }
public int? SoLoNhap_Id { get; set; }
public string? DonGiaMua { get; set; }
public float? DonGiaVon { get; set; }
public string? SoLuong { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public DuocTonDauKy_20241230()
        {
        }
    }
}

