namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_HOPDONGLAODONG : BaseModel
    {
        [Key]
        public string? MaHopdong { get; set; }
public string? Soquyetdinh { get; set; }
public string? NhanvienkyHD { get; set; }
public string? MaNhanVien { get; set; }
public string? LoaiHD { get; set; }
public DateTime? HDTuNgay { get; set; }
public DateTime? HDDenNgay { get; set; }
public DateTime? Ngayvaolam { get; set; }
public DateTime? ThuviecTuNgay { get; set; }
public DateTime? ThuviecDenNgay { get; set; }
public string? Diadiemlamviec { get; set; }
public string? ChucDanh { get; set; }
public string? Chucvu { get; set; }
public string? Congviecduocgiao { get; set; }
public string? Thoigianlamviec { get; set; }
public string? Trangthietbicungcap { get; set; }
public string? Nguoidieuhanh { get; set; }
public string? Phuongtiendilai { get; set; }
public string? HinhThucTraLuong { get; set; }
public string? Luongcanban { get; set; }
public string? Bac { get; set; }
public string? Ngach { get; set; }
public string? Solantraluong { get; set; }
public string? Ngaytraluong { get; set; }
public string? CacPhucap { get; set; }
public string? CheDoNangLuong { get; set; }
public string? Baoholaodong { get; set; }
public string? Songaynghiphep { get; set; }
public string? BHXH { get; set; }
public string? TienThuong { get; set; }
public string? CheDoDaoTao { get; set; }
public string? Thoathuankhac { get; set; }
public string? BoiThuongViPham { get; set; }
public DateTime? NgayhieulucHD { get; set; }
public DateTime? NgayhethieulucHD { get; set; }
public string? NoilamHD { get; set; }

        public NS_HOPDONGLAODONG()
        {
        }
    }
}

