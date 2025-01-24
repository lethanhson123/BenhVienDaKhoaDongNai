namespace Data_eHospital_DongNai_A.Model
{
    public partial class ChungTu_UNC_ChiTiet : BaseModel
    {
        [Key]
        public int? UNC_ChiTiet_Id { get; set; }
public int? UNC_Id { get; set; }
public int? ChungTu_Id { get; set; }
public string? MaChungTu { get; set; }
public string? SoSeri { get; set; }
public string? SoHoaDon { get; set; }
public string? GiaTriThanhToan { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public ChungTu_UNC_ChiTiet()
        {
        }
    }
}

