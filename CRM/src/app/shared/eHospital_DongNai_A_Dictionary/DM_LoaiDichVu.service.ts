import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_LoaiDichVu } from './DM_LoaiDichVu.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_LoaiDichVuService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'LoaiDichVu_Id', 'MaLoaiDichVu', 'TenLoaiDichVu', 'TenLoaiDichVu_En', 'TenLoaiDichVu_Ru', 'TamNgung', 'TenKhongDau', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'SiteCode', 'Mapping_Public_Id'];

    List: DM_LoaiDichVu[] | undefined;
    ListFilter: DM_LoaiDichVu[] | undefined;
    FormData!: DM_LoaiDichVu;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_LoaiDichVu";
    }
}

