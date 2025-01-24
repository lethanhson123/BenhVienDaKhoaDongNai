namespace Data_eHospital_DongNai_A.Model
{
    public partial class BENHANNGOAITRU_TOATHUOC : BaseModel
    {
        [Key]
        public int? TOATHUOC_ID { get; set; }
public string? SOTHUTUTOA { get; set; }
public int? KHAMBENH_ID { get; set; }
public int? DUOC_ID { get; set; }
public decimal? SOLUONG { get; set; }
public int? SONGAY { get; set; }
public int? SOLANTRENNGAY { get; set; }
public decimal? SOLUONGTRENLAN { get; set; }
public decimal? SOLUONG_BUOISANG { get; set; }
public decimal? SOLUONG_BUOITRUA { get; set; }
public decimal? SOLUONG_BUOICHIEU { get; set; }
public decimal? SOLUONG_BUOITOI { get; set; }
public int? DUONGDUNG_ID { get; set; }
public decimal? DONGIADOANHTHU { get; set; }
public decimal? DONGIAHOTRO { get; set; }
public decimal? DONGIAHOTROCHITRA { get; set; }
public decimal? DONGIATHANHTOAN { get; set; }
public string? TIENTE_ID { get; set; }
public decimal? TYGIA { get; set; }
public bool? HUYTOATHUOC { get; set; }
public string? GHICHU { get; set; }
public string? TRANGTHAI { get; set; }
public DateTime? NGAYTAO { get; set; }
public int? NGUOITAO_ID { get; set; }
public DateTime? NGAYCAPNHAT { get; set; }
public int? NGUOICAPNHAT_ID { get; set; }
public int? IDX { get; set; }
public int? LOAIGIA_ID { get; set; }
public int? NGUONHANG_ID { get; set; }
public decimal? GIATRIMIENGIAM { get; set; }
public decimal? GIATRITHATTHU { get; set; }
public decimal? GIATRITHANHTOAN { get; set; }
public bool? GIATRIDATHANHTOAN { get; set; }
public bool? DATHANHTOAN_MOTPHAN { get; set; }
public bool? DATHANHTOAN_HOANTAT { get; set; }
public bool? PHATSINHHOADON { get; set; }
public bool? MIENPHI { get; set; }
public bool? TINHTIEN { get; set; }
public string? ATTRIBUTE_1 { get; set; }
public string? ATTRIBUTE_2 { get; set; }
public int? ATTRIBUTE_3 { get; set; }
public int? ATTRIBUTE_4 { get; set; }
public bool? ATTRIBUTE_5 { get; set; }
public DateTime? ATTRIBUTE_6 { get; set; }
public decimal? DonGiaChenhLech { get; set; }
public decimal? DonGiaHoTroChenhLech { get; set; }
public decimal? GiaTriDaThanhToan_ChenhLech { get; set; }
public decimal? GiaTriDaThanhToan_HoTroChenhLech { get; set; }
public int? BangGia_Id { get; set; }
public string? TyLeVAT { get; set; }
public string? GiaTriVAT { get; set; }
public int? NguonDuoc_Id { get; set; }
public int? PhieuLinh_Id { get; set; }
public int? ChungTu_Id { get; set; }
public decimal? SoTienThucTe { get; set; }
public string? NguonLayThuoc { get; set; }
public bool? MuaNgoai { get; set; }
public bool? PhatThuocTaiQuay { get; set; }
public int? KhoPhat_Id { get; set; }

        public BENHANNGOAITRU_TOATHUOC()
        {
        }
    }
}

