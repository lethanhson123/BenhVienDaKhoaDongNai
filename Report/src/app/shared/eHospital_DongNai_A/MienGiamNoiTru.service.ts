import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { MienGiamNoiTru } from './MienGiamNoiTru.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class MienGiamNoiTruService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MienGiam_Id', 'MaMienGiam', 'SoPhieuMienGiam', 'BenhAn_Id', 'BenhNhan_Id', 'GiaTri', 'NgayLap', 'NguoiLap_Id', 'GhiChu', 'NguoiTao_Id', 'NgayTao', 'NguoiCapNhat_Id', 'NgayCapNhat', 'Huy', 'LyDo_ID'];

    List: MienGiamNoiTru[] | undefined;
    ListFilter: MienGiamNoiTru[] | undefined;
    FormData!: MienGiamNoiTru;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "MienGiamNoiTru";
    }
}

