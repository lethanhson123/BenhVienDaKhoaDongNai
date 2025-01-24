import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_HoiThao } from './DM_HoiThao.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_HoiThaoService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'HoiThao_Id', 'MaHoiThao', 'TenHoiThao', 'NgayBatDau', 'NgayKetThuc', 'DiaDiem', 'KetQua', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: DM_HoiThao[] | undefined;
    ListFilter: DM_HoiThao[] | undefined;
    FormData!: DM_HoiThao;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_HoiThao";
    }
}

