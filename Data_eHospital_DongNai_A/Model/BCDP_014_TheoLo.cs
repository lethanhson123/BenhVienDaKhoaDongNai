namespace Data_eHospital_DongNai_A.Model
{
    public partial class BCDP_014_TheoLo : BaseModel
    {
        [Key]
        public string? PhamVi { get; set; }
public string? NguonDuoc { get; set; }
public string? LoaiDuoc { get; set; }
public string? PhanNhomDuoc { get; set; }
public string? MaKeToan { get; set; }
public int? Duoc_ID { get; set; }
public int? SoLoNhap_Id { get; set; }
public string? TenDuoc { get; set; }
public string? NuocSanXuat { get; set; }
public string? DonViTinh { get; set; }
public decimal? SoLuongDK { get; set; }
public decimal? ThanhTienDK { get; set; }
public decimal? SoLuongNhap { get; set; }
public decimal? ThanhTienNhap { get; set; }
public decimal? SoLuongXuat { get; set; }
public decimal? ThanhTienXuat { get; set; }

        public BCDP_014_TheoLo()
        {
        }
    }
}

