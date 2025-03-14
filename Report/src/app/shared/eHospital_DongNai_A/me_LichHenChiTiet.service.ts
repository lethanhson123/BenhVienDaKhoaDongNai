import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { me_LichHenChiTiet } from './me_LichHenChiTiet.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class me_LichHenChiTietService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'LichHenChiTiet_id', 'LichHen_id', 'DichVu_id', 'NoiTao_id', 'NguoiTao_id', 'NgayTao', 'ThoiGianTao', 'GhiChu', 'MuiTiemSo', 'NoiCapNhat_id', 'NguoiCapNhat_id', 'NgayCapNhat'];

    List: me_LichHenChiTiet[] | undefined;
    ListFilter: me_LichHenChiTiet[] | undefined;
    FormData!: me_LichHenChiTiet;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "me_LichHenChiTiet";
    }
}

