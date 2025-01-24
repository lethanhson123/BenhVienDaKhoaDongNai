namespace Data_eHospital_DongNai_A.Model
{
    public partial class PhieuGhiNhanUngThu : BaseModel
    {
        [Key]
        public int? PhieuGhiNhanUngThu_Id { get; set; }
public string? SoPhieu { get; set; }
public int? BenhAn_Id { get; set; }
public string? ThoiGianCuTru { get; set; }
public int? TinhTrangGiaDinh_Id { get; set; }
public string? PARA { get; set; }
public string? KinhDau { get; set; }
public string? LayChong { get; set; }
public string? SanhConDau { get; set; }
public string? ManKinh { get; set; }
public int? SoLanLapGiaDinh { get; set; }
public string? ViTriUngThu { get; set; }
public string? GiaiPhauBenhLy { get; set; }
public string? Grad { get; set; }
public string? GiaiDoanLamSang { get; set; }
public string? XepHangLamSang { get; set; }
public string? T { get; set; }
public string? N { get; set; }
public string? M { get; set; }
public int? CoSoChanDoan_Id { get; set; }
public int? UngThuNguyenPhat { get; set; }
public string? NguonThongTin { get; set; }
public int? DieuTriDacHieu_Id { get; set; }
public DateTime? NgayTheoDoi { get; set; }
public int? TinhTrangHienTai_Id { get; set; }
public DateTime? NgayTuVong { get; set; }
public int? NguyenNhanTuVong_Id { get; set; }
public int? KetQuaTuThiet_Id { get; set; }
public string? NoiTuVong { get; set; }
public int? ICD_O_ID { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public DateTime? NgayThucHien { get; set; }

        public PhieuGhiNhanUngThu()
        {
        }
    }
}

