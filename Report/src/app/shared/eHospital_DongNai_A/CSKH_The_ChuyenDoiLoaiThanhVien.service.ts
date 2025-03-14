import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CSKH_The_ChuyenDoiLoaiThanhVien } from './CSKH_The_ChuyenDoiLoaiThanhVien.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CSKH_The_ChuyenDoiLoaiThanhVienService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'The_ChuyenDoiLoaiThanhVien_Id', 'The_Id', 'LoaiKhachHang_Id', 'LoaiThanhVienDuocPhepChuyen_Id', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: CSKH_The_ChuyenDoiLoaiThanhVien[] | undefined;
    ListFilter: CSKH_The_ChuyenDoiLoaiThanhVien[] | undefined;
    FormData!: CSKH_The_ChuyenDoiLoaiThanhVien;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CSKH_The_ChuyenDoiLoaiThanhVien";
    }
}

