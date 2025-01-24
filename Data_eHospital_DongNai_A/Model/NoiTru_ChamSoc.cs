namespace Data_eHospital_DongNai_A.Model
{
    public partial class NoiTru_ChamSoc : BaseModel
    {
        [Key]
        public int? NoiTru_ChamSoc_Id { get; set; }
public int? BenhAn_Id { get; set; }
public int? LuuTru_Id { get; set; }
public DateTime? NgayThucHien { get; set; }
public DateTime? ThoiGianThucHien { get; set; }
public int? NguoiThucHien_Id { get; set; }
public int? Mach { get; set; }
public string? NhietDo { get; set; }
public int? HuyetApThap { get; set; }
public int? HuyetApCao { get; set; }
public string? CanNang { get; set; }
public int? NhipTho { get; set; }
public string? NuocTieu { get; set; }
public string? Phan { get; set; }
public string? DienBenh { get; set; }
public string? YLenhChamSoc { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public string? Uong { get; set; }
public string? An { get; set; }
public string? TiemTruyen { get; set; }
public string? TruyenMau { get; set; }
public string? Non { get; set; }
public string? DanLuu { get; set; }
public int? DoiTuong_Id { get; set; }
public decimal? DichDanLuu1 { get; set; }
public decimal? DichDanLuu2 { get; set; }
public string? GhiChu { get; set; }

        public NoiTru_ChamSoc()
        {
        }
    }
}

