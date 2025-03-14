import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { GiaiPhauBenhSinhThiet } from './GiaiPhauBenhSinhThiet.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class GiaiPhauBenhSinhThietService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'GiaiPhauBenhSinhThiet_Id', 'SoPhieu', 'CLSYeuCau_Id', 'TiepNhan_Id', 'BenhAn_Id', 'BacSiDieuTri_Id', 'TruongHopGiaiPhauBenh', 'SinhThietDuocLayTu', 'CoDinhBangDungDich', 'Luc', 'TomTatDauHieuLSXN', 'QuaTrinhDieuTri', 'NhanXetDaiTheKhiLayST', 'KetQuaSinhThietLanTruoc', 'ChanDoanLamSang', 'NguoiTao_Id', 'NgayTao', 'NguoiCapNhat_Id', 'NgayCapNhat', 'NguoiCoDinh_Id'];

    List: GiaiPhauBenhSinhThiet[] | undefined;
    ListFilter: GiaiPhauBenhSinhThiet[] | undefined;
    FormData!: GiaiPhauBenhSinhThiet;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "GiaiPhauBenhSinhThiet";
    }
}

