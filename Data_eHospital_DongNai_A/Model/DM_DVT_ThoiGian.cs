namespace Data_eHospital_DongNai_A.Model
{
    public partial class DM_DVT_ThoiGian : BaseModel
    {
        [Key]
        public int? DVT_ThoiGian_Id { get; set; }
public string? MaDonViTinh { get; set; }
public string? TenDonViTinh { get; set; }

        public DM_DVT_ThoiGian()
        {
        }
    }
}

