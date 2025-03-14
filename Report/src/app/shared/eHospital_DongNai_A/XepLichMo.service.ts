import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { XepLichMo } from './XepLichMo.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class XepLichMoService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'LichMo_Id', 'BenhAn_Id', 'CLSYeuCauChiTiet_Id', 'NgayMo', 'ThoiGianMo', 'ChanDoanVaPhauThuat', 'NgayTao', 'BacSi01_Id', 'BacSi02_Id', 'BacSi03_Id', 'BacSi04_Id', 'MauDuTru', 'PPVoCam_Id', 'PhongBan_Id', 'BenhNhan_Id', 'TiepNhan_Id', 'ThoiGianketThuc'];

    List: XepLichMo[] | undefined;
    ListFilter: XepLichMo[] | undefined;
    FormData!: XepLichMo;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "XepLichMo";
    }
}

