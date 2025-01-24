namespace Data_eHospital_DongNai_A.Model
{
    public partial class zzzPhongBan : BaseModel
    {
        [Key]
        public int? PhongBan_Id { get; set; }
public string? TenPhongBan { get; set; }
public string? TenPhongBan_En { get; set; }

        public zzzPhongBan()
        {
        }
    }
}

