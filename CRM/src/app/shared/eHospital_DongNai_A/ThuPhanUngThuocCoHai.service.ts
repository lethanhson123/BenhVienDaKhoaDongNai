import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ThuPhanUngThuocCoHai } from './ThuPhanUngThuocCoHai.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ThuPhanUngThuocCoHaiService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'PhanUngThuocCoHai_Id', 'SoPhieu', 'BenhNhan_Id', 'CanNang', 'PhanUngNhanXet', 'ChanDoan_ChiDinh_DieuTri', 'TaiSuDungThuoc_TrieuChungCuLapLai', 'TaiSuDungThuoc_KhongXuatHienTrieuChungCu', 'CacBenhSuLienQuan', 'SuLyADR_NgungDungThuoc_TienTrienTot', 'SuLyADR_NgungDungThuoc_KhongTienTrien', 'SuLyADR_NgungDungThuoc_TiepTucDieuTri', 'SuLyADR_NgungDungThuoc_KhongBiet', 'SuLyADR_SuDungCacThuoc_TienTrienTot', 'SuLyADR_SuDungCacThuoc_KhongTienTrien', 'SuLyADR_SuDungCacThuoc_TiepTucDieuTri', 'SuLyADR_SuDungCacThuoc_KhongBiet', 'KetQuaSauKhiXuLyADR_PhucHoi', 'KetQuaSauKhiXuLyADR_PhucHoi2', 'KetQuaSauKhiXuLyADR_KhongPhucHoi', 'KetQuaSauKhiXuLyADR_ChetDoADR', 'KetQuaSauKhiXuLyADR_ChetKhongDoThuoc', 'KetQuaSauKhiXuLyADR_KhongXacDinh', 'BinhLuanBacSiDieuTri', 'DanhGiaADR_DonViYTe_ChacChan', 'DanhGiaADR_DonViYTe_CoKhaNang', 'DanhGiaADR_DonViYTe_CoThe', 'DanhGiaADR_DonViYTe_KhongCoChacChan', 'DanhGiaADR_ChuyenGia_ChacChan', 'DanhGiaADR_ChuyenGia_CoKhaNang', 'DanhGiaADR_ChuyenGia_CoThe', 'DanhGiaADR_ChuyenGia_KhongCoChacChan', 'YKienChuyenGiaThamDinh', 'NguoiLap_Id', 'SoDienThoai_NguoiLap', 'Email_NguoiLap', 'NgayLapBaoCao', 'ChucVu_Id', 'SoFax', 'DangBaoCao', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'CacXetNghiem', 'NgayXuatHienPhanUng', 'ThoiGianPhanUng', 'MucDo_TuVong', 'MucDo_DeDoa', 'MucDo_NhapVien', 'MucDo_TanTat', 'MucDo_DiTat', 'MucDo_KhongNghiemTrong', 'KetQua_DangHoiPhuc', 'DanhGia_ChuaPhanLoai', 'DanhGia_KhongThePhanLoai', 'DanhGia_Khac', 'DanhGia_Khac_Text', 'DonVi_WHO', 'DonVi_Naranjo', 'DonVi_Khac', 'DonVi_Khac_Text', 'LanDau', 'BoSung', 'DI_GuiXacNhan', 'DI_SPC_CSDL', 'DI_PhanLoaiPhanUng', 'DI_NhapDuLieu_CSDL', 'DI_NhapDuLieu_Vigiflow', 'DI_ThuocMoi', 'DI_NghiemTrong', 'DI_ThuocCu', 'DI_KhongNghiemTrong', 'DI_DeDoaTinhMang', 'DI_NhapVien', 'DI_GayDiTat', 'DI_LamDung', 'DI_GuiBaoCao', 'DI_UMC', 'DI_GuiBaoCao_NgayGui', 'DI_UMC_NgayGui', 'DI_ChacChan', 'DI_CoKhaNang', 'DI_CoThe', 'DI_KhongChacChan', 'DI_ChuaPhanLoai', 'DI_KhongThePhanLoai', 'DI_Khac', 'DI_Khac_Text', 'DI_NguoiQuanLy_Id', 'DI_Ngay'];

    List: ThuPhanUngThuocCoHai[] | undefined;
    ListFilter: ThuPhanUngThuocCoHai[] | undefined;
    FormData!: ThuPhanUngThuocCoHai;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ThuPhanUngThuocCoHai";
    }
}

