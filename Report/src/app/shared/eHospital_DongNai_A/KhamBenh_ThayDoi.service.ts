import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { KhamBenh_ThayDoi } from './KhamBenh_ThayDoi.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class KhamBenh_ThayDoiService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KhamBenh_ThayDoi_Id', 'HoaDonChiTiet_Id', 'DichVu_Id', 'PhongBan_Id', 'DichVu_ThayDoi_Id', 'PhongBan_ThayDoi_Id', 'LanThayDoi', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: KhamBenh_ThayDoi[] | undefined;
    ListFilter: KhamBenh_ThayDoi[] | undefined;
    FormData!: KhamBenh_ThayDoi;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "KhamBenh_ThayDoi";
    }
}

