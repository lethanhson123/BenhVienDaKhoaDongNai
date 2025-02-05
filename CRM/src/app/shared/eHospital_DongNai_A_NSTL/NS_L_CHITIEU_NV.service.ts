import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_L_CHITIEU_NV } from './NS_L_CHITIEU_NV.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_L_CHITIEU_NVService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'Nam', 'Thang', 'MaNhanVien', 'MaChiTieu', 'CongThuc', 'GiaTri'];

    List: NS_L_CHITIEU_NV[] | undefined;
    ListFilter: NS_L_CHITIEU_NV[] | undefined;
    FormData!: NS_L_CHITIEU_NV;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_L_CHITIEU_NV";
    }
}

