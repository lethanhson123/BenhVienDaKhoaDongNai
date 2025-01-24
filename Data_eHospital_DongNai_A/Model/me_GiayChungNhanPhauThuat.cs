namespace Data_eHospital_DongNai_A.Model
{
    public partial class me_GiayChungNhanPhauThuat : BaseModel
    {
        [Key]
        public int? BenhAnPhauThuat_Id { get; set; }
public int? TruongKhoa_id { get; set; }
public int? Khoa_id { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat { get; set; }

        public me_GiayChungNhanPhauThuat()
        {
        }
    }
}

