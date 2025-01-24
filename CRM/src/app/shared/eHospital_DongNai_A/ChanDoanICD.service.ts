import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ChanDoanICD } from './ChanDoanICD.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ChanDoanICDService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ChanDoanIDC_Id', 'ICD_Id', 'ICD_Main', 'IDRef', 'LoaiIDRef', 'NoiTru_NhapVien_Id', 'LuuTru_Id', 'BenhAn_Id', 'NoiTru_KhamBenh_Id', 'CLSYeuCau_Id', 'KhamBenh_Id', 'BenhAnNgoaiTru_Id', 'BENHANNGOAITRU_KHAMBENH_Id'];

    List: ChanDoanICD[] | undefined;
    ListFilter: ChanDoanICD[] | undefined;
    FormData!: ChanDoanICD;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ChanDoanICD";
    }
}

