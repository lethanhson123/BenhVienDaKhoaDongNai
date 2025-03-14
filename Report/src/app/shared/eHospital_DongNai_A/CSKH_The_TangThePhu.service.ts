import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CSKH_The_TangThePhu } from './CSKH_The_TangThePhu.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CSKH_The_TangThePhuService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'The_TangThePhu_Id', 'The_ID', 'LoaiKhachHang_Id', 'LoaiKhachHang_ThePhu_Id', 'SoTienDong', 'SoLanDuocPhepTang', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'SoLanDaTang'];

    List: CSKH_The_TangThePhu[] | undefined;
    ListFilter: CSKH_The_TangThePhu[] | undefined;
    FormData!: CSKH_The_TangThePhu;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CSKH_The_TangThePhu";
    }
}

