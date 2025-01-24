namespace Data_eHospital_DongNai_A.Model
{
    public partial class SinhHieu : BaseModel
    {
        [Key]
        public int? SinhHieu_Id { get; set; }
public int? BenhNhan_Id { get; set; }
public int? KhamBenh_Id { get; set; }
public DateTime? NgayDo { get; set; }
public DateTime? ThoiGianDo { get; set; }
public int? NguoiDo_Id { get; set; }
public int? PhongBan_Id { get; set; }
public int? Mach { get; set; }
public int? HuyetApThap { get; set; }
public int? HuyetApCao { get; set; }
public int? NhipTho { get; set; }
public decimal? NhietDo { get; set; }
public decimal? ChieuCao { get; set; }
public decimal? CanNang { get; set; }
public decimal? ChiSoBMI { get; set; }
public decimal? VongBung { get; set; }
public string? GhiChu { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public int? NoiTru_khamBenh_Id { get; set; }
public decimal? VongDau { get; set; }
public decimal? SpO2 { get; set; }

        public SinhHieu()
        {
        }
    }
}

