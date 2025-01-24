namespace Data_eHospital_DongNai_A.Model
{
    public partial class ClsKetQuaTrungTamNghienCuu : BaseModel
    {
        [Key]
        public int? ClsKetQua_XetNghiemTrungTamNgienCuu_Id { get; set; }
public int? ClsKetQua_Id { get; set; }
public string? MaSoPhieu { get; set; }
public int? BenhNhan_Id { get; set; }
public int? BacSyChiDinh_Id { get; set; }
public int? NoiGuiMau_id { get; set; }
public DateTime? NgayNhanMau { get; set; }
public int? LoaiMau_Id { get; set; }
public string? ThucHienKyThuat { get; set; }
public int? ThietBi_Id { get; set; }
public int? NguoiThucHien_Id { get; set; }
public int? CachThucSuDung_Id { get; set; }
public string? ThongTinSuDung { get; set; }
public string? KetLuan { get; set; }
public string? KetQua { get; set; }
public string? KetQua_Text { get; set; }
public string? ThongTin { get; set; }
public string? ThongTin_Text { get; set; }
public DateTime? ThoiGianThucHien { get; set; }
public int? DonViThucHien_Id { get; set; }
public string? GhiChu { get; set; }
public string? MaXN { get; set; }

        public ClsKetQuaTrungTamNghienCuu()
        {
        }
    }
}

