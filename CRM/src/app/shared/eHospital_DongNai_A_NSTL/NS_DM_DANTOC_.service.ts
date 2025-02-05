import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_DM_DANTOC_ } from './NS_DM_DANTOC_.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_DM_DANTOC_Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MaDantoc', 'TenDantoc'];

    List: NS_DM_DANTOC_[] | undefined;
    ListFilter: NS_DM_DANTOC_[] | undefined;
    FormData!: NS_DM_DANTOC_;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_DM_DANTOC_";
    }
}

