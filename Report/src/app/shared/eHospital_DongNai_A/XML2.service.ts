import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { XML2 } from './XML2.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class XML2Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'XML2_id', 'LoaiKCB', 'IdMaLienKet', 'Loai_IDRef', 'IDRef', 'MA_THUOC', 'MA_NHOM', 'TEN_THUOC', 'DON_VI_TINH', 'HAM_LUONG', 'DUONG_DUNG', 'LIEU_DUNG', 'SO_DANG_KY', 'SO_LUONG', 'DON_GIA', 'TYLE_TT', 'THANH_TIEN', 'TT_THAU', 'PHAM_VI', 'MUC_HUONG', 'T_BNTT', 'T_BHTT', 'T_BNCCT', 'T_NGUONKHAC', 'T_NGOAIDS', 'MA_KHOA', 'MA_BAC_SI', 'MA_BENH', 'NGAY_YL', 'MA_PTTT', 'NgayTao', 'NguoiTao', 'NgayCapNhat', 'NguoiCapNhat'];

    List: XML2[] | undefined;
    ListFilter: XML2[] | undefined;
    FormData!: XML2;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "XML2";
    }
}

