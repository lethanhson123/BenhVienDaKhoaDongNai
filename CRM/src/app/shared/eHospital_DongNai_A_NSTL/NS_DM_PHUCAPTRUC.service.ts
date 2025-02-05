import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_DM_PHUCAPTRUC } from './NS_DM_PHUCAPTRUC.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_DM_PHUCAPTRUCService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'MaKhoa', 'TiLeThuong'];

    List: NS_DM_PHUCAPTRUC[] | undefined;
    ListFilter: NS_DM_PHUCAPTRUC[] | undefined;
    FormData!: NS_DM_PHUCAPTRUC;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_DM_PHUCAPTRUC";
    }
}

