import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { TreSoSinh } from './TreSoSinh.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class TreSoSinhService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'TreSoSinh_Id', 'BenhAn_Id', 'NgaySinh', 'ThoiGianSinh', 'GioiTinh', 'DiTat', 'TatBamSinh', 'ChieuCao', 'CanNang', 'Apgar', 'QuyenSo', 'TinhTrang_Id', 'TinhTrangRaVien_Id', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: TreSoSinh[] | undefined;
    ListFilter: TreSoSinh[] | undefined;
    FormData!: TreSoSinh;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "TreSoSinh";
    }
}

