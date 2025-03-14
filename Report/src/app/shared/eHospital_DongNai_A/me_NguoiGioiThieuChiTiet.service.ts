import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { me_NguoiGioiThieuChiTiet } from './me_NguoiGioiThieuChiTiet.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class me_NguoiGioiThieuChiTietService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'NguoiGioiThieu_id', 'YeuCauChiTiet_id', 'Huy', 'NgayTao', 'NguoiTao', 'NgayCapNhat', 'NguoiCapNhat'];

    List: me_NguoiGioiThieuChiTiet[] | undefined;
    ListFilter: me_NguoiGioiThieuChiTiet[] | undefined;
    FormData!: me_NguoiGioiThieuChiTiet;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "me_NguoiGioiThieuChiTiet";
    }
}

