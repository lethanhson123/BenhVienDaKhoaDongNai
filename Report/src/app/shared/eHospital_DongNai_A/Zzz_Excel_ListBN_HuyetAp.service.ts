import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Zzz_Excel_ListBN_HuyetAp } from './Zzz_Excel_ListBN_HuyetAp.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Zzz_Excel_ListBN_HuyetApService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MaYTe', 'TenBN', 'NamSinh', 'GioiTinh'];

    List: Zzz_Excel_ListBN_HuyetAp[] | undefined;
    ListFilter: Zzz_Excel_ListBN_HuyetAp[] | undefined;
    FormData!: Zzz_Excel_ListBN_HuyetAp;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Zzz_Excel_ListBN_HuyetAp";
    }
}

