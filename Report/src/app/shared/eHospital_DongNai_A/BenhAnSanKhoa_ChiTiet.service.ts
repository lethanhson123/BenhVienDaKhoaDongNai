import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BenhAnSanKhoa_ChiTiet } from './BenhAnSanKhoa_ChiTiet.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BenhAnSanKhoa_ChiTietService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhAnSanKhoa_ChiTiet_Id', 'BenhAn_Id', 'SoLanCoThai', 'Nam', 'DeDuThang', 'DeThieuThang', 'CanNang', 'GioiTinh', 'NgatSauSinh', 'TreChetKhiSinh', 'ThaiChetTu22Tuan', 'ThaiChetLuu', 'GhiChu', 'LyDoSoSinhChet', 'NgaySinh', 'VitaminK', 'ViemGanB'];

    List: BenhAnSanKhoa_ChiTiet[] | undefined;
    ListFilter: BenhAnSanKhoa_ChiTiet[] | undefined;
    FormData!: BenhAnSanKhoa_ChiTiet;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BenhAnSanKhoa_ChiTiet";
    }
}

