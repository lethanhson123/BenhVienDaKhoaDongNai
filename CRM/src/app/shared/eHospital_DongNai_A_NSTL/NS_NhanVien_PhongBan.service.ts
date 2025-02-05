import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_NhanVien_PhongBan } from './NS_NhanVien_PhongBan.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_NhanVien_PhongBanService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'NS_NhanVien_PhongBan_Id', 'MaNhanVien', 'PhongBan_Id'];

    List: NS_NhanVien_PhongBan[] | undefined;
    ListFilter: NS_NhanVien_PhongBan[] | undefined;
    FormData!: NS_NhanVien_PhongBan;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_NhanVien_PhongBan";
    }
}

