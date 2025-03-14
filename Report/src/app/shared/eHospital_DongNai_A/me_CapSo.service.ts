import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { me_CapSo } from './me_CapSo.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class me_CapSoService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KhuVuc_id', 'Cua_id', 'SoDaCap', 'ThoiGianCapSo', 'Mac_id', 'TamNgung'];

    List: me_CapSo[] | undefined;
    ListFilter: me_CapSo[] | undefined;
    FormData!: me_CapSo;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "me_CapSo";
    }
}

