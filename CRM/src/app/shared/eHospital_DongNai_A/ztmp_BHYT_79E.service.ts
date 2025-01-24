import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ztmp_BHYT_79E } from './ztmp_BHYT_79E.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ztmp_BHYT_79EService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'STT', 'hoten', 'NamSinh', 'NamSinh_Nam', 'NamSinh_Nu', 'GioiTinh', 'diachi', 'MaThe', 'Ma_dkbd', 'gt_tu', 'gt_den', 'Mabenh', 'benhkhac', 'lydo_vv', 'ma_noi_chuyen', 'Ngay_Vao', 'Ngay_Ra', 'Ngaydtr', 'NgayKham', 'ket_qua_dtri', 'tinh_trang_rv', 't_TongChi', 't_Xn', 't_CDHA', 't_Thuoc', 't_Mau', 't_pptt', 't_vtytth', 't_vtyttt', 't_dvktc', 't_ktg', 't_kham', 't_giuong', 't_vchuyen', 't_bnct', 't_bhtt', 't_ngoaids', 'ma_khoa', 'nam_qt', 'thang_qt', 'ma_loaikcb', 'noidkcb', 'ma_khuvuc', 'khong_ctra', 'NhomDoiTuong', 'Str1', 'Str2', 'ma_bn'];

    List: ztmp_BHYT_79E[] | undefined;
    ListFilter: ztmp_BHYT_79E[] | undefined;
    FormData!: ztmp_BHYT_79E;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ztmp_BHYT_79E";
    }
}

