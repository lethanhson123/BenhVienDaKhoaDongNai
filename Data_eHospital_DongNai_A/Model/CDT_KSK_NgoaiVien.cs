namespace Data_eHospital_DongNai_A.Model
{
    public partial class CDT_KSK_NgoaiVien : BaseModel
    {
        [Key]
        public int? KSK_NgoaiVien_Id { get; set; }
public int? KSK_TuyenDuoi_Id { get; set; }
public int? SoCaBenhNhanKham { get; set; }
public int? SoCaBenhNhanNam { get; set; }
public int? SoCaBenhNhanNu { get; set; }
public int? QuanHuyen_Id { get; set; }
public int? TinhThanhPho_Id { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public CDT_KSK_NgoaiVien()
        {
        }
    }
}

