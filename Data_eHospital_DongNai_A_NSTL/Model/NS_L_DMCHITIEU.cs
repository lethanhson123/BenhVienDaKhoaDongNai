namespace Data_eHospital_DongNai_A_NSTL.Model
{
    public partial class NS_L_DMCHITIEU : BaseModel
    {
        [Key]
        public string? MaChiTieu { get; set; }
public string? TenChiTieu { get; set; }
public string? CongThuc { get; set; }
public float? GiaTri { get; set; }
public int? ThuTuTinhToan { get; set; }
public int? ThuTuTrenBaoCaoLuong { get; set; }
public bool? HienThiHayKhong { get; set; }
public int? ThuTuSapXep { get; set; }
public string? LoaiChiTieu { get; set; }
public int? ThuTuTrenPhieuLuong { get; set; }
public string? TinhChat { get; set; }
public bool? ChuyenThangSau { get; set; }

        public NS_L_DMCHITIEU()
        {
        }
    }
}

