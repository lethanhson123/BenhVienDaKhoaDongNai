namespace Data_eHospital_DongNai_A.Model
{
    public partial class TemplatePhieuLinh : BaseModel
    {
        [Key]
        public int? Template_Id { get; set; }
public string? MaTemplate { get; set; }
public string? TenTemplate { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public string? DienGiai { get; set; }
public int? NguonHang_Id { get; set; }
public int? Kho_Id { get; set; }

        public TemplatePhieuLinh()
        {
        }
    }
}

