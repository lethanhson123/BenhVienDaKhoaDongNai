import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BenhAn_SaiGio } from './BenhAn_SaiGio.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BenhAn_SaiGioService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhAn_Id', 'ThoiGianRaVien', 'DaUpdate'];

    List: BenhAn_SaiGio[] | undefined;
    ListFilter: BenhAn_SaiGio[] | undefined;
    FormData!: BenhAn_SaiGio;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BenhAn_SaiGio";
    }
}

