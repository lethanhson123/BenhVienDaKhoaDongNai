import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { KSK_HopDong_DichVu } from './KSK_HopDong_DichVu.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class KSK_HopDong_DichVuService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'HopDong_DichVu_Id', 'HopDong_Id', 'DichVu_Id', 'PhongBan_Id', 'DonGiaPhaiThu', 'DonGia', 'TienTe_Id', 'TyGia', 'MoTa', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'Idx'];

    List: KSK_HopDong_DichVu[] | undefined;
    ListFilter: KSK_HopDong_DichVu[] | undefined;
    FormData!: KSK_HopDong_DichVu;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "KSK_HopDong_DichVu";
    }
}

