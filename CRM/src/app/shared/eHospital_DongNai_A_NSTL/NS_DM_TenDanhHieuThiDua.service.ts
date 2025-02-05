import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_DM_TenDanhHieuThiDua } from './NS_DM_TenDanhHieuThiDua.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_DM_TenDanhHieuThiDuaService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Ma', 'TenDanhHieu', 'Diem', 'GhiChu'];

    List: NS_DM_TenDanhHieuThiDua[] | undefined;
    ListFilter: NS_DM_TenDanhHieuThiDua[] | undefined;
    FormData!: NS_DM_TenDanhHieuThiDua;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_DM_TenDanhHieuThiDua";
    }
}

