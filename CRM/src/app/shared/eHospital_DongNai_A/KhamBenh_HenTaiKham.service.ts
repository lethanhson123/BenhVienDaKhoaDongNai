import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { KhamBenh_HenTaiKham } from './KhamBenh_HenTaiKham.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class KhamBenh_HenTaiKhamService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KhamBenh_HenTaiKham', 'KhamBenh_Id', 'BenhNhan_Id', 'NgayTaiKham', 'ThoiGianTaiKham', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'Loai', 'TiepNhan_Id', 'SoPhieuHen', 'STT'];

    List: KhamBenh_HenTaiKham[] | undefined;
    ListFilter: KhamBenh_HenTaiKham[] | undefined;
    FormData!: KhamBenh_HenTaiKham;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "KhamBenh_HenTaiKham";
    }
}

