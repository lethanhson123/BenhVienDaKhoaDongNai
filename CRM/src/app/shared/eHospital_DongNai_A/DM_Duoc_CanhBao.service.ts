import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_Duoc_CanhBao } from './DM_Duoc_CanhBao.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_Duoc_CanhBaoService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Duoc_CanhBao_ID', 'Duoc_Id', 'TuThang', 'DenThang', 'TuNamSinh', 'DenNamSinh', 'TuNgaySinh', 'DenNgaySinh', 'CanNangTu', 'CanNangDen', 'SoLuong_NgayTu', 'SoLuong_NgayDen', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'Vien'];

    List: DM_Duoc_CanhBao[] | undefined;
    ListFilter: DM_Duoc_CanhBao[] | undefined;
    FormData!: DM_Duoc_CanhBao;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_Duoc_CanhBao";
    }
}

