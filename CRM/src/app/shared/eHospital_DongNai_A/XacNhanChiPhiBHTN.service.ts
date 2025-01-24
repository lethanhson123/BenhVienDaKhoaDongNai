import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { XacNhanChiPhiBHTN } from './XacNhanChiPhiBHTN.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class XacNhanChiPhiBHTNService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'XacNhanChiPhi_Id', 'SoXacNhan', 'NgayXacNhan', 'NoiXacNhan_ID', 'Loai', 'GhiNhan_Id', 'SoPhieuGhiNhan', 'TiepNhan_Id', 'BenhNhan_Id', 'CongTy_ID', 'SoTheBHTN', 'GiaTri', 'GhiChu', 'NguoiTao_Id', 'NgayTao', 'NguoiCapNhat_Id', 'NgayCapNhat', 'ThoiGianLap'];

    List: XacNhanChiPhiBHTN[] | undefined;
    ListFilter: XacNhanChiPhiBHTN[] | undefined;
    FormData!: XacNhanChiPhiBHTN;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "XacNhanChiPhiBHTN";
    }
}

