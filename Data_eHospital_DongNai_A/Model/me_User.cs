namespace Data_eHospital_DongNai_A.Model
{
    public partial class me_User : BaseModel
    {
        [Key]
        public int? User_id { get; set; }
public string? User_Code { get; set; }
public string? User_Name { get; set; }
public string? Pass { get; set; }
public int? User_Level { get; set; }
public DateTime? NgayTao { get; set; }
public DateTime? NgayDieuChinh { get; set; }
public bool? IsLocked { get; set; }

        public me_User()
        {
        }
    }
}

