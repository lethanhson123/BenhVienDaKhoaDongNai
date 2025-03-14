import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CDT_KeHoachHoiThao_CBThamGia } from './CDT_KeHoachHoiThao_CBThamGia.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CDT_KeHoachHoiThao_CBThamGiaService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'CDT_KeHoachHoiThao_Id', 'HoiThao_Id', 'NhanVien_Id', 'BenhVien_Id', 'GhiChu', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: CDT_KeHoachHoiThao_CBThamGia[] | undefined;
    ListFilter: CDT_KeHoachHoiThao_CBThamGia[] | undefined;
    FormData!: CDT_KeHoachHoiThao_CBThamGia;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CDT_KeHoachHoiThao_CBThamGia";
    }
}

