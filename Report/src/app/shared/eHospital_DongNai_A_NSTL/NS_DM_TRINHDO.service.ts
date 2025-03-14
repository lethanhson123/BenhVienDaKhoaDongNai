import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_DM_TRINHDO } from './NS_DM_TRINHDO.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_DM_TRINHDOService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MaTrinhdo', 'TenTrinhDo', 'TrinhDo_Id'];

    List: NS_DM_TRINHDO[] | undefined;
    ListFilter: NS_DM_TRINHDO[] | undefined;
    FormData!: NS_DM_TRINHDO;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_DM_TRINHDO";
    }
}

