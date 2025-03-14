import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_DM_PHONGBAN_ } from './NS_DM_PHONGBAN_.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_DM_PHONGBAN_Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MaPhongBan', 'TenPhongBan', 'ThuTuSapXep'];

    List: NS_DM_PHONGBAN_[] | undefined;
    ListFilter: NS_DM_PHONGBAN_[] | undefined;
    FormData!: NS_DM_PHONGBAN_;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_DM_PHONGBAN_";
    }
}

