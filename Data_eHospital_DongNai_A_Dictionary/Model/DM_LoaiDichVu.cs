namespace Data_eHospital_DongNai_A_Dictionary.Model
{
    public partial class DM_LoaiDichVu : BaseModel
    {
        [Key]
        public int? LoaiDichVu_Id { get; set; }
public string? MaLoaiDichVu { get; set; }
public string? TenLoaiDichVu { get; set; }
public string? TenLoaiDichVu_En { get; set; }
public string? TenLoaiDichVu_Ru { get; set; }
public bool? TamNgung { get; set; }
public string? TenKhongDau { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public string? SiteCode { get; set; }
public int? Mapping_Public_Id { get; set; }

        public DM_LoaiDichVu()
        {
        }
    }
}

