import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DuocTonKho_GioiHan } from './DuocTonKho_GioiHan.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DuocTonKho_GioiHanService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'DuocTonKho_GioiHan_Id', 'Duoc_Id', 'KhoDuoc_Id', 'NguonHang_Id', 'SoLuong', 'Enabled'];

    List: DuocTonKho_GioiHan[] | undefined;
    ListFilter: DuocTonKho_GioiHan[] | undefined;
    FormData!: DuocTonKho_GioiHan;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DuocTonKho_GioiHan";
    }
}

