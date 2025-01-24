import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NoiTru_ChamSocDichTruyen } from './NoiTru_ChamSocDichTruyen.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NoiTru_ChamSocDichTruyenService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'NoiTru_ChamSocDichTruyen_Id', 'NoiTru_ChamSoc_Id', 'Duoc_Id', 'SoLuong', 'SoMLChayNguoc', 'SoMLGiaoLai', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: NoiTru_ChamSocDichTruyen[] | undefined;
    ListFilter: NoiTru_ChamSocDichTruyen[] | undefined;
    FormData!: NoiTru_ChamSocDichTruyen;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NoiTru_ChamSocDichTruyen";
    }
}

