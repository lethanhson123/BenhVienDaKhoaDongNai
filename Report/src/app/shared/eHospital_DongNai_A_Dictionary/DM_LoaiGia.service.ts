import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_LoaiGia } from './DM_LoaiGia.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_LoaiGiaService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'LoaiGia_Id', 'MaLoaiGia', 'TenLoaiGia', 'NhomGia_Id', 'CapTren_Id', 'GhiChu', 'TamNgung', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'Idx'];

    List: DM_LoaiGia[] | undefined;
    ListFilter: DM_LoaiGia[] | undefined;
    FormData!: DM_LoaiGia;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_LoaiGia";
    }
}

