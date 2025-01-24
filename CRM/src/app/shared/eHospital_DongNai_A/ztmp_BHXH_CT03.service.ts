import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ztmp_BHXH_CT03 } from './ztmp_BHXH_CT03.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ztmp_BHXH_CT03Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'STT', 'MA_CT', 'MA_CSKCB', 'SO_SERI', 'MA_KHOA', 'MA_SOBHXH', 'MA_THE', 'HO_TEN', 'DIA_CHI', 'NGAY_SINH_130', 'NGAY_SINH', 'DAN_TOC', 'GIOI_TINH', 'NGHE_NGHIEP', 'NGAY_VAO_130', 'NGAY_VAO', 'NGAY_RA_130', 'NGAY_RA', 'TUOI_THAI', 'CHAN_DOAN', 'PP_DIEUTRI', 'GHI_CHU', 'NGUOI_DAI_DIEN', 'MA_TRUONGKHOA', 'NGAY_CT_130', 'NGAY_CT', 'TEN_TRUONGKHOA', 'HO_TEN_CHA', 'HO_TEN_ME', 'TEKT', 'SoVaoVien', 'SoBenhAn', 'KHOARAVIEN', 'GhiChu', 'SoDienThoai'];

    List: ztmp_BHXH_CT03[] | undefined;
    ListFilter: ztmp_BHXH_CT03[] | undefined;
    FormData!: ztmp_BHXH_CT03;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ztmp_BHXH_CT03";
    }
}

