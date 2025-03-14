import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_LoaiBenhAn } from './DM_LoaiBenhAn.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_LoaiBenhAnService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'LoaiBenhAn_Id', 'NhomLoaiBenhAn_Id', 'MaLoaiBenhAn', 'MaLoaiBenhAn_Map', 'TenLoaiBenhAn', 'TenLoaiBenhAn_En', 'TenLoaiBenhAn_Ru', 'Cap', 'CapTren_Id', 'TamNgung', 'TenKhongDau', 'Property1', 'Property2', 'Property3', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: DM_LoaiBenhAn[] | undefined;
    ListFilter: DM_LoaiBenhAn[] | undefined;
    FormData!: DM_LoaiBenhAn;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_LoaiBenhAn";
    }
}

