import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Eclaim_Header2348 } from './Eclaim_Header2348.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Eclaim_Header2348Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'ma_lk', 'stt', 'ma_bn', 'ho_ten', 'ngay_sinh', 'gioi_tinh', 'dia_chi', 'ma_the', 'ma_dkbd', 'gt_the_tu', 'gt_the_den', 'ten_benh', 'ma_benh', 'ma_benhkhac', 'ma_lydo_vvien', 'ma_noi_chuyen', 'ma_tai_nan', 'ngay_vao', 'ngay_ra', 'so_ngay_dtri', 'ket_qua_dtri', 'tinh_trang_rv', 'ngay_ttoan', 'muc_huong', 't_thuoc', 't_vtyt', 't_tongchi', 't_bntt', 't_bhtt', 't_NguonKhac', 't_ngoaids', 'nam_qt', 'thang_qt', 'ma_loai_kcb', 'ma_khoa', 'ma_cskcb', 'ma_khuvuc', 'ma_pttt_qt', 'can_nang'];

    List: Eclaim_Header2348[] | undefined;
    ListFilter: Eclaim_Header2348[] | undefined;
    FormData!: Eclaim_Header2348;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Eclaim_Header2348";
    }
}

