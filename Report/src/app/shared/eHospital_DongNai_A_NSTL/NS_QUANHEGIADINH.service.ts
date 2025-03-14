import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_QUANHEGIADINH } from './NS_QUANHEGIADINH.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_QUANHEGIADINHService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'MaQuanHe', 'MaNhanVien', 'HoTen', 'NamSinh', 'NgheNghiep', 'Diachi', 'TinhTrangQuanHe_ID', 'PhuThuoc'];

    List: NS_QUANHEGIADINH[] | undefined;
    ListFilter: NS_QUANHEGIADINH[] | undefined;
    FormData!: NS_QUANHEGIADINH;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_QUANHEGIADINH";
    }
}

