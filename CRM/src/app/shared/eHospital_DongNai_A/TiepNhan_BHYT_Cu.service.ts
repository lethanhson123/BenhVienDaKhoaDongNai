import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { TiepNhan_BHYT_Cu } from './TiepNhan_BHYT_Cu.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class TiepNhan_BHYT_CuService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'TiepNhan_BHYT_Cu_Id', 'TiepNhan_Id', 'SoBHYT', 'BHYTTuNgay', 'BHYTDenNgay', 'DoiTuong_Id', 'DoiTuong_ChiTiet_Id', 'BenhVien_KCB_Id', 'TuyenKhamBenh_Id', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: TiepNhan_BHYT_Cu[] | undefined;
    ListFilter: TiepNhan_BHYT_Cu[] | undefined;
    FormData!: TiepNhan_BHYT_Cu;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "TiepNhan_BHYT_Cu";
    }
}

