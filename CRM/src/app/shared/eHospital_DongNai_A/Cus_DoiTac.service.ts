import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Cus_DoiTac } from './Cus_DoiTac.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Cus_DoiTacService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'DoiTac_id', 'TenDoiTac', 'Nhom', 'XuatRong', 'TamNgung'];

    List: Cus_DoiTac[] | undefined;
    ListFilter: Cus_DoiTac[] | undefined;
    FormData!: Cus_DoiTac;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Cus_DoiTac";
    }
}

