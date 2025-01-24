namespace Data_eHospital_DongNai_A.Model
{
    public partial class me_KhuVuc_User : BaseModel
    {
        [Key]
        public int? KhuVuc_User_id { get; set; }
public int? KhuVuc_id { get; set; }
public int? User_id { get; set; }
public DateTime? NgayTao { get; set; }
public DateTime? NgayCapNhat { get; set; }

        public me_KhuVuc_User()
        {
        }
    }
}

