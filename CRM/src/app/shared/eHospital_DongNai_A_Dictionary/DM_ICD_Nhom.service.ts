import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_ICD_Nhom } from './DM_ICD_Nhom.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_ICD_NhomService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ICD_Nhom_Id', 'MaNhomICD', 'TenNhomICD', 'TenNhomICD_En', 'TenNhomICD_Ru', 'ICD_Chuong_Id', 'TamNgung', 'TenKhongDau', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: DM_ICD_Nhom[] | undefined;
    ListFilter: DM_ICD_Nhom[] | undefined;
    FormData!: DM_ICD_Nhom;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_ICD_Nhom";
    }
}

