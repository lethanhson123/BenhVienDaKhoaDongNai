import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CDT_KSK_PhanLoaiDoiTuong } from './CDT_KSK_PhanLoaiDoiTuong.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CDT_KSK_PhanLoaiDoiTuongService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KSK_PhanLoaiDoiTuong_Id', 'KSK_NgoaiVien_Id', 'DoiTuong_Id', 'SoCa', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: CDT_KSK_PhanLoaiDoiTuong[] | undefined;
    ListFilter: CDT_KSK_PhanLoaiDoiTuong[] | undefined;
    FormData!: CDT_KSK_PhanLoaiDoiTuong;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CDT_KSK_PhanLoaiDoiTuong";
    }
}

