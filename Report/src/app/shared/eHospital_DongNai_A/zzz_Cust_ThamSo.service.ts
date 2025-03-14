import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { zzz_Cust_ThamSo } from './zzz_Cust_ThamSo.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class zzz_Cust_ThamSoService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'TenThamSo', 'TamNgung'];

    List: zzz_Cust_ThamSo[] | undefined;
    ListFilter: zzz_Cust_ThamSo[] | undefined;
    FormData!: zzz_Cust_ThamSo;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "zzz_Cust_ThamSo";
    }
}

