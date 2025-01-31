namespace Data_eHospital_DongNai_A_Dictionary.Model
{
    public partial class DM_DonViTinh : BaseModel
    {
        [Key]
        public int? DonViTinh_Id { get; set; }
public string? LoaiVatTu_Id { get; set; }
public string? MaDonViTinh { get; set; }
public string? TenDonViTinh { get; set; }
public bool? DonViCoBan { get; set; }
public int? DonViCoBan_Id { get; set; }
public decimal? GiaTriQuiDoi { get; set; }
public string? TenKhongDau { get; set; }
public bool? TamNgung { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public string? SiteCode { get; set; }
public int? Mapping_Public_Id { get; set; }

        public DM_DonViTinh()
        {
        }
    }
}

