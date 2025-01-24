import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { XepLich } from './XepLich.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class XepLichService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'XepLich_ID', 'NhanVien_Id', 'NgayXepLich', 'NgayTrongTuan_ID', 'ThoiGianBatDau', 'ThoiGianKetThuc', 'SoGio', 'PhongBan_ID', 'CaTruc_ID', 'Truc', 'CaGay', 'NguoiTao_Id', 'NgayTao', 'NguoiCapNhat_Id', 'NgayCapNhat', 'LyDoChamCong_Id', 'GioThem', 'GioCongChuan', 'Lock', 'GioCongChuan_Id', 'Balance'];

    List: XepLich[] | undefined;
    ListFilter: XepLich[] | undefined;
    FormData!: XepLich;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "XepLich";
    }
}

