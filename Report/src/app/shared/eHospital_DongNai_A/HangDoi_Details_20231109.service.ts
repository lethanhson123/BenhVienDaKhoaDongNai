import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { HangDoi_Details_20231109 } from './HangDoi_Details_20231109.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class HangDoi_Details_20231109Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Idx', 'HangDoi_Idx', 'SoTT', 'TinhTrang', 'Ngay', 'NgayTao', 'App', 'CLSYeuCau_Id', 'TiepNhan_Id', 'BenhNhan_Id', 'GioiTinh', 'NamSinh', 'TenBenhNhan', 'MaYte'];

    List: HangDoi_Details_20231109[] | undefined;
    ListFilter: HangDoi_Details_20231109[] | undefined;
    FormData!: HangDoi_Details_20231109;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "HangDoi_Details_20231109";
    }
}

