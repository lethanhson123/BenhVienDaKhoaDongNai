import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Map_ChuyenKhoaKham_PhongBan } from './Map_ChuyenKhoaKham_PhongBan.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Map_ChuyenKhoaKham_PhongBanService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Map_ID', 'ChuyenKhoaKham_ID', 'PhongBan_ID', 'NgayTao', 'NguoiTao_ID', 'NgayCapNhat', 'NguoiCapNhat_ID'];

    List: Map_ChuyenKhoaKham_PhongBan[] | undefined;
    ListFilter: Map_ChuyenKhoaKham_PhongBan[] | undefined;
    FormData!: Map_ChuyenKhoaKham_PhongBan;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Map_ChuyenKhoaKham_PhongBan";
    }
}

