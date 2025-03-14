import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ToaThuocMau } from './ToaThuocMau.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ToaThuocMauService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ToaThuocMau_Id', 'BacSi_Id', 'MaToaThuoc', 'TenToaThuoc', 'Duoc_Id', 'Sang', 'Trua', 'Chieu', 'Toi', 'SoNgay', 'SoLuong', 'DuongDung_Id', 'GhiChu', 'DienGiai', 'idx', 'LoaiToaThuoc'];

    List: ToaThuocMau[] | undefined;
    ListFilter: ToaThuocMau[] | undefined;
    FormData!: ToaThuocMau;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ToaThuocMau";
    }
}

