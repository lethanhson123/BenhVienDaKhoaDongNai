import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DuocKyTonKho } from './DuocKyTonKho.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DuocKyTonKhoService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'DuocKyTonKho_Id', 'MaKyTonKho', 'Thang', 'Nam', 'TuNgay', 'DenNgay', 'KhoaSo', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: DuocKyTonKho[] | undefined;
    ListFilter: DuocKyTonKho[] | undefined;
    FormData!: DuocKyTonKho;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DuocKyTonKho";
    }
}

