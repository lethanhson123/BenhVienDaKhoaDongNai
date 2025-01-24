namespace Data_eHospital_DongNai_A.Model
{
    public partial class GiaiPhauBenhSinhThiet_KetQua : BaseModel
    {
        [Key]
        public int? GiaiPhauBenhSinhThiet_KetQua_Id { get; set; }
public int? GiaiPhauBenhSinhThiet_Id { get; set; }
public int? NguoiPhaBenhPham_Id { get; set; }
public DateTime? PhaNgay { get; set; }
public int? SoManh { get; set; }
public string? PhuongPhapNhuom { get; set; }
public DateTime? NgayLamXongTieuBan { get; set; }
public int? NguoiLamTieuBan_Id { get; set; }
public string? NhanXetDaiThe { get; set; }
public string? NhanXetViThe { get; set; }
public string? ChanDoanGiaiPhauBenh { get; set; }
public string? SuPhuHopVoiChanDoanLS { get; set; }
public int? BacSiDocKetQua_Id { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public string? MaLam { get; set; }
public int? BacSiCatLoc_Id { get; set; }
public DateTime? NgayCatLoc { get; set; }
public int? KTVPhu_Id { get; set; }

        public GiaiPhauBenhSinhThiet_KetQua()
        {
        }
    }
}

