import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_DM_TINH } from './NS_DM_TINH.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_DM_TINHService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MaTinh', 'TenTinh', 'DangSuDung'];

    List: NS_DM_TINH[] | undefined;
    ListFilter: NS_DM_TINH[] | undefined;
    FormData!: NS_DM_TINH;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_DM_TINH";
    }
}

