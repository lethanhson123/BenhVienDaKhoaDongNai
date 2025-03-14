import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ThongTinDieuTriHIV } from './ThongTinDieuTriHIV.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ThongTinDieuTriHIVService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ThongTinDieuTriHIV_Id', 'SoPhieu', 'BenhAn_Id', 'TiepNhan_Id', 'BenhNhan_Id', 'LoaiBenhNhan_Id', 'LyDoDieuTri_Id', 'NgayKhangDinhHIV', 'NgayBatDauDieuTri', 'PhacDoDieuTriBD', 'PhacDoDieuTriBD_Bac_Id', 'PhacDoDieuTri', 'PhacDoDieuTri_Bac_Id', 'XetNghiem_NgayXN', 'XetNghiem_NgayKQ', 'XetNghiem_LyDo_Id', 'XetNghiem_KetQua_Id', 'DoiTuong_TE', 'DoiTuong_PhoiNhiem', 'DoiTuong_Lao', 'DoiTuong_MangThai', 'DoiTuong_ChuyenDa', 'DoiTuong_SauSinh', 'DoiTuong_ViemGan', 'DoiTuong_ChichMaTuy', 'DoiTuong_Khac', 'TE_XetNghiemPCR_Lan', 'TE_XetNghiemPCR_KetQua_Id', 'TE_XetNghiemPCR_NgayXN', 'TE_XetNghiemPCR_NgayKQ', 'MangThai_TuNgay', 'GhiChu', 'DieuTri_ARV', 'DieuTri_ARV_TuNgay', 'DieuTri_ARV_DenNgay', 'DieuTri_ARV_SoNgay', 'DieuTri_Lao', 'DieuTri_Lao_TuNgay', 'DieuTri_Lao_DenNgay', 'DieuTri_Lao_Loai_Id', 'DieuTri_Lao_PhacDo_Id', 'DieuTri_DuPhongLao', 'DieuTri_Cotrimoxazol', 'DieuTri_Cotrimoxazol_TuNgay', 'DieuTri_PLTMC', 'DieuTri_ViemGan', 'DieuTri_Khac', 'DuPhong', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'NoiLayMauXN_Id', 'NoiXNKhangDinh_Id', 'NoiBatDauDieuTriARV_Id', 'SangLocLao_Id', 'KetQuaDieuTriLao_Id', 'GiaiDoanLamSang_Id', 'NhomDoiTuong_Id', 'ChuyenPhacDo', 'NgayChuyenPhacDo', 'LyDoChuyenPhacDo_Id'];

    List: ThongTinDieuTriHIV[] | undefined;
    ListFilter: ThongTinDieuTriHIV[] | undefined;
    FormData!: ThongTinDieuTriHIV;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ThongTinDieuTriHIV";
    }
}

