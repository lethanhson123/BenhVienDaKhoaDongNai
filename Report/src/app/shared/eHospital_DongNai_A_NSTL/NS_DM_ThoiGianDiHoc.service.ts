import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_DM_ThoiGianDiHoc } from './NS_DM_ThoiGianDiHoc.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_DM_ThoiGianDiHocService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ThoiGianDiHoc_Id', 'Ma', 'Ten', 'GhiChu', 'Enable'];

    List: NS_DM_ThoiGianDiHoc[] | undefined;
    ListFilter: NS_DM_ThoiGianDiHoc[] | undefined;
    FormData!: NS_DM_ThoiGianDiHoc;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_DM_ThoiGianDiHoc";
    }
}

