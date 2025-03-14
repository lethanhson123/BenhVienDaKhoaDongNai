import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { zzz_SaiTen } from './zzz_SaiTen.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class zzz_SaiTenService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'SoVaoVien', 'NgayVao', 'NgayRa'];

    List: zzz_SaiTen[] | undefined;
    ListFilter: zzz_SaiTen[] | undefined;
    FormData!: zzz_SaiTen;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "zzz_SaiTen";
    }
}

