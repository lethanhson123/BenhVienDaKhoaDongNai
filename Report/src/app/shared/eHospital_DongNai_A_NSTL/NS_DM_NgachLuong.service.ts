import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_DM_NgachLuong } from './NS_DM_NgachLuong.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_DM_NgachLuongService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MaNgach', 'TenNgach', 'GhiChu', 'NhomNgach'];

    List: NS_DM_NgachLuong[] | undefined;
    ListFilter: NS_DM_NgachLuong[] | undefined;
    FormData!: NS_DM_NgachLuong;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_DM_NgachLuong";
    }
}

