namespace Data_eHospital_DongNai_A.Model
{
    public partial class CSKH_The_NapTien : BaseModel
    {
        [Key]
        public int? The_NapTien_Id { get; set; }
public int? The_ID { get; set; }
public int? LoaiKhachHang_Id { get; set; }
public decimal? TienNapMin { get; set; }
public decimal? TienNapMax { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public CSKH_The_NapTien()
        {
        }
    }
}

