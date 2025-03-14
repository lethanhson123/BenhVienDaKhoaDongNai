import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { TonKho } from './TonKho.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class TonKhoService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'PhamVi', 'NguonDuoc', 'LoaiDuoc', 'TenLoaiDuoc', 'Duoc_ID', 'MaDuoc', 'TenDuoc', 'DonViTinh', 'Ton', 'LuongNhap', 'LuongXuat', 'LuongTon'];

    List: TonKho[] | undefined;
    ListFilter: TonKho[] | undefined;
    FormData!: TonKho;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "TonKho";
    }
}

