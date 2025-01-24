namespace Data_eHospital_DongNai_A.Model
{
    public partial class ThuPhanUngThuocCoHai : BaseModel
    {
        [Key]
        public int? PhanUngThuocCoHai_Id { get; set; }
public string? SoPhieu { get; set; }
public int? BenhNhan_Id { get; set; }
public int? CanNang { get; set; }
public string? PhanUngNhanXet { get; set; }
public string? ChanDoan_ChiDinh_DieuTri { get; set; }
public bool? TaiSuDungThuoc_TrieuChungCuLapLai { get; set; }
public bool? TaiSuDungThuoc_KhongXuatHienTrieuChungCu { get; set; }
public string? CacBenhSuLienQuan { get; set; }
public bool? SuLyADR_NgungDungThuoc_TienTrienTot { get; set; }
public bool? SuLyADR_NgungDungThuoc_KhongTienTrien { get; set; }
public bool? SuLyADR_NgungDungThuoc_TiepTucDieuTri { get; set; }
public bool? SuLyADR_NgungDungThuoc_KhongBiet { get; set; }
public bool? SuLyADR_SuDungCacThuoc_TienTrienTot { get; set; }
public bool? SuLyADR_SuDungCacThuoc_KhongTienTrien { get; set; }
public bool? SuLyADR_SuDungCacThuoc_TiepTucDieuTri { get; set; }
public bool? SuLyADR_SuDungCacThuoc_KhongBiet { get; set; }
public bool? KetQuaSauKhiXuLyADR_PhucHoi { get; set; }
public bool? KetQuaSauKhiXuLyADR_PhucHoi2 { get; set; }
public bool? KetQuaSauKhiXuLyADR_KhongPhucHoi { get; set; }
public bool? KetQuaSauKhiXuLyADR_ChetDoADR { get; set; }
public bool? KetQuaSauKhiXuLyADR_ChetKhongDoThuoc { get; set; }
public bool? KetQuaSauKhiXuLyADR_KhongXacDinh { get; set; }
public string? BinhLuanBacSiDieuTri { get; set; }
public bool? DanhGiaADR_DonViYTe_ChacChan { get; set; }
public bool? DanhGiaADR_DonViYTe_CoKhaNang { get; set; }
public bool? DanhGiaADR_DonViYTe_CoThe { get; set; }
public bool? DanhGiaADR_DonViYTe_KhongCoChacChan { get; set; }
public bool? DanhGiaADR_ChuyenGia_ChacChan { get; set; }
public bool? DanhGiaADR_ChuyenGia_CoKhaNang { get; set; }
public bool? DanhGiaADR_ChuyenGia_CoThe { get; set; }
public bool? DanhGiaADR_ChuyenGia_KhongCoChacChan { get; set; }
public string? YKienChuyenGiaThamDinh { get; set; }
public int? NguoiLap_Id { get; set; }
public string? SoDienThoai_NguoiLap { get; set; }
public string? Email_NguoiLap { get; set; }
public DateTime? NgayLapBaoCao { get; set; }
public int? ChucVu_Id { get; set; }
public string? SoFax { get; set; }
public string? DangBaoCao { get; set; }
public DateTime? NgayTao { get; set; }
public int? NguoiTao_Id { get; set; }
public DateTime? NgayCapNhat { get; set; }
public int? NguoiCapNhat_Id { get; set; }
public string? CacXetNghiem { get; set; }
public DateTime? NgayXuatHienPhanUng { get; set; }
public string? ThoiGianPhanUng { get; set; }
public bool? MucDo_TuVong { get; set; }
public bool? MucDo_DeDoa { get; set; }
public bool? MucDo_NhapVien { get; set; }
public bool? MucDo_TanTat { get; set; }
public bool? MucDo_DiTat { get; set; }
public bool? MucDo_KhongNghiemTrong { get; set; }
public bool? KetQua_DangHoiPhuc { get; set; }
public bool? DanhGia_ChuaPhanLoai { get; set; }
public bool? DanhGia_KhongThePhanLoai { get; set; }
public bool? DanhGia_Khac { get; set; }
public string? DanhGia_Khac_Text { get; set; }
public bool? DonVi_WHO { get; set; }
public bool? DonVi_Naranjo { get; set; }
public bool? DonVi_Khac { get; set; }
public string? DonVi_Khac_Text { get; set; }
public bool? LanDau { get; set; }
public bool? BoSung { get; set; }
public bool? DI_GuiXacNhan { get; set; }
public bool? DI_SPC_CSDL { get; set; }
public bool? DI_PhanLoaiPhanUng { get; set; }
public bool? DI_NhapDuLieu_CSDL { get; set; }
public bool? DI_NhapDuLieu_Vigiflow { get; set; }
public bool? DI_ThuocMoi { get; set; }
public bool? DI_NghiemTrong { get; set; }
public bool? DI_ThuocCu { get; set; }
public bool? DI_KhongNghiemTrong { get; set; }
public bool? DI_DeDoaTinhMang { get; set; }
public bool? DI_NhapVien { get; set; }
public bool? DI_GayDiTat { get; set; }
public bool? DI_LamDung { get; set; }
public bool? DI_GuiBaoCao { get; set; }
public bool? DI_UMC { get; set; }
public DateTime? DI_GuiBaoCao_NgayGui { get; set; }
public DateTime? DI_UMC_NgayGui { get; set; }
public bool? DI_ChacChan { get; set; }
public bool? DI_CoKhaNang { get; set; }
public bool? DI_CoThe { get; set; }
public bool? DI_KhongChacChan { get; set; }
public bool? DI_ChuaPhanLoai { get; set; }
public bool? DI_KhongThePhanLoai { get; set; }
public bool? DI_Khac { get; set; }
public string? DI_Khac_Text { get; set; }
public int? DI_NguoiQuanLy_Id { get; set; }
public DateTime? DI_Ngay { get; set; }

        public ThuPhanUngThuocCoHai()
        {
        }
    }
}

