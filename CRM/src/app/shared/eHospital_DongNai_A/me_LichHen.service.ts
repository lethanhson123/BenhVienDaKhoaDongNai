import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { me_LichHen } from './me_LichHen.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class me_LichHenService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'LichHen_id', 'NgayHen', 'PhieuHen', 'BenhNhan_id', 'GhiChu', 'NoiTao_id', 'NguoiTao_id', 'NgayTao', 'ThoiGianTao', 'NoiCapNhat_id', 'NguoiCapNhat_id', 'NgayCapNhat', 'IsLocked'];

    List: me_LichHen[] | undefined;
    ListFilter: me_LichHen[] | undefined;
    FormData!: me_LichHen;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "me_LichHen";
    }
}

