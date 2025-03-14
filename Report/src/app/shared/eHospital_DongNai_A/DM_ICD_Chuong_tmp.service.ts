import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_ICD_Chuong_tmp } from './DM_ICD_Chuong_tmp.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_ICD_Chuong_tmpService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ICD_Chuong_Id', 'MaChuongICD', 'TenChuongICD', 'TenChuongICD_En', 'TenChuongICD_Ru', 'TamNgung', 'TenKhongDau', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'STT_Chuong'];

    List: DM_ICD_Chuong_tmp[] | undefined;
    ListFilter: DM_ICD_Chuong_tmp[] | undefined;
    FormData!: DM_ICD_Chuong_tmp;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_ICD_Chuong_tmp";
    }
}

