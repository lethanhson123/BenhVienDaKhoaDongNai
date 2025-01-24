import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { MienGiam } from './MienGiam.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class MienGiamService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MienGiam_Id', 'MaMienGiam', 'SoPhieuMienGiam', 'TiepNhan_Id', 'BenhNhan_Id', 'GiaTri', 'NgayLap', 'NguoiLap_Id', 'GhiChu', 'NguoiTao_Id', 'NgayTao', 'NguoiCapNhat_Id', 'NgayCapNhat', 'ThoiGianLap', 'LyDo_ID'];

    List: MienGiam[] | undefined;
    ListFilter: MienGiam[] | undefined;
    FormData!: MienGiam;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "MienGiam";
    }
}

