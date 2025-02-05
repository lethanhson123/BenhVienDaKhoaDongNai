import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_XepLichTruc_NgoaiGio } from './NS_XepLichTruc_NgoaiGio.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_XepLichTruc_NgoaiGioService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'XepLichTruc_Id', 'NgayTruc', 'Thu', 'NhanVien_Id', 'LoaiTruc_Id', 'PhongBan_Id', 'CaTruc_Id', 'BatDau', 'KetThuc', 'GhiChu'];

    List: NS_XepLichTruc_NgoaiGio[] | undefined;
    ListFilter: NS_XepLichTruc_NgoaiGio[] | undefined;
    FormData!: NS_XepLichTruc_NgoaiGio;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_XepLichTruc_NgoaiGio";
    }
}

