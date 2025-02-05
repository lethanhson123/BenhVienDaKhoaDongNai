import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_DM_LoaiTruc_NgoaiGio } from './NS_DM_LoaiTruc_NgoaiGio.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_DM_LoaiTruc_NgoaiGioService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'LoaiTruc_Id', 'MaLoaiTruc', 'TenLoaiTruc', 'GhiChu', 'TamNgung'];

    List: NS_DM_LoaiTruc_NgoaiGio[] | undefined;
    ListFilter: NS_DM_LoaiTruc_NgoaiGio[] | undefined;
    FormData!: NS_DM_LoaiTruc_NgoaiGio;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_DM_LoaiTruc_NgoaiGio";
    }
}

