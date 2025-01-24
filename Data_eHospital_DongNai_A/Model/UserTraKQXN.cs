namespace Data_eHospital_DongNai_A.Model
{
    public partial class UserTraKQXN : BaseModel
    {
        [Key]
        public int? DangKi_id { get; set; }
public int? User_id { get; set; }
public string? User_Name { get; set; }
public int? KhoaQuanLy_id { get; set; }
public string? TenKhoa { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao { get; set; }
public bool? IsActive { get; set; }

        public UserTraKQXN()
        {
        }
    }
}

