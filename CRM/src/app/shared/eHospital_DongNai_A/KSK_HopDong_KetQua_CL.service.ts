import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { KSK_HopDong_KetQua_CL } from './KSK_HopDong_KetQua_CL.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class KSK_HopDong_KetQua_CLService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KSK_HopDong_KetQua_CL_ID', 'MauCheckList_Id', 'HopDong_ID', 'BenhNhan_ID', 'Col_Int_1', 'Col_Int_2', 'Col_Int_3', 'Col_Int_4', 'Col_Int_5', 'Col_Int_6', 'Col_Int_7', 'Col_Int_8', 'Col_Int_9', 'Col_Int_10', 'Col_Text_1', 'Col_Text_2', 'Col_Text_3', 'Col_Text_4', 'Col_Text_5', 'Col_Text_6', 'Col_Text_7', 'Col_Text_8', 'Col_Text_9', 'Col_Text_10', 'Col_DateTime_1', 'Col_DateTime_2', 'Col_DateTime_3', 'Col_DateTime_4', 'Col_DateTime_5', 'Col_DateTime_6', 'Col_DateTime_7', 'Col_DateTime_8', 'Col_DateTime_9', 'Col_DateTime_10', 'TamNgung', 'Ma_MauCheckList_Column', 'Idx', 'Col_Decimal_1', 'Col_Decimal_2', 'Col_Decimal_3', 'Col_Decimal_4', 'Col_Decimal_5', 'Col_Decimal_6', 'Col_Decimal_7', 'Col_Decimal_8', 'Col_Decimal_9', 'Col_Decimal_10', 'Col_Bit_1', 'Col_Bit_2', 'Col_Bit_3', 'Col_Bit_4', 'Col_Bit_5', 'Col_Bit_6', 'Col_Bit_7', 'Col_Bit_8', 'Col_Bit_9', 'Col_Bit_10', 'NgayTao', 'NguoiTao_ID', 'NgayCapNhat', 'NguoiCapNhat_ID', 'KetQuaCheckList_Id'];

    List: KSK_HopDong_KetQua_CL[] | undefined;
    ListFilter: KSK_HopDong_KetQua_CL[] | undefined;
    FormData!: KSK_HopDong_KetQua_CL;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "KSK_HopDong_KetQua_CL";
    }
}

