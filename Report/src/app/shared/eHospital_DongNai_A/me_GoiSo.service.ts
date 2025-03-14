import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { me_GoiSo } from './me_GoiSo.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class me_GoiSoService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KhuVuc_id', 'Cua_id', 'SoDaGoi', 'TamNgung', 'NgayTao', 'Mac_id'];

    List: me_GoiSo[] | undefined;
    ListFilter: me_GoiSo[] | undefined;
    FormData!: me_GoiSo;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "me_GoiSo";
    }
}

