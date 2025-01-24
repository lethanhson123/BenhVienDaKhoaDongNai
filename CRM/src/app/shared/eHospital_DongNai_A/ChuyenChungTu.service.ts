import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ChuyenChungTu } from './ChuyenChungTu.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ChuyenChungTuService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'IDSession', 'LoaiCT', 'NgayChuyen', 'NgayHuy', 'NgayNhan', 'UserChuyen_Id', 'UserHuy_Id', 'UserNhan_Id', 'HoTenNguoiChuyen', 'HoTenNguoiHuy', 'HoTenNguoiNhan', 'TuNgay', 'DenNgay', 'ActionSession', 'Status'];

    List: ChuyenChungTu[] | undefined;
    ListFilter: ChuyenChungTu[] | undefined;
    FormData!: ChuyenChungTu;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ChuyenChungTu";
    }
}

