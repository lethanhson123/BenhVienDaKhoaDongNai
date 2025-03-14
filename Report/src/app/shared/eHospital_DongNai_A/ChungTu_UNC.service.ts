import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ChungTu_UNC } from './ChungTu_UNC.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ChungTu_UNCService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'UNC_Id', 'SoUNC', 'NgayUNC', 'GiaTriThanhToan', 'NhaCungCap_Id', 'GhiChu', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: ChungTu_UNC[] | undefined;
    ListFilter: ChungTu_UNC[] | undefined;
    FormData!: ChungTu_UNC;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ChungTu_UNC";
    }
}

