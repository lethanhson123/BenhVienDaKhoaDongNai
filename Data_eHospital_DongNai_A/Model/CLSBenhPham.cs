namespace Data_eHospital_DongNai_A.Model
{
    public partial class CLSBenhPham : BaseModel
    {
        [Key]
        public int? CLSBenhPham_Id { get; set; }
public int? CLSYeuCau_Id { get; set; }
public int? LanNhan { get; set; }
public DateTime? NgayNhan { get; set; }
public DateTime? ThoiGianNhan { get; set; }
public DateTime? NgayGioNhan { get; set; }
public int? NguoiGiao_Id { get; set; }
public string? TenNguoiGiao { get; set; }
public int? NguoiNhan_Id { get; set; }
public int? SoLuong { get; set; }
public string? MoTa { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public CLSBenhPham()
        {
        }
    }
}

