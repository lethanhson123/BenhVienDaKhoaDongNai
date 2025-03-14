import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_DM_CaTruc } from './NS_DM_CaTruc.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_DM_CaTrucService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'CaTruc_Id', 'TenCaTruc', 'ThoiGianBatDau', 'ThoiGianKetThuc', 'GhiChu', 'TamNgung', 'Truc'];

    List: NS_DM_CaTruc[] | undefined;
    ListFilter: NS_DM_CaTruc[] | undefined;
    FormData!: NS_DM_CaTruc;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_DM_CaTruc";
    }
}

