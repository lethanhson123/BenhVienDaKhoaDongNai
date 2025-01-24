import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { QuanLyBenhPham } from './QuanLyBenhPham.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class QuanLyBenhPhamService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'QuanLyBenhPham_Id', 'SoPhieu', 'BenhAn_Id', 'TiepNhan_Id', 'NoiThucHien_Id', 'NgayThucHien', 'ThoiGianThucHien', 'ThoiGianTraKQ', 'KyThuatVien_ID', 'SoLuongOngMau', 'ThoiGianLayMau', 'DungTich', 'TinhTrangMau_ID', 'GhiChu', 'NgayTao', 'NguoiTao_ID', 'NgayCapNhat', 'NguoiCapNhat_Id', 'KetLuan', 'GhiChuBenhPham'];

    List: QuanLyBenhPham[] | undefined;
    ListFilter: QuanLyBenhPham[] | undefined;
    FormData!: QuanLyBenhPham;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "QuanLyBenhPham";
    }
}

