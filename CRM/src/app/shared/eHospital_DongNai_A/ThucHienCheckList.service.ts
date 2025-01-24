import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ThucHienCheckList } from './ThucHienCheckList.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ThucHienCheckListService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ThucHienCheckList_Id', 'BenhNhan_Id', 'TiepNhan_Id', 'BenhAn_Id', 'NhanVienThucHien_Id', 'NgayThucHien', 'NhanVienCapNhat_Id', 'NgayNhanVienCapNhat', 'NhanVienKiemTra_Id', 'NgayKiemTra', 'NguoiTao_Id', 'NgayTao', 'NguoiCapNhat_Id', 'NgayCapNhat', 'GhiChu', 'ThoiGianThucHien', 'ThoiGianKiemTra', 'NgayLuu', 'ThoiGianLuu', 'MauCheckList_Id'];

    List: ThucHienCheckList[] | undefined;
    ListFilter: ThucHienCheckList[] | undefined;
    FormData!: ThucHienCheckList;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ThucHienCheckList";
    }
}

