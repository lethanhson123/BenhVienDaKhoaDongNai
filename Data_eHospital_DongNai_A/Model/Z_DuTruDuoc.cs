namespace Data_eHospital_DongNai_A.Model
{
    public partial class Z_DuTruDuoc : BaseModel
    {
        [Key]
        public int? Duoc_id { get; set; }
public string? TenNhaCungCap { get; set; }
public string? DonGiaVon { get; set; }
public int? ChungTuChiTiet_id { get; set; }

        public Z_DuTruDuoc()
        {
        }
    }
}

