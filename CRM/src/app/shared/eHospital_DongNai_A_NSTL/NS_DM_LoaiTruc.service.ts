import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_DM_LoaiTruc } from './NS_DM_LoaiTruc.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_DM_LoaiTrucService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'LoaiTruc_Id', 'MaLoaiTruc', 'TenLoaiTruc', 'GhiChu', 'TamNgung'];

    List: NS_DM_LoaiTruc[] | undefined;
    ListFilter: NS_DM_LoaiTruc[] | undefined;
    FormData!: NS_DM_LoaiTruc;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_DM_LoaiTruc";
    }
}

