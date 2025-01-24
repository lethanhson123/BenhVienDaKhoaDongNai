namespace Data_eHospital_DongNai_A.Model
{
    public partial class Transfer_VienPhi_ChiTiet_Temp : BaseModel
    {
        [Key]
        public int? IDSession { get; set; }
public int? BenhNhan_Id { get; set; }
public DateTime? NgayChungTu { get; set; }
public int? IDRef { get; set; }
public string? Loai_IDRef { get; set; }
public string? LoaiNoiDung { get; set; }
public int? NoiDung_Id { get; set; }
public decimal? SoLuong { get; set; }
public decimal? ThanhTien { get; set; }
public string? MaYTe { get; set; }
public string? TenBenhNhan { get; set; }
public string? DiaChi { get; set; }

        public Transfer_VienPhi_ChiTiet_Temp()
        {
        }
    }
}

