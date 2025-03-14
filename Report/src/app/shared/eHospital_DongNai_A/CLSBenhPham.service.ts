import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CLSBenhPham } from './CLSBenhPham.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CLSBenhPhamService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'CLSBenhPham_Id', 'CLSYeuCau_Id', 'LanNhan', 'NgayNhan', 'ThoiGianNhan', 'NgayGioNhan', 'NguoiGiao_Id', 'TenNguoiGiao', 'NguoiNhan_Id', 'SoLuong', 'MoTa', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: CLSBenhPham[] | undefined;
    ListFilter: CLSBenhPham[] | undefined;
    FormData!: CLSBenhPham;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CLSBenhPham";
    }
}

