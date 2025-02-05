import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_BANGCAP_UV } from './NS_BANGCAP_UV.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_BANGCAP_UVService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Id', 'MaUngVien', 'TenBangcap', 'ChuyenNganh', 'Noicapbang', 'Ngaycapbang', 'Xeploai'];

    List: NS_BANGCAP_UV[] | undefined;
    ListFilter: NS_BANGCAP_UV[] | undefined;
    FormData!: NS_BANGCAP_UV;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_BANGCAP_UV";
    }
}

