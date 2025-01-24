namespace Data_eHospital_DongNai_A.Model
{
    public partial class XacNhanChiPhiBHTNChiTiet : BaseModel
    {
        [Key]
        public int? XacNhanChiPhiChiTiet_Id { get; set; }
public int? XacNhanChiPhi_Id { get; set; }
public int? GhiNhanChiTiet_Id { get; set; }
public decimal? TongGiaTri { get; set; }
public decimal? TyLe { get; set; }
public decimal? GiaTri { get; set; }
public int? IDRef { get; set; }
public decimal? SoLuong { get; set; }
public string? Loai_IDRef { get; set; }
public int? NoiDung_ID { get; set; }
public string? LoaiNoiDung { get; set; }
public decimal? GiaTriGhiNhan_ChenhLech { get; set; }
public decimal? GiaTriGhiNhan_HoTroChenhLech { get; set; }
public decimal? GiaTriGhiNhan_CoPhan { get; set; }
public string? LoaiGia { get; set; }
public decimal? GiaTriThanhToan_ChenhLech { get; set; }
public decimal? GiaTriThanhToan_HoTroChenhLech { get; set; }
public decimal? GiaTriThanhToan_CoPhan { get; set; }
public decimal? DonGiaDoanhThu { get; set; }
public decimal? DonGiaHoTro { get; set; }
public decimal? DonGiaBHTN { get; set; }
public decimal? DonGiaThanhToan { get; set; }

        public XacNhanChiPhiBHTNChiTiet()
        {
        }
    }
}

