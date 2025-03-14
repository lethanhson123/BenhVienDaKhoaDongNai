import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CDT_KeHoachHoiThao_BVThamGia } from './CDT_KeHoachHoiThao_BVThamGia.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CDT_KeHoachHoiThao_BVThamGiaService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'CDT_KeHoachHoiThao_Id', 'HoiThao_Id', 'BenhVien_Id', 'SoLuongThamGia', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: CDT_KeHoachHoiThao_BVThamGia[] | undefined;
    ListFilter: CDT_KeHoachHoiThao_BVThamGia[] | undefined;
    FormData!: CDT_KeHoachHoiThao_BVThamGia;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CDT_KeHoachHoiThao_BVThamGia";
    }
}

