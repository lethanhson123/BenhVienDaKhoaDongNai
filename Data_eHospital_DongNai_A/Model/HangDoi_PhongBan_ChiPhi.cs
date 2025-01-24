namespace Data_eHospital_DongNai_A.Model
{
    public partial class HangDoi_PhongBan_ChiPhi : BaseModel
    {
        [Key]
        public int? HangDoi_PhongBan_ChiPhi_Id { get; set; }
public int? PhongBan_ID { get; set; }
public string? ChiPhi { get; set; }
public DateTime? NgayHieuLuc { get; set; }
public int? SoLuongCho { get; set; }

        public HangDoi_PhongBan_ChiPhi()
        {
        }
    }
}

