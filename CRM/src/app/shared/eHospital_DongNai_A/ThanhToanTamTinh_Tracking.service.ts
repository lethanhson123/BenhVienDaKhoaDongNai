import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ThanhToanTamTinh_Tracking } from './ThanhToanTamTinh_Tracking.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ThanhToanTamTinh_TrackingService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'TiepNhan_Id', 'BenhNhan_Id', 'IDRef', 'Loai_IDRef', 'DonGiaDoanhThu', 'DonGiaHoTro', 'DonGiaHoTroChiTra', 'DonGiaThanhToan', 'DoiTuong_Id', 'SoLuong', 'TyLe', 'ThoiGian'];

    List: ThanhToanTamTinh_Tracking[] | undefined;
    ListFilter: ThanhToanTamTinh_Tracking[] | undefined;
    FormData!: ThanhToanTamTinh_Tracking;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ThanhToanTamTinh_Tracking";
    }
}

