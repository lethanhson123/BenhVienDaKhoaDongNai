import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BenhAnTongQuat } from './BenhAnTongQuat.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BenhAnTongQuatService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhAnTongQuat_Id', 'BenhAn_Id', 'BenhAnTongQuatLienQuan_Id', 'SoBenhAn', 'SoLuuTru', 'LoaiBenhAn_Id', 'NgayLap', 'ThoiGianLap', 'NoiLap_Id', 'NguoiLap_Id', 'KhoaBenhAn', 'TrangThai', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: BenhAnTongQuat[] | undefined;
    ListFilter: BenhAnTongQuat[] | undefined;
    FormData!: BenhAnTongQuat;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BenhAnTongQuat";
    }
}

