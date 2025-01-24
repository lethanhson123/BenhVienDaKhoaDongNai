namespace Data_eHospital_DongNai_A.Model
{
    public partial class Import_DM_DonViHanhChinh : BaseModel
    {
        [Key]
        public string? MaPX { get; set; }
public string? TenPX { get; set; }
public string? TenPXTat { get; set; }
public string? TenTiengAnh { get; set; }
public string? Cap { get; set; }
public int? PhuongXa_Id { get; set; }
public string? MaQH { get; set; }
public string? TenQH { get; set; }
public string? TenQHTat { get; set; }
public int? QuanHuyen_Id { get; set; }
public string? MaTinh { get; set; }
public string? TenTinh { get; set; }
public string? TenTinhTat { get; set; }
public int? Tinh_Id { get; set; }

        public Import_DM_DonViHanhChinh()
        {
        }
    }
}

