namespace Data_eHospital_DongNai_A.Model
{
    public partial class CSKH_The_DoiThe : BaseModel
    {
        [Key]
        public int? The_DoiThe_Id { get; set; }
public int? The_Id { get; set; }
public int? LoaiKhachHang_Id { get; set; }
public decimal? SoTien { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public CSKH_The_DoiThe()
        {
        }
    }
}

