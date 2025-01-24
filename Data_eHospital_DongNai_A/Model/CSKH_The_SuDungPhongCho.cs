namespace Data_eHospital_DongNai_A.Model
{
    public partial class CSKH_The_SuDungPhongCho : BaseModel
    {
        [Key]
        public int? The_SuDungPhongCho_Id { get; set; }
public int? The_Id { get; set; }
public int? LoaiKhachHang_Id { get; set; }
public bool? SuDung { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public CSKH_The_SuDungPhongCho()
        {
        }
    }
}

