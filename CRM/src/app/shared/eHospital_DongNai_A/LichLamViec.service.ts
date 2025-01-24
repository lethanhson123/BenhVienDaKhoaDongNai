import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { LichLamViec } from './LichLamViec.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class LichLamViecService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'LichKham_Id', 'NhanVien_Id', 'PhongBan_Id', 'CongViec_Id', 'NgayBatDau', 'ThoiGianBatDau', 'NgayKetThuc', 'ThoiGianKetThuc', 'GhiChu', 'TamNgung'];

    List: LichLamViec[] | undefined;
    ListFilter: LichLamViec[] | undefined;
    FormData!: LichLamViec;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "LichLamViec";
    }
}

