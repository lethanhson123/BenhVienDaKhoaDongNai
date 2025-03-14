import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { QuanLyBenhPham_YeuCau } from './QuanLyBenhPham_YeuCau.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class QuanLyBenhPham_YeuCauService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'QuanLyBenhPham_YeuCau_Id', 'QuanLyBenhPham_Id', 'CLSYeuCau_Id', 'CLSYeuCauChiTiet_Id', 'NhomDichVu_Id', 'DichVu_Id', 'LoaiGia_Id', 'DonGiaDoanhThu', 'DonGiaThanhToan', 'LoaiTien_Id', 'TyGia', 'GhiChuLayMau'];

    List: QuanLyBenhPham_YeuCau[] | undefined;
    ListFilter: QuanLyBenhPham_YeuCau[] | undefined;
    FormData!: QuanLyBenhPham_YeuCau;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "QuanLyBenhPham_YeuCau";
    }
}

