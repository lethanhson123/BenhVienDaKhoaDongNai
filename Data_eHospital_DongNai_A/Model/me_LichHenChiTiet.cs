namespace Data_eHospital_DongNai_A.Model
{
    public partial class me_LichHenChiTiet : BaseModel
    {
        [Key]
        public int? LichHenChiTiet_id { get; set; }
public int? LichHen_id { get; set; }
public int? DichVu_id { get; set; }
public int? NoiTao_id { get; set; }
public int? NguoiTao_id { get; set; }
public string? NgayTao { get; set; }
public DateTime? ThoiGianTao { get; set; }
public string? GhiChu { get; set; }
public int? MuiTiemSo { get; set; }
public int? NoiCapNhat_id { get; set; }
public int? NguoiCapNhat_id { get; set; }
public DateTime? NgayCapNhat { get; set; }

        public me_LichHenChiTiet()
        {
        }
    }
}

