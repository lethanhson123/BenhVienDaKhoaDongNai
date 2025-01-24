namespace Data_eHospital_DongNai_A.Model
{
    public partial class ThanhToanTamTinh_Tracking : BaseModel
    {
        [Key]
        public int? ID { get; set; }
public int? TiepNhan_Id { get; set; }
public int? BenhNhan_Id { get; set; }
public int? IDRef { get; set; }
public string? Loai_IDRef { get; set; }
public string? DonGiaDoanhThu { get; set; }
public string? DonGiaHoTro { get; set; }
public string? DonGiaHoTroChiTra { get; set; }
public string? DonGiaThanhToan { get; set; }
public int? DoiTuong_Id { get; set; }
public string? SoLuong { get; set; }
public string? TyLe { get; set; }
public DateTime? ThoiGian { get; set; }

        public ThanhToanTamTinh_Tracking()
        {
        }
    }
}

