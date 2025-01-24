import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { KhamGayMe_TreEm } from './KhamGayMe_TreEm.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class KhamGayMe_TreEmService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KhamGayMe_TreEm_Id', 'SoPhieuGayMe', 'BenhNhan_Id', 'TiepNhan_Id', 'BenhAn_Id', 'CLSYeuCau_Id', 'NgayThucHien', 'ThoiGianThucHien', 'BacSiGayMe_Id', 'SanKhoa', 'TuoiThaiLucSinh', 'CanNangLucSinh', 'Sinh_ID', 'TinhTrangSauSinh', 'ThoiGianDuKienPhauThuat', 'ThoiGianNhinAn', 'TinhTrangVenNgoai', 'EMLA', 'Thuoc', 'ThoiGian', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: KhamGayMe_TreEm[] | undefined;
    ListFilter: KhamGayMe_TreEm[] | undefined;
    FormData!: KhamGayMe_TreEm;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "KhamGayMe_TreEm";
    }
}

