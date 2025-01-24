import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { KhamGayMe } from './KhamGayMe.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class KhamGayMeService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KhamGayMe_Id', 'TiepNhan_Id', 'BenhAn_Id', 'CLSYeuCau_Id', 'NgayKham', 'ThoiGianKham', 'NguoiKham_Id', 'ThoiGianMoDuKien', 'PhongMoDuKien_Id', 'GhiChu', 'DeNghi', 'KetLuan', 'TienSu', 'TienSu_Text', 'YeuCauKham', 'YeuCauKham_Text', 'BenhSu', 'BenhSu_Text', 'NhanXet', 'NhanXet_Text', 'Khoa', 'NgayKhoa', 'NguoiKhoa_Id', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: KhamGayMe[] | undefined;
    ListFilter: KhamGayMe[] | undefined;
    FormData!: KhamGayMe;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "KhamGayMe";
    }
}

