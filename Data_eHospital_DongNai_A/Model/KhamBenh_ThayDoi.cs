namespace Data_eHospital_DongNai_A.Model
{
    public partial class KhamBenh_ThayDoi : BaseModel
    {
        [Key]
        public int? KhamBenh_ThayDoi_Id { get; set; }
public int? HoaDonChiTiet_Id { get; set; }
public int? DichVu_Id { get; set; }
public int? PhongBan_Id { get; set; }
public int? DichVu_ThayDoi_Id { get; set; }
public int? PhongBan_ThayDoi_Id { get; set; }
public int? LanThayDoi { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public KhamBenh_ThayDoi()
        {
        }
    }
}

