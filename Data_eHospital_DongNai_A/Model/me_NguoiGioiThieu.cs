namespace Data_eHospital_DongNai_A.Model
{
    public partial class me_NguoiGioiThieu : BaseModel
    {
        [Key]
        public int? NguoiGioiThieu_id { get; set; }
public int? NhanVien_id { get; set; }
public int? TiepNhan_id { get; set; }
public bool? Huy { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat { get; set; }

        public me_NguoiGioiThieu()
        {
        }
    }
}

