import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BenhAnPhauThuat_YeuCau } from './BenhAnPhauThuat_YeuCau.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BenhAnPhauThuat_YeuCauService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhAnPhauThuat_YeuCau_Id', 'BenhAnPhauThuat_Id', 'CLSYeuCau_Id', 'CLSYeuCauChiTiet_Id', 'NhomDichVu_Id', 'DichVu_Id', 'LoaiGia_Id', 'DonGiaDoanhThu', 'DonGiaThanhToan', 'LoaiTien_Id', 'TyGia'];

    List: BenhAnPhauThuat_YeuCau[] | undefined;
    ListFilter: BenhAnPhauThuat_YeuCau[] | undefined;
    FormData!: BenhAnPhauThuat_YeuCau;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BenhAnPhauThuat_YeuCau";
    }
}

