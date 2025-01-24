namespace Data_eHospital_DongNai_A.Model
{
    public partial class CUST_DM_NhaThuocDungChung : BaseModel
    {
        [Key]
        public int? Duoc_id { get; set; }
public string? MaDuoc { get; set; }
public string? TenHang { get; set; }
public string? MaQuanLyDuoc { get; set; }

        public CUST_DM_NhaThuocDungChung()
        {
        }
    }
}

