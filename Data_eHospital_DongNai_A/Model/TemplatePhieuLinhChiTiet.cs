namespace Data_eHospital_DongNai_A.Model
{
    public partial class TemplatePhieuLinhChiTiet : BaseModel
    {
        [Key]
        public int? Template_ChiTiet_Id { get; set; }
public int? Template_Id { get; set; }
public int? Duoc_Id { get; set; }
public int? DonViTinh_Id { get; set; }
public string? SoLuongYeuCau { get; set; }
public int? NguonHang_Id { get; set; }

        public TemplatePhieuLinhChiTiet()
        {
        }
    }
}

