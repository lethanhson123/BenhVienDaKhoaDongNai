namespace Data_eHospital_DongNai_A.Model
{
    public partial class LichHen_BenhNhan : BaseModel
    {
        [Key]
        public int? LichHen_BenhNhan_Id { get; set; }
public int? KhamBenh_Id { get; set; }
public int? BenhAn_Id { get; set; }
public int? BenhNhan_Id { get; set; }
public DateTime? NgayHen_BatDau { get; set; }
public DateTime? ThoiGianHen_BatDau { get; set; }
public DateTime? NgayHen_KetThuc { get; set; }
public DateTime? ThoiGianHen_KetThuc { get; set; }
public int? PhongBan_Id { get; set; }
public int? BacSi_Id { get; set; }
public int? DichVu_Id { get; set; }
public int? TrangThai_Id { get; set; }
public int? LoaiCuocHen_Id { get; set; }
public string? GhiChu { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public int? TiepNhan_Id { get; set; }
public string? TenBenhNhan { get; set; }

        public LichHen_BenhNhan()
        {
        }
    }
}

