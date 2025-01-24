namespace Data_eHospital_DongNai_A.Model
{
    public partial class ComputerName : BaseModel
    {
        [Key]
        public int? TenPC_id { get; set; }
public string? TenPC { get; set; }
public int? PhongBan_id { get; set; }
public string? TenPhongBan { get; set; }
public string? Khu { get; set; }

        public ComputerName()
        {
        }
    }
}

