namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_THONGTINUNGVIEN : BaseModel
    {
        [Key]
        public string? MaUngVien { get; set; }
public string? Ho { get; set; }
public string? Ten { get; set; }
public string? Gioitinh { get; set; }
public DateTime? Ngaysinh { get; set; }
public string? Noisinh { get; set; }
public string? DiachiHokhau { get; set; }
public string? Diachilienlac { get; set; }
public string? Dienthoai { get; set; }
public string? Didong { get; set; }
public string? Email { get; set; }
public string? MaQuoctich { get; set; }
public string? CMND { get; set; }
public string? MaTrinhDo { get; set; }
public string? ChuyenMon { get; set; }
public string? Chucdanhdutuyen { get; set; }
public DateTime? Ngaynopdon { get; set; }
public string? Congviec { get; set; }
public string? Mucluongyeucau { get; set; }
public string? Nangkhieu { get; set; }
public string? Honnhan { get; set; }
public string? Suckhoe { get; set; }
public float? Chieucao { get; set; }
public float? Cannang { get; set; }
public string? Nhommau { get; set; }
public string? Hinhanh { get; set; }
public string? MaPhongBan { get; set; }
public string? MaNhom { get; set; }
public string? Ketluansaucung { get; set; }
public DateTime? Ngaybatdauvaolam { get; set; }
public string? Ghichu { get; set; }

        public NS_THONGTINUNGVIEN()
        {
        }
    }
}

