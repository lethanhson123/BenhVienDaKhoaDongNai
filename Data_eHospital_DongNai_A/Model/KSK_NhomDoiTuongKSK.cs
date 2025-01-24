namespace Data_eHospital_DongNai_A.Model
{
    public partial class KSK_NhomDoiTuongKSK : BaseModel
    {
        [Key]
        public int? NhomDoiTuong_Id { get; set; }
public string? MaNhomDoiTuong { get; set; }
public string? TenNhomDoiTuong { get; set; }
public string? TenNhomDoiTuong_En { get; set; }
public string? TenNhomDoiTuong_Ru { get; set; }
public bool? TamNgung { get; set; }
public string? TenKhongDau { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public KSK_NhomDoiTuongKSK()
        {
        }
    }
}

