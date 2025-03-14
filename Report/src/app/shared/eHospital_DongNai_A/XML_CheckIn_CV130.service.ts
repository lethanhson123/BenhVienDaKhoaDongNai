import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { XML_CheckIn_CV130 } from './XML_CheckIn_CV130.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class XML_CheckIn_CV130Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'XML_CheckIn_CV130_Id', 'BenhAn_Id', 'TiepNhan_Id', 'BenhNhan_Id', 'XacNhanChiPhi_Id', 'MA_LK', 'STT', 'MA_BN', 'HO_TEN', 'SO_CCCD', 'NGAY_SINH', 'GIOI_TINH', 'MA_THE_BHYT', 'MA_DKBD', 'GT_THE_TU', 'GT_THE_DEN', 'MA_DOITUONG_KCB', 'NGAY_VAO', 'NGAY_VAO_NOI_TRU', 'LY_DO_VNT', 'MA_LY_DO_VNT', 'MA_LOAI_KCB', 'MA_CSKCB', 'MA_DICH_VU', 'TEN_DICH_VU', 'NGAY_YL', 'MA_THUOC', 'TEN_THUOC', 'MA_VAT_TU', 'TEN_VAT_TU', 'DU_PHONG', 'DaGui'];

    List: XML_CheckIn_CV130[] | undefined;
    ListFilter: XML_CheckIn_CV130[] | undefined;
    FormData!: XML_CheckIn_CV130;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "XML_CheckIn_CV130";
    }
}

