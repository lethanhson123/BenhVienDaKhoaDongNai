import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CSKH_The_ThoiHanSDThe } from './CSKH_The_ThoiHanSDThe.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CSKH_The_ThoiHanSDTheService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'The_ThoiHanSDThe_Id', 'The_Id', 'LoaiKhachHang_Id', 'Nam', 'Thang', 'Ngay', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'ThoiGianHetHan', 'NgayHetHan'];

    List: CSKH_The_ThoiHanSDThe[] | undefined;
    ListFilter: CSKH_The_ThoiHanSDThe[] | undefined;
    FormData!: CSKH_The_ThoiHanSDThe;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CSKH_The_ThoiHanSDThe";
    }
}

