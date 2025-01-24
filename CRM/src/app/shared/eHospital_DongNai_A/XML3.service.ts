import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { XML3 } from './XML3.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class XML3Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'XML3_id', 'LoaiKCB', 'IdMaLienKet', 'Loai_IDRef', 'IDRef', 'MA_DICH_VU', 'MA_VAT_TU', 'MA_NHOM', 'TEN_DICH_VU', 'DON_VI_TINH', 'SO_LUONG', 'DON_GIA', 'TYLE_TT', 'THANH_TIEN', 'TEN_VAT_TU', 'GOI_VTYT', 'PHAM_VI', 'TT_THAU', 'T_TRANTT', 'MUC_HUONG', 'T_BNTT', 'T_BHTT', 'T_BNCCT', 'MA_GIUONG', 'T_NGOAIDS', 'T_NGUONKHAC', 'MA_KHOA', 'MA_BAC_SI', 'MA_BENH', 'NGAY_YL', 'NGAY_KQ', 'MA_PTTT', 'NgayTao', 'NguoiTao', 'NgayCapNhat', 'NguoiCapNhat'];

    List: XML3[] | undefined;
    ListFilter: XML3[] | undefined;
    FormData!: XML3;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "XML3";
    }
}

