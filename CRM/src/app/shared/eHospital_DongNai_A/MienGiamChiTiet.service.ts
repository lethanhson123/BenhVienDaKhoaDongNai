import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { MienGiamChiTiet } from './MienGiamChiTiet.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class MienGiamChiTietService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MienGiamChiTiet_Id', 'MienGiam_ID', 'YeuCauChiTiet_Id', 'GiaTriNoiDungMienGiam', 'TyLeMienGiam', 'GiaTriMienGiam', 'LyDoMienGiam_Id', 'GhiChu', 'IDRef', 'Loai_IDRef', 'NoiDung_ID', 'LoaiNoiDung', 'GiaTriMienGiam_ChenhLech', 'GiaTriMienGiam_HoTroChenhLech', 'GiaTriMienGiam_CoPhan', 'LoaiGia'];

    List: MienGiamChiTiet[] | undefined;
    ListFilter: MienGiamChiTiet[] | undefined;
    FormData!: MienGiamChiTiet;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "MienGiamChiTiet";
    }
}

