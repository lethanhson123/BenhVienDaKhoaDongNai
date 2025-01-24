import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { SinhHieu } from './SinhHieu.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class SinhHieuService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'SinhHieu_Id', 'BenhNhan_Id', 'KhamBenh_Id', 'NgayDo', 'ThoiGianDo', 'NguoiDo_Id', 'PhongBan_Id', 'Mach', 'HuyetApThap', 'HuyetApCao', 'NhipTho', 'NhietDo', 'ChieuCao', 'CanNang', 'ChiSoBMI', 'VongBung', 'GhiChu', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'NoiTru_khamBenh_Id', 'VongDau', 'SpO2'];

    List: SinhHieu[] | undefined;
    ListFilter: SinhHieu[] | undefined;
    FormData!: SinhHieu;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "SinhHieu";
    }
}

