import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { XacNhanSuDung } from './XacNhanSuDung.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class XacNhanSuDungService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'XacNhanSuDung_Id', 'YeuCauChiTiet_Id', 'CLSYeuCau_Id', 'DichVu_Id', 'PhongBan_Id', 'SoLuong', 'NguoiTao_Id', 'NgayTao', 'NgayXacNhan', 'NguoiThucHien_Id', 'NoiThucHien_Id', 'KhoaDieuTri'];

    List: XacNhanSuDung[] | undefined;
    ListFilter: XacNhanSuDung[] | undefined;
    FormData!: XacNhanSuDung;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "XacNhanSuDung";
    }
}

