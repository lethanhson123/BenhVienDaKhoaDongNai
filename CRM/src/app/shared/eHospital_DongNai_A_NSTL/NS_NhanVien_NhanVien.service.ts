import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_NhanVien_NhanVien } from './NS_NhanVien_NhanVien.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_NhanVien_NhanVienService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'NS_NhanVien_NhanVien_ID', 'NhanVien_Id', 'NhanVienQL_Id', 'MaNhanVien', 'MaNhanVienQL', 'GhiChu'];

    List: NS_NhanVien_NhanVien[] | undefined;
    ListFilter: NS_NhanVien_NhanVien[] | undefined;
    FormData!: NS_NhanVien_NhanVien;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_NhanVien_NhanVien";
    }
}

