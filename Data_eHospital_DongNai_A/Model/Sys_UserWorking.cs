namespace Data_eHospital_DongNai_A.Model
{
    public partial class Sys_UserWorking : BaseModel
    {
        [Key]
        public int? UserWorking_Id { get; set; }
public int? User_Id { get; set; }
public int? Khoa_Id { get; set; }
public int? Phong_Id { get; set; }
public int? PhongKham_Id { get; set; }
public int? QuayThuVienPhi_Id { get; set; }
public int? KhoDuoc_Id { get; set; }
public DateTime? LogInTime { get; set; }
public DateTime? LogOutTime { get; set; }

        public Sys_UserWorking()
        {
        }
    }
}

