import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DuocTonKho_BookNoiTru } from './DuocTonKho_BookNoiTru.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DuocTonKho_BookNoiTruService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'DuocTonKho_BookNoiTru_Id', 'PhieuLinhDuoc_Id', 'PhieuLinhDuocChiTiet_Id', 'Duoc_Id', 'KhoDuoc_Id', 'NgayHieuLuc', 'SoLuong', 'NguonHang_Id', 'KhamBenh_ID', 'KhamBenh_VTYT_ID', 'CLSYeuCau_ID', 'CLSGhiNhanHoaChat_VTYT_ID', 'BenhAnPhauThuat_ID', 'BenhAnPhauThuat_VTYT_ID', 'NoiTru_KhamBenh_ID', 'NoiTru_ToaThuoc_ID', 'HuyBook'];

    List: DuocTonKho_BookNoiTru[] | undefined;
    ListFilter: DuocTonKho_BookNoiTru[] | undefined;
    FormData!: DuocTonKho_BookNoiTru;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DuocTonKho_BookNoiTru";
    }
}

