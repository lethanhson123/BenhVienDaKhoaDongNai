import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { MienGiamNoiTruChiTiet } from './MienGiamNoiTruChiTiet.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class MienGiamNoiTruChiTietService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MienGiamNoiTruChiTiet_Id', 'MienGiam_ID', 'YeuCauChiTiet_Id', 'GiaTriNoiDungMienGiam', 'TyLeMienGiam', 'GiaTriMienGiam', 'LyDoMienGiam_Id', 'GhiChu', 'IDRef', 'Loai_IDRef', 'NoiDung_Id', 'LoaiNoiDung', 'GiaTriMienGiam_ChenhLech', 'GiaTriMienGiam_HoTroChenhLech', 'GiaTriMienGiam_CoPhan', 'SoLuongMienGiam'];

    List: MienGiamNoiTruChiTiet[] | undefined;
    ListFilter: MienGiamNoiTruChiTiet[] | undefined;
    FormData!: MienGiamNoiTruChiTiet;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "MienGiamNoiTruChiTiet";
    }
}

