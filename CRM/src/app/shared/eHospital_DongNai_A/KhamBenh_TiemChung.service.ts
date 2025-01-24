import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { KhamBenh_TiemChung } from './KhamBenh_TiemChung.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class KhamBenh_TiemChungService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KhamBenh_TiemChung_Id', 'BenhNhan_Id', 'KhamBenh_Id', 'Duoc_Id', 'LoSuDung', 'HanSuDung', 'NgaySuDung', 'NoiDungTiemNgua_Id', 'LanTiem', 'NhietDoBatDauTiem', 'NhietDoHetBuoiTiem', 'NguoiTiem_Id', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'BacSi_Id', 'TiepNhan_Id', 'YeuCauChiTiet_Id'];

    List: KhamBenh_TiemChung[] | undefined;
    ListFilter: KhamBenh_TiemChung[] | undefined;
    FormData!: KhamBenh_TiemChung;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "KhamBenh_TiemChung";
    }
}

