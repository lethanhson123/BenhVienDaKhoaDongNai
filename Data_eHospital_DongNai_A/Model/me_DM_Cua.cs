namespace Data_eHospital_DongNai_A.Model
{
    public partial class me_DM_Cua : BaseModel
    {
        [Key]
        public int? Cua_id { get; set; }
public string? TenCua { get; set; }
public int? Pos_id { get; set; }
public int? ToaDo_X { get; set; }
public int? ToaDo_Y { get; set; }
public DateTime? ThoiGianTao { get; set; }

        public me_DM_Cua()
        {
        }
    }
}

