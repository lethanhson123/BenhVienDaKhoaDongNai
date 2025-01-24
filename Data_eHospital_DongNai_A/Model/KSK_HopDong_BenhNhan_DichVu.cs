namespace Data_eHospital_DongNai_A.Model
{
    public partial class KSK_HopDong_BenhNhan_DichVu : BaseModel
    {
        [Key]
        public int? HopDong_DichVu_BenhNhan_id { get; set; }
public int? HopDong_id { get; set; }
public int? HopDong_DichVu_Id { get; set; }
public int? HopDong_BenhNhan_Id { get; set; }
public int? Phongban_id { get; set; }
public string? TrangThai { get; set; }
public bool? DaThuTien { get; set; }
public string? KetQua { get; set; }
public bool? Selected { get; set; }
public string? Sophieuyeucau { get; set; }
public int? clsyeucau_id { get; set; }
public int? clsyeucauchitiet_id { get; set; }
public bool? Dataophieu { get; set; }
public int? Benhnhan_ehos_id { get; set; }
public int? Tiepnhan_id { get; set; }
public bool? BatThuong { get; set; }
public string? MucBinhThuongMin { get; set; }
public string? MucBinhThuongMax { get; set; }
public bool? Dathuchien { get; set; }
public bool? Inbc { get; set; }
public string? PhanLoai { get; set; }

        public KSK_HopDong_BenhNhan_DichVu()
        {
        }
    }
}

