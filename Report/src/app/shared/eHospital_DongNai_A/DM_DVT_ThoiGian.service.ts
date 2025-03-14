import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_DVT_ThoiGian } from './DM_DVT_ThoiGian.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_DVT_ThoiGianService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'DVT_ThoiGian_Id', 'MaDonViTinh', 'TenDonViTinh'];

    List: DM_DVT_ThoiGian[] | undefined;
    ListFilter: DM_DVT_ThoiGian[] | undefined;
    FormData!: DM_DVT_ThoiGian;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_DVT_ThoiGian";
    }
}

