import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { KhamSucKhoe } from './KhamSucKhoe.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class KhamSucKhoeService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KhamSucKhoe_ID', 'TiepNhan_Id', 'BenhNhan_ID', 'CongTy', 'KetLuan', 'XepLoai_ID', 'DuSucKhoeLamViec', 'DuSucKhoeLamViecCTBien', 'DuSucKhoeLamViecGioiHan', 'BacSi_ID', 'NgayKham', 'NgayTao', 'NgayCapNhat', 'NguoiTao_Id', 'NguoiCapNhat_Id', 'Loai'];

    List: KhamSucKhoe[] | undefined;
    ListFilter: KhamSucKhoe[] | undefined;
    FormData!: KhamSucKhoe;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "KhamSucKhoe";
    }
}

