import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_DM_NGAYLE } from './NS_DM_NGAYLE.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_DM_NGAYLEService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MaNgayLe', 'Ngay', 'TenNgayLe'];

    List: NS_DM_NGAYLE[] | undefined;
    ListFilter: NS_DM_NGAYLE[] | undefined;
    FormData!: NS_DM_NGAYLE;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_DM_NGAYLE";
    }
}

