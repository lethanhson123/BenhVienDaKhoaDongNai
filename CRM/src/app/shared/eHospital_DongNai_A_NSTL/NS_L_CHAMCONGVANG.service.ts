import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_L_CHAMCONGVANG } from './NS_L_CHAMCONGVANG.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_L_CHAMCONGVANGService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'MaNhanVien', 'NgayNghi', 'Malydovangmat', 'SoGioVang', 'TyLeHuongLuong', 'MaPhongBan', 'Malydovangmat2', 'Malydovangmat3', 'Malydovangmat4', 'Khoa', 'GioBatDau_LD2', 'GioKetThuc_LD2', 'SoGioLyDo2', 'GhiChuLD2', 'GioBatDau_LD3', 'GioKetThuc_LD3', 'SoGioLyDo3', 'GhiChuLD3', 'Khoa_LamThem', 'MaTrai'];

    List: NS_L_CHAMCONGVANG[] | undefined;
    ListFilter: NS_L_CHAMCONGVANG[] | undefined;
    FormData!: NS_L_CHAMCONGVANG;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_L_CHAMCONGVANG";
    }
}

