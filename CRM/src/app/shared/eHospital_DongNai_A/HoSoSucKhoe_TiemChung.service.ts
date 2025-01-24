import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { HoSoSucKhoe_TiemChung } from './HoSoSucKhoe_TiemChung.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class HoSoSucKhoe_TiemChungService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'TiemChung_Id', 'HoSoSucKhoe_Id', 'Vaccin_Id', 'Nam', 'Lan', 'GhiChu'];

    List: HoSoSucKhoe_TiemChung[] | undefined;
    ListFilter: HoSoSucKhoe_TiemChung[] | undefined;
    FormData!: HoSoSucKhoe_TiemChung;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "HoSoSucKhoe_TiemChung";
    }
}

