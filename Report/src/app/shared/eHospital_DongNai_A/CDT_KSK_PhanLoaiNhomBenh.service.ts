import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CDT_KSK_PhanLoaiNhomBenh } from './CDT_KSK_PhanLoaiNhomBenh.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CDT_KSK_PhanLoaiNhomBenhService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KSK_PhanLoaiNhomBenh_Id', 'KSK_NgoaiVien_Id', 'NhomBenh_Id', 'SoCa', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: CDT_KSK_PhanLoaiNhomBenh[] | undefined;
    ListFilter: CDT_KSK_PhanLoaiNhomBenh[] | undefined;
    FormData!: CDT_KSK_PhanLoaiNhomBenh;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CDT_KSK_PhanLoaiNhomBenh";
    }
}

