import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_NGHIPHEP } from './NS_NGHIPHEP.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_NGHIPHEPService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'MaNhanVien', 'TuNgay', 'DenNgay', 'MaLydoNghiphep'];

    List: NS_NGHIPHEP[] | undefined;
    ListFilter: NS_NGHIPHEP[] | undefined;
    FormData!: NS_NGHIPHEP;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_NGHIPHEP";
    }
}

