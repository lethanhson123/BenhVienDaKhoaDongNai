import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { zzzTrangThietBi_1 } from './zzzTrangThietBi_1.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class zzzTrangThietBi_1Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'STT', 'MaTB', 'TenThietBi', 'MA_MAY'];

    List: zzzTrangThietBi_1[] | undefined;
    ListFilter: zzzTrangThietBi_1[] | undefined;
    FormData!: zzzTrangThietBi_1;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "zzzTrangThietBi_1";
    }
}

