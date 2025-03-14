import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_DM_TRINHDONGOAINGU } from './NS_DM_TRINHDONGOAINGU.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_DM_TRINHDONGOAINGUService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MaTDNgoaiNgu', 'TenNgoaiNgu'];

    List: NS_DM_TRINHDONGOAINGU[] | undefined;
    ListFilter: NS_DM_TRINHDONGOAINGU[] | undefined;
    FormData!: NS_DM_TRINHDONGOAINGU;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_DM_TRINHDONGOAINGU";
    }
}

