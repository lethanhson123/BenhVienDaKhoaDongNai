namespace Data_eHospital_DongNai_A.Model
{
    public partial class DM_PhamVi : BaseModel
    {
        [Key]
        public int? PhamVi_Id { get; set; }
public string? MaPhamVi { get; set; }
public string? TenPhamVi { get; set; }
public string? TenPhamVi_En { get; set; }
public string? TenPhamVi_Ru { get; set; }
public bool? TamNgung { get; set; }
public string? TenKhongDau { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public int? Attribute_1 { get; set; }
public int? Attribute_2 { get; set; }
public int? Attribute_3 { get; set; }
public decimal? Attribute_4 { get; set; }
public decimal? Attribute_5 { get; set; }
public decimal? Attribute_6 { get; set; }
public DateTime? Attribute_7 { get; set; }
public DateTime? Attribute_8 { get; set; }
public string? Attribute_9 { get; set; }
public string? Attribute_10 { get; set; }
public string? Attribute_11 { get; set; }
public bool? Attribute_12 { get; set; }
public bool? Attribute_13 { get; set; }
public bool? Attribute_14 { get; set; }

        public DM_PhamVi()
        {
        }
    }
}

