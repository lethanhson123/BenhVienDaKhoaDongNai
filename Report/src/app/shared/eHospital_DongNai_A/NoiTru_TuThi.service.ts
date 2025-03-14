import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NoiTru_TuThi } from './NoiTru_TuThi.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NoiTru_TuThiService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'TuThi_Id', 'BenhAn_Id', 'NgayTuVong', 'ThoiGianTuVong', 'ThoiGianKhamNghiem', 'ThoiGianNhanTuThi', 'KetQuaKhamNghiem', 'GhiChu', 'NguyenNhanTuVong_Id', 'BacSiGhiNhanTuVong_Id', 'BacSiKhamNghiem_Id', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: NoiTru_TuThi[] | undefined;
    ListFilter: NoiTru_TuThi[] | undefined;
    FormData!: NoiTru_TuThi;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NoiTru_TuThi";
    }
}

