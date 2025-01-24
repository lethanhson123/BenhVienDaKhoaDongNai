namespace Data_eHospital_DongNai_A.Model
{
    public partial class TreSoSinh : BaseModel
    {
        [Key]
        public int? TreSoSinh_Id { get; set; }
public int? BenhAn_Id { get; set; }
public DateTime? NgaySinh { get; set; }
public DateTime? ThoiGianSinh { get; set; }
public string? GioiTinh { get; set; }
public bool? DiTat { get; set; }
public string? TatBamSinh { get; set; }
public string? ChieuCao { get; set; }
public string? CanNang { get; set; }
public string? Apgar { get; set; }
public string? QuyenSo { get; set; }
public int? TinhTrang_Id { get; set; }
public int? TinhTrangRaVien_Id { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public TreSoSinh()
        {
        }
    }
}

