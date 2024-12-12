import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ThanhVienLichSuTruyCap } from 'src/app/shared/ThanhVienLichSuTruyCap.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ThanhVienLichSuTruyCapService extends BaseService{
    
    DisplayColumns001: string[] = ['STT', 'NgayGhiNhan', 'Name', 'Code', 'URL', 'IPAddress', 'DanhMucQuocGiaName', 'DanhMucTinhThanhName', 'DanhMucQuanHuyenName', 'KinhDo', 'ViDo', 'TypeName'];
        
    List: ThanhVienLichSuTruyCap[] | undefined;
    ListFilter: ThanhVienLichSuTruyCap[] | undefined;
    FormData!: ThanhVienLichSuTruyCap;

    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ThanhVienLichSuTruyCap";
    }
}

