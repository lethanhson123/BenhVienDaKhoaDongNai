import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { HoaDon_ThuTu } from './HoaDon_ThuTu.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class HoaDon_ThuTuService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhNhan_Id', 'STT', 'NgayTao', 'PhongBan_Id'];

    List: HoaDon_ThuTu[] | undefined;
    ListFilter: HoaDon_ThuTu[] | undefined;
    FormData!: HoaDon_ThuTu;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "HoaDon_ThuTu";
    }
}

