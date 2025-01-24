namespace Data_eHospital_DongNai_A.Model
{
    public partial class ThongTinDieuTriHIV : BaseModel
    {
        [Key]
        public int? ThongTinDieuTriHIV_Id { get; set; }
public string? SoPhieu { get; set; }
public int? BenhAn_Id { get; set; }
public int? TiepNhan_Id { get; set; }
public int? BenhNhan_Id { get; set; }
public int? LoaiBenhNhan_Id { get; set; }
public int? LyDoDieuTri_Id { get; set; }
public DateTime? NgayKhangDinhHIV { get; set; }
public DateTime? NgayBatDauDieuTri { get; set; }
public string? PhacDoDieuTriBD { get; set; }
public int? PhacDoDieuTriBD_Bac_Id { get; set; }
public string? PhacDoDieuTri { get; set; }
public int? PhacDoDieuTri_Bac_Id { get; set; }
public DateTime? XetNghiem_NgayXN { get; set; }
public DateTime? XetNghiem_NgayKQ { get; set; }
public int? XetNghiem_LyDo_Id { get; set; }
public int? XetNghiem_KetQua_Id { get; set; }
public bool? DoiTuong_TE { get; set; }
public bool? DoiTuong_PhoiNhiem { get; set; }
public bool? DoiTuong_Lao { get; set; }
public bool? DoiTuong_MangThai { get; set; }
public bool? DoiTuong_ChuyenDa { get; set; }
public bool? DoiTuong_SauSinh { get; set; }
public bool? DoiTuong_ViemGan { get; set; }
public bool? DoiTuong_ChichMaTuy { get; set; }
public bool? DoiTuong_Khac { get; set; }
public int? TE_XetNghiemPCR_Lan { get; set; }
public int? TE_XetNghiemPCR_KetQua_Id { get; set; }
public DateTime? TE_XetNghiemPCR_NgayXN { get; set; }
public DateTime? TE_XetNghiemPCR_NgayKQ { get; set; }
public DateTime? MangThai_TuNgay { get; set; }
public string? GhiChu { get; set; }
public bool? DieuTri_ARV { get; set; }
public DateTime? DieuTri_ARV_TuNgay { get; set; }
public DateTime? DieuTri_ARV_DenNgay { get; set; }
public int? DieuTri_ARV_SoNgay { get; set; }
public bool? DieuTri_Lao { get; set; }
public DateTime? DieuTri_Lao_TuNgay { get; set; }
public DateTime? DieuTri_Lao_DenNgay { get; set; }
public int? DieuTri_Lao_Loai_Id { get; set; }
public int? DieuTri_Lao_PhacDo_Id { get; set; }
public bool? DieuTri_DuPhongLao { get; set; }
public bool? DieuTri_Cotrimoxazol { get; set; }
public DateTime? DieuTri_Cotrimoxazol_TuNgay { get; set; }
public bool? DieuTri_PLTMC { get; set; }
public bool? DieuTri_ViemGan { get; set; }
public bool? DieuTri_Khac { get; set; }
public string? DuPhong { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public int? NoiLayMauXN_Id { get; set; }
public int? NoiXNKhangDinh_Id { get; set; }
public int? NoiBatDauDieuTriARV_Id { get; set; }
public int? SangLocLao_Id { get; set; }
public int? KetQuaDieuTriLao_Id { get; set; }
public int? GiaiDoanLamSang_Id { get; set; }
public int? NhomDoiTuong_Id { get; set; }
public bool? ChuyenPhacDo { get; set; }
public DateTime? NgayChuyenPhacDo { get; set; }
public int? LyDoChuyenPhacDo_Id { get; set; }

        public ThongTinDieuTriHIV()
        {
        }
    }
}

