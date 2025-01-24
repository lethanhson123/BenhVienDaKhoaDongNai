namespace Data_eHospital_DongNai_A.Model
{
    public partial class DM_NhomTiemChung : BaseModel
    {
        [Key]
        public int? NhomTiemChung_Id { get; set; }
public string? MaNhomTiepChung { get; set; }
public string? TenNhomTiemChung { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }

        public DM_NhomTiemChung()
        {
        }
    }
}

