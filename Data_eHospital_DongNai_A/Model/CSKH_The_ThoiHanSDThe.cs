namespace Data_eHospital_DongNai_A.Model
{
    public partial class CSKH_The_ThoiHanSDThe : BaseModel
    {
        [Key]
        public int? The_ThoiHanSDThe_Id { get; set; }
public int? The_Id { get; set; }
public int? LoaiKhachHang_Id { get; set; }
public int? Nam { get; set; }
public int? Thang { get; set; }
public int? Ngay { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public DateTime? ThoiGianHetHan { get; set; }
public DateTime? NgayHetHan { get; set; }

        public CSKH_The_ThoiHanSDThe()
        {
        }
    }
}

