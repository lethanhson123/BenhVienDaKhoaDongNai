import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_DM_LYDONGHIPHEP } from './NS_DM_LYDONGHIPHEP.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_DM_LYDONGHIPHEPService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MaLyDoNghiPhep', 'TenLyDoNghiPhep'];

    List: NS_DM_LYDONGHIPHEP[] | undefined;
    ListFilter: NS_DM_LYDONGHIPHEP[] | undefined;
    FormData!: NS_DM_LYDONGHIPHEP;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_DM_LYDONGHIPHEP";
    }
}

