import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CSKH_The_DoiThe } from './CSKH_The_DoiThe.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CSKH_The_DoiTheService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'The_DoiThe_Id', 'The_Id', 'LoaiKhachHang_Id', 'SoTien', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: CSKH_The_DoiThe[] | undefined;
    ListFilter: CSKH_The_DoiThe[] | undefined;
    FormData!: CSKH_The_DoiThe;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CSKH_The_DoiThe";
    }
}

