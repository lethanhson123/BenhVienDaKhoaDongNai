namespace Data_eHospital_DongNai_A.Model
{
    public partial class CDT_KeHoachHoiThao_BVThamGia : BaseModel
    {
        [Key]
        public int? CDT_KeHoachHoiThao_Id { get; set; }
public int? HoiThao_Id { get; set; }
public int? BenhVien_Id { get; set; }
public int? SoLuongThamGia { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public CDT_KeHoachHoiThao_BVThamGia()
        {
        }
    }
}

