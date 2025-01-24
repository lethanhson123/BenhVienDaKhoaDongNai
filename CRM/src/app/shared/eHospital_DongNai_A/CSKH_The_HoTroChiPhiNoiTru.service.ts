import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CSKH_The_HoTroChiPhiNoiTru } from './CSKH_The_HoTroChiPhiNoiTru.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CSKH_The_HoTroChiPhiNoiTruService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'The_HoTroChiPhiNoiTru_Id', 'The_Id', 'LoaiKhachHang_Id', 'SoTienToiDa', 'SoTienNamVien', 'SoNgayNamVien', 'Phong', 'Thuoc', 'XetNghiem', 'DieuTriTrongNgay', 'SoTienPhauThuat', 'SoNgayPhauThuat', 'PhauThuat', 'VatTuTieuHao', 'GayMe', 'KhamTruocPT', 'HoiSucSauPT', 'ThoiGianMin', 'ThoiGianMax', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'Attributes_1', 'Attributes_2', 'Attributes_3', 'Attributes_4', 'Attributes_5', 'Attributes_6', 'Attributes_7', 'Attributes_8'];

    List: CSKH_The_HoTroChiPhiNoiTru[] | undefined;
    ListFilter: CSKH_The_HoTroChiPhiNoiTru[] | undefined;
    FormData!: CSKH_The_HoTroChiPhiNoiTru;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CSKH_The_HoTroChiPhiNoiTru";
    }
}

