import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CSKH_The_NapTien } from './CSKH_The_NapTien.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CSKH_The_NapTienService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'The_NapTien_Id', 'The_ID', 'LoaiKhachHang_Id', 'TienNapMin', 'TienNapMax', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: CSKH_The_NapTien[] | undefined;
    ListFilter: CSKH_The_NapTien[] | undefined;
    FormData!: CSKH_The_NapTien;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CSKH_The_NapTien";
    }
}

