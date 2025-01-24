namespace Data_eHospital_DongNai_A.Model
{
    public partial class ChuyenChungTu : BaseModel
    {
        [Key]
        public int? IDSession { get; set; }
public string? LoaiCT { get; set; }
public DateTime? NgayChuyen { get; set; }
public DateTime? NgayHuy { get; set; }
public DateTime? NgayNhan { get; set; }
public int? UserChuyen_Id { get; set; }
public int? UserHuy_Id { get; set; }
public int? UserNhan_Id { get; set; }
public string? HoTenNguoiChuyen { get; set; }
public string? HoTenNguoiHuy { get; set; }
public string? HoTenNguoiNhan { get; set; }
public DateTime? TuNgay { get; set; }
public DateTime? DenNgay { get; set; }
public string? ActionSession { get; set; }
public int? Status { get; set; }

        public ChuyenChungTu()
        {
        }
    }
}

