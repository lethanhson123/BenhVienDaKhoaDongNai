import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BenhAnTongQuat_NhiKhoa } from './BenhAnTongQuat_NhiKhoa.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BenhAnTongQuat_NhiKhoaService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhAnTongQuat_ChiTiet_Id', 'BenhAnTongQuat_Id', 'Field_1', 'Field_2', 'Field_3', 'Field_4', 'Field_5', 'Field_6', 'Field_7', 'Field_8', 'Field_9', 'Field_10', 'Field_11', 'Field_12', 'Field_13', 'Field_14', 'Field_15', 'Field_16', 'Field_17', 'Field_18', 'Field_19', 'Field_20', 'Field_21', 'Field_22', 'Field_23', 'Field_24', 'Field_25', 'Field_26', 'Field_27', 'Field_28', 'Field_29', 'Field_30', 'Field_31', 'Field_32', 'Field_33', 'Field_34', 'Field_35', 'Field_36', 'Field_37', 'Field_38', 'Field_39', 'Field_40', 'Field_41', 'Field_42', 'Field_43', 'Field_44', 'Field_45', 'Field_46', 'Field_47', 'Field_48', 'Field_49', 'Field_50', 'Field_51', 'Field_52', 'Field_53', 'Field_54', 'Field_55', 'Field_56', 'Field_57', 'Field_58', 'Field_59', 'Field_60', 'Field_61', 'Field_62', 'Field_63'];

    List: BenhAnTongQuat_NhiKhoa[] | undefined;
    ListFilter: BenhAnTongQuat_NhiKhoa[] | undefined;
    FormData!: BenhAnTongQuat_NhiKhoa;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BenhAnTongQuat_NhiKhoa";
    }
}

