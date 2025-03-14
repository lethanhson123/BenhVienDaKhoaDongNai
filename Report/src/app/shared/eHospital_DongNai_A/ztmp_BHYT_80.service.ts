import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ztmp_BHYT_80 } from './ztmp_BHYT_80.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ztmp_BHYT_80Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'STT', 'HoTen', 'NamSinh', 'NamSinh_Nam', 'NamSinh_Nu', 'GioiTinh', 'MaThe', 'Ma_dkbd', 'Mabenh', 'Ngay_Vao', 'Ngay_Ra', 'Ngaydtr', 'NgayKham', 't_TongChi', 't_Xn', 't_CDHA', 't_Thuoc', 't_Mau', 't_pptt', 't_vtytth', 't_vtyttt', 't_dvktc', 't_ktg', 't_kham', 't_giuong', 't_vchuyen', 't_bnct', 't_bhtt', 't_ngoaids', 'lydo_vv', 'benhkhac', 'noidkcb', 'khoa', 'nam_qt', 'thang_qt', 'gt_tu', 'gt_den', 'diachi', 'Str1', 'Str2', 'Str3', 'Str4'];

    List: ztmp_BHYT_80[] | undefined;
    ListFilter: ztmp_BHYT_80[] | undefined;
    FormData!: ztmp_BHYT_80;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ztmp_BHYT_80";
    }
}

