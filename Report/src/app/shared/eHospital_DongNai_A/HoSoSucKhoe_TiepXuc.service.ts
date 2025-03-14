import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { HoSoSucKhoe_TiepXuc } from './HoSoSucKhoe_TiepXuc.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class HoSoSucKhoe_TiepXucService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'TiepXuc_Id', 'HoSoSucKhoe_Id', 'TinhChat_Id'];

    List: HoSoSucKhoe_TiepXuc[] | undefined;
    ListFilter: HoSoSucKhoe_TiepXuc[] | undefined;
    FormData!: HoSoSucKhoe_TiepXuc;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "HoSoSucKhoe_TiepXuc";
    }
}

