namespace Data_eHospital_DongNai_A.Model
{
    public partial class ChungTu_UNC : BaseModel
    {
        [Key]
        public int? UNC_Id { get; set; }
public string? SoUNC { get; set; }
public DateTime? NgayUNC { get; set; }
public string? GiaTriThanhToan { get; set; }
public int? NhaCungCap_Id { get; set; }
public string? GhiChu { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public ChungTu_UNC()
        {
        }
    }
}

