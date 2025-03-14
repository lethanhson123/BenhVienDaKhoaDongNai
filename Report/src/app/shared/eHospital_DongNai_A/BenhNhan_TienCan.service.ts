import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BenhNhan_TienCan } from './BenhNhan_TienCan.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BenhNhan_TienCanService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhNhan_TienCan_Id', 'BenhNhan_Id', 'TienCan_Id', 'NgayPhatHien', 'TinhTrang', 'GhiChu', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: BenhNhan_TienCan[] | undefined;
    ListFilter: BenhNhan_TienCan[] | undefined;
    FormData!: BenhNhan_TienCan;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BenhNhan_TienCan";
    }
}

