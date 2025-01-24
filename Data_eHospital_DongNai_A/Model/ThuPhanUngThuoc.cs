namespace Data_eHospital_DongNai_A.Model
{
    public partial class ThuPhanUngThuoc : BaseModel
    {
        [Key]
        public int? PhanUngThuoc_Id { get; set; }
public string? SoPhieu { get; set; }
public int? BenhAn_Id { get; set; }
public int? LuuTru_Id { get; set; }
public DateTime? NgayThucHien { get; set; }
public DateTime? ThoiGianThucHien { get; set; }
public string? ChanDoan { get; set; }
public string? KetQua { get; set; }
public bool? DuongTinh { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public int? PhuongPhapThu_Id { get; set; }
public int? NguoiThucHien_Id { get; set; }
public int? BacSiKiemTra_Id { get; set; }
public int? Duoc_Id { get; set; }
public string? SoLo { get; set; }
public string? SoSanXuat { get; set; }
public int? BacSiChiDinh_Id { get; set; }
public DateTime? NgayDocKetQua { get; set; }
public DateTime? ThoiGianDocKetQua { get; set; }
public bool? AmTinh { get; set; }

        public ThuPhanUngThuoc()
        {
        }
    }
}

