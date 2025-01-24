namespace Data_eHospital_DongNai_A.Model
{
    public partial class HoSoSucKhoe_TiemChung : BaseModel
    {
        [Key]
        public int? TiemChung_Id { get; set; }
public int? HoSoSucKhoe_Id { get; set; }
public int? Vaccin_Id { get; set; }
public int? Nam { get; set; }
public int? Lan { get; set; }
public string? GhiChu { get; set; }

        public HoSoSucKhoe_TiemChung()
        {
        }
    }
}

