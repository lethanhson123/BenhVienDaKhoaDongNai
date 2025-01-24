namespace Data_eHospital_DongNai_A.Model
{
    public partial class BCTH_018_DieuTri_NoiTru_Data : BaseModel
    {
        [Key]
        public int? PhongBan_Id { get; set; }
public string? TenKhoa { get; set; }
public string? MaPhongBan { get; set; }
public int? Thang { get; set; }
public int? Nam { get; set; }
public int? SoGiuongBenh { get; set; }
public int? SoGiuongBenhNu { get; set; }
public int? RaKhoa { get; set; }
public int? VaoKhoa { get; set; }
public int? SoNguoiDauKy { get; set; }
public int? SoNguoiDauKyNu { get; set; }
public int? NTTongSo { get; set; }
public int? NTTongSoNu { get; set; }
public int? NTDuoi15Tuoi { get; set; }
public int? NTDuoi15TuoiNu { get; set; }
public int? NTCapCuu { get; set; }
public int? NTCapCuuNu { get; set; }
public int? SoNgayDieuTriNoiTru { get; set; }
public int? SoNgayDieuTriNoiTruNu { get; set; }
public int? TVTongSo { get; set; }
public int? TVTongSoNu { get; set; }
public int? TVDuoi15Tuoi { get; set; }
public int? TVDuoi15TuoiNu { get; set; }
public int? TVTruoc24Gio { get; set; }
public int? TVTruoc24GioNu { get; set; }
public int? NguoiBenhTheBHYT { get; set; }
public int? NguoiBenhTheBHYTNu { get; set; }
public int? NguoiBenhCuoiKy { get; set; }
public int? NguoiBenhCuoiKyNu { get; set; }
public int? SoNguoiXuatVien { get; set; }

        public BCTH_018_DieuTri_NoiTru_Data()
        {
        }
    }
}

