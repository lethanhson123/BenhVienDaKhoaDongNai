import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CSKH_The_KhuyenMaiKSKTongQuat } from './CSKH_The_KhuyenMaiKSKTongQuat.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CSKH_The_KhuyenMaiKSKTongQuatService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'The_KSKTongQuat_Id', 'The_Id', 'LoaiKhachHang_Id', 'TyLe', 'SoLan', 'TuoiMin', 'TuoiMax', 'CoHen', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'CTKhamSucKhoe_Id', 'TatCaChuongTrinhKSK', 'SoLanSuDung'];

    List: CSKH_The_KhuyenMaiKSKTongQuat[] | undefined;
    ListFilter: CSKH_The_KhuyenMaiKSKTongQuat[] | undefined;
    FormData!: CSKH_The_KhuyenMaiKSKTongQuat;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CSKH_The_KhuyenMaiKSKTongQuat";
    }
}

