import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ztmp_BCTN_021100 } from './ztmp_BCTN_021100.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ztmp_BCTN_021100Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'TenBenhNhan', 'NgaySinh', 'd1', 'GioiTinh', 'NgayXuatHienPhanUng', 'ThoiGianPhanUng', 'MoTaPhanUngNhanXet', 'CacXetNghiem', 'TienSu', 'CachXuTri', 'MucDo_TuVong', 'MucDo_NhapVien', 'MucDo_DeDoa', 'MucDo_TanTat', 'MucDo_DiTat', 'MucDo_Khong', 'KetQua_TuVongDoADR', 'KetQua_TuVongKhongDoADR', 'KetQua_ChuaHoiPhuc', 'KetQua_DangHoiPhuc', 'KetQua_HoiPhucCoDiChung', 'KetQua_HoiPhucKoDiChung', 'KetQua_KhongRo', 'Ngung_Co', 'Ngung_Khong', 'Ngung_Giam', 'Ngung_KoThongTin', 'TaiSD_Co', 'TaiSD_Khong', 'TaiSD_KhongTSD', 'TaiSD_KoThongTin', 'DanhGia_ChacChan', 'DanhGia_CoKhaNang', 'DanhGia_CoThe', 'DanhGia_KhongChacChan', 'DanhGia_ChuaPhanLoai', 'DanhGia_KhongThePhanLoai', 'DanhGia_Khac', 'DanhGia_Khac_Text', 'DonVi_WHO', 'DonVi_Naranjo', 'DonVi_Khac', 'DonVi_Khac_Text', 'PhanBinhLuan', 'BC_HoTen', 'BC_NgheNghiep', 'BC_DienThoai', 'BC_LanDau', 'BC_BoSung', 'BC_Ngay', 'Email', 'DI_GuiXacNhan', 'DI_SPC_CSDL', 'DI_PhanLoaiPhanUng', 'DI_NhapDuLieu_CSDL', 'DI_NhapDuLieu_Vigiflow', 'DI_ThuocMoi', 'DI_NghiemTrong', 'DI_ThuocCu', 'DI_KhongNghiemTrong', 'DI_DeDoaTinhMang', 'DI_NhapVien', 'DI_GayDiTat', 'DI_LamDung', 'DI_GuiBaoCao', 'DI_UMC', 'DI_GuiBaoCao_NgayGui', 'DI_UMC_NgayGui', 'DI_ChacChan', 'DI_CoKhaNang', 'DI_CoThe', 'DI_KhongChacChan', 'DI_ChuaPhanLoai', 'DI_KhongThePhanLoai', 'DI_Khac', 'DI_Khac_Text', 'DI_NguoiQuanLy_Id', 'DI_NguoiQuanLy', 'DI_Ngay', 'CanNang'];

    List: ztmp_BCTN_021100[] | undefined;
    ListFilter: ztmp_BCTN_021100[] | undefined;
    FormData!: ztmp_BCTN_021100;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ztmp_BCTN_021100";
    }
}

