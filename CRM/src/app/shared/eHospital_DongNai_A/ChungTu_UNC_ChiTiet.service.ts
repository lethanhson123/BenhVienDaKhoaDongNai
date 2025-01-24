import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ChungTu_UNC_ChiTiet } from './ChungTu_UNC_ChiTiet.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ChungTu_UNC_ChiTietService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'UNC_ChiTiet_Id', 'UNC_Id', 'ChungTu_Id', 'MaChungTu', 'SoSeri', 'SoHoaDon', 'GiaTriThanhToan', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: ChungTu_UNC_ChiTiet[] | undefined;
    ListFilter: ChungTu_UNC_ChiTiet[] | undefined;
    FormData!: ChungTu_UNC_ChiTiet;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ChungTu_UNC_ChiTiet";
    }
}

