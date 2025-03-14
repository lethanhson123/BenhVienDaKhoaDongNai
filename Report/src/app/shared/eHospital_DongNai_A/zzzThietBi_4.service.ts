import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { zzzThietBi_4 } from './zzzThietBi_4.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class zzzThietBi_4Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MaThietBi', 'TenThietBi', 'MaMay', 'NhomThietBi_id'];

    List: zzzThietBi_4[] | undefined;
    ListFilter: zzzThietBi_4[] | undefined;
    FormData!: zzzThietBi_4;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "zzzThietBi_4";
    }
}

