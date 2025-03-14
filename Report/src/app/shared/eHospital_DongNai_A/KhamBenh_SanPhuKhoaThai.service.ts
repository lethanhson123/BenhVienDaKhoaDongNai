import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { KhamBenh_SanPhuKhoaThai } from './KhamBenh_SanPhuKhoaThai.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class KhamBenh_SanPhuKhoaThaiService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KhamBenh_SanPhuKhoaThai_Id', 'BenhNhan_Id', 'KhamBenh_Id', 'NgayKinhCuoiDS', 'TienCanBenhLy', 'ChieuCao', 'CanNang', 'NgayTuoiThai', 'HA', 'Phu', 'BCTC', 'ThaiMay', 'TimThay', 'NgoiThai', 'CTC', 'KetLuan', 'NguoiKham_Id', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: KhamBenh_SanPhuKhoaThai[] | undefined;
    ListFilter: KhamBenh_SanPhuKhoaThai[] | undefined;
    FormData!: KhamBenh_SanPhuKhoaThai;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "KhamBenh_SanPhuKhoaThai";
    }
}

