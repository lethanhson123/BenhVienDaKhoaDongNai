import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CSKH_The_DanhSachDoiTuongKM } from './CSKH_The_DanhSachDoiTuongKM.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CSKH_The_DanhSachDoiTuongKMService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'The_DSDoiTuongKM_Id', 'LoaiKhachHang_Id', 'DacTinh_Id', 'QuiDinh_Id', 'DoiTuong_Id'];

    List: CSKH_The_DanhSachDoiTuongKM[] | undefined;
    ListFilter: CSKH_The_DanhSachDoiTuongKM[] | undefined;
    FormData!: CSKH_The_DanhSachDoiTuongKM;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CSKH_The_DanhSachDoiTuongKM";
    }
}

