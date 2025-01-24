import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BenhNhan_Di_UngThuoc } from './BenhNhan_Di_UngThuoc.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BenhNhan_Di_UngThuocService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhNhan_Di_UngThuoc_Id', 'BenhNhan_Id', 'Duoc_Id', 'NgayPhatHien', 'TinhTrang', 'GhiChu', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_id', 'NhanVien_Id'];

    List: BenhNhan_Di_UngThuoc[] | undefined;
    ListFilter: BenhNhan_Di_UngThuoc[] | undefined;
    FormData!: BenhNhan_Di_UngThuoc;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BenhNhan_Di_UngThuoc";
    }
}

