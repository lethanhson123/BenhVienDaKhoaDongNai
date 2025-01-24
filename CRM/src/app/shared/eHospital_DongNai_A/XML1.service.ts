import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { XML1 } from './XML1.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class XML1Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'XML1_id', 'LoaiKCB', 'IdMaLienKet', 'MA_BN', 'HO_TEN', 'NGAY_SINH', 'GIOI_TINH', 'DIA_CHI', 'MA_THE', 'MA_DKBD', 'GT_THE_TU', 'GT_THE_DEN', 'TEN_BENH', 'MA_BENH', 'MA_BENHKHAC', 'MA_LYDO_VVIEN', 'MA_NOI_CHUYEN', 'MA_TAI_NAN', 'NGAY_VAO', 'NGAY_RA', 'NGAY_VAO_NOI_TRU', 'SO_NGAY_DTRI', 'KET_QUA_DTRI', 'TINH_TRANG_RV', 'NGAY_TTOAN', 'MIEN_CUNG_CT', 'T_THUOC', 'T_VTYT', 'T_TONGCHI', 'T_BHTT', 'T_BNTT', 'T_BNCCT', 'T_NGUONKHAC', 'T_NGOAIDS', 'NAM_QT', 'THANG_QT', 'MA_LOAI_KCB', 'MA_KHOA', 'MA_CSKCB', 'MA_KHUVUC', 'MA_PTTT_QT', 'CAN_NANG', 'NgayTao', 'NguoiTao', 'NgayCapNhat', 'NguoiCapNhat'];

    List: XML1[] | undefined;
    ListFilter: XML1[] | undefined;
    FormData!: XML1;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "XML1";
    }
}

