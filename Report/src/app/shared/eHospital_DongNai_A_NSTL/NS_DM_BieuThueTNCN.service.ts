import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_DM_BieuThueTNCN } from './NS_DM_BieuThueTNCN.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_DM_BieuThueTNCNService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Id', 'BacThue', 'ThuNhapTinhThue', 'TyLeThue', 'GhiChu', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: NS_DM_BieuThueTNCN[] | undefined;
    ListFilter: NS_DM_BieuThueTNCN[] | undefined;
    FormData!: NS_DM_BieuThueTNCN;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_DM_BieuThueTNCN";
    }
}

