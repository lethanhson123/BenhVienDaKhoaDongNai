namespace Data_eHospital_DongNai_A.Model
{
    public partial class Transfer_VienPhi : BaseModel
    {
        [Key]
        public int? Transfer_VienPhi_Id { get; set; }
public int? IDSession { get; set; }
public int? Status { get; set; }
public string? NguonBenhNhan { get; set; }
public int? BenhNhan_Id { get; set; }
public string? MaYTe { get; set; }
public string? TenBenhNhan { get; set; }
public string? DiaChi { get; set; }
public DateTime? NgayChungTu { get; set; }
public string? TrangThai { get; set; }
public int? SoHoaDon { get; set; }
public string? SoSeri { get; set; }
public decimal? TongTien { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public string? SoChungtuKeToan { get; set; }

        public Transfer_VienPhi()
        {
        }
    }
}

