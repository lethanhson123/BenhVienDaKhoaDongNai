import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_NhanVien_Lich_CaTruc } from './NS_NhanVien_Lich_CaTruc.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_NhanVien_Lich_CaTrucService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'NhanVien_Lich_CaTruc_Id', 'NhanVien_Id', 'Thu', 'Ngay', 'CaTruc_Id', 'BatDau', 'KetThuc', 'PhongBan_Id', 'TruongTua', 'CapCuu', 'SAXQ'];

    List: NS_NhanVien_Lich_CaTruc[] | undefined;
    ListFilter: NS_NhanVien_Lich_CaTruc[] | undefined;
    FormData!: NS_NhanVien_Lich_CaTruc;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_NhanVien_Lich_CaTruc";
    }
}

