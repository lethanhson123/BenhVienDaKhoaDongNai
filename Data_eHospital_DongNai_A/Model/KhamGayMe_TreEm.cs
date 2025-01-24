namespace Data_eHospital_DongNai_A.Model
{
    public partial class KhamGayMe_TreEm : BaseModel
    {
        [Key]
        public int? KhamGayMe_TreEm_Id { get; set; }
public string? SoPhieuGayMe { get; set; }
public int? BenhNhan_Id { get; set; }
public int? TiepNhan_Id { get; set; }
public int? BenhAn_Id { get; set; }
public int? CLSYeuCau_Id { get; set; }
public DateTime? NgayThucHien { get; set; }
public DateTime? ThoiGianThucHien { get; set; }
public int? BacSiGayMe_Id { get; set; }
public string? SanKhoa { get; set; }
public int? TuoiThaiLucSinh { get; set; }
public string? CanNangLucSinh { get; set; }
public int? Sinh_ID { get; set; }
public string? TinhTrangSauSinh { get; set; }
public DateTime? ThoiGianDuKienPhauThuat { get; set; }
public string? ThoiGianNhinAn { get; set; }
public string? TinhTrangVenNgoai { get; set; }
public string? EMLA { get; set; }
public string? Thuoc { get; set; }
public int? ThoiGian { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }

        public KhamGayMe_TreEm()
        {
        }
    }
}

