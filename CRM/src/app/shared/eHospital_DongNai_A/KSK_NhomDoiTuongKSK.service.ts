import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { KSK_NhomDoiTuongKSK } from './KSK_NhomDoiTuongKSK.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class KSK_NhomDoiTuongKSKService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'NhomDoiTuong_Id', 'MaNhomDoiTuong', 'TenNhomDoiTuong', 'TenNhomDoiTuong_En', 'TenNhomDoiTuong_Ru', 'TamNgung', 'TenKhongDau', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: KSK_NhomDoiTuongKSK[] | undefined;
    ListFilter: KSK_NhomDoiTuongKSK[] | undefined;
    FormData!: KSK_NhomDoiTuongKSK;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "KSK_NhomDoiTuongKSK";
    }
}

