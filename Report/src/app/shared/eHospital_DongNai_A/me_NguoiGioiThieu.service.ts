import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { me_NguoiGioiThieu } from './me_NguoiGioiThieu.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class me_NguoiGioiThieuService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'NguoiGioiThieu_id', 'NhanVien_id', 'TiepNhan_id', 'Huy', 'NgayTao', 'NguoiTao', 'NgayCapNhat', 'NguoiCapNhat'];

    List: me_NguoiGioiThieu[] | undefined;
    ListFilter: me_NguoiGioiThieu[] | undefined;
    FormData!: me_NguoiGioiThieu;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "me_NguoiGioiThieu";
    }
}

