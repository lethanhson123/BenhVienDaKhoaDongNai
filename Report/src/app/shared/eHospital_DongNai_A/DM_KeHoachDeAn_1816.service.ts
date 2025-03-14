import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_KeHoachDeAn_1816 } from './DM_KeHoachDeAn_1816.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_KeHoachDeAn_1816Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KeHoach_Id', 'MaCongViec', 'TenCongViec', 'NoiDung', 'DiaDiem', 'HinhThuc', 'NgayBatDau', 'NgayKetThuc', 'KetQua', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: DM_KeHoachDeAn_1816[] | undefined;
    ListFilter: DM_KeHoachDeAn_1816[] | undefined;
    FormData!: DM_KeHoachDeAn_1816;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_KeHoachDeAn_1816";
    }
}

