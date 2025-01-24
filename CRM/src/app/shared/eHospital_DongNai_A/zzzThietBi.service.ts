import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { zzzThietBi } from './zzzThietBi.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class zzzThietBiService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MaThietBi', 'TenThietBi', 'NhomThietBi_Id', 'SoSeri', 'MaMay'];

    List: zzzThietBi[] | undefined;
    ListFilter: zzzThietBi[] | undefined;
    FormData!: zzzThietBi;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "zzzThietBi";
    }
}

