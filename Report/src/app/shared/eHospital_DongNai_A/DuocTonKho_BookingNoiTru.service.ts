import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DuocTonKho_BookingNoiTru } from './DuocTonKho_BookingNoiTru.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DuocTonKho_BookingNoiTruService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KhoDuoc_Id', 'NguonHang_Id', 'Duoc_Id', 'SoLuong', 'NgayHieuLuc'];

    List: DuocTonKho_BookingNoiTru[] | undefined;
    ListFilter: DuocTonKho_BookingNoiTru[] | undefined;
    FormData!: DuocTonKho_BookingNoiTru;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DuocTonKho_BookingNoiTru";
    }
}

