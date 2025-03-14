import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { PhieuChanDoanHoaMoMienDich } from './PhieuChanDoanHoaMoMienDich.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class PhieuChanDoanHoaMoMienDichService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'PhieuChanDoanHoaMoMienDich_Id', 'SoPhieu', 'CLSYeuCau_Id', 'BenhAn_Id', 'BenhNhan_Id', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'BSDieuTriLamSang_Id', 'BSGiaiPhauBenhLamSang_Id', 'BSGiaiPhauBenh_Id', 'Field_1', 'Field_2', 'Field_3', 'Field_4', 'Field_5', 'Field_6', 'Field_7', 'Field_8', 'Field_9', 'Field_10', 'Field_11', 'Field_12', 'Field_13', 'Field_14', 'Field_15', 'Field_16', 'Field_17', 'Field_18', 'Field_19', 'Field_20', 'Field_21', 'Field_22', 'Field_23', 'Field_24', 'Field_25', 'Field_26', 'Field_27'];

    List: PhieuChanDoanHoaMoMienDich[] | undefined;
    ListFilter: PhieuChanDoanHoaMoMienDich[] | undefined;
    FormData!: PhieuChanDoanHoaMoMienDich;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "PhieuChanDoanHoaMoMienDich";
    }
}

