import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_ICD_tmp } from './DM_ICD_tmp.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_ICD_tmpService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ICD_Id', 'MaICD', 'TenICD', 'TenICD_En', 'TenICD_Ru', 'MucICD', 'ICD_Nhom_Id', 'PhanNhom', 'Loai', 'BenhTruyenNhiem', 'TamNgung', 'TenKhongDau', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'Ma', 'Ma_Nhom'];

    List: DM_ICD_tmp[] | undefined;
    ListFilter: DM_ICD_tmp[] | undefined;
    FormData!: DM_ICD_tmp;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_ICD_tmp";
    }
}

