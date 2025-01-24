import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { KhamBenh_ChuyenKhoa } from './KhamBenh_ChuyenKhoa.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class KhamBenh_ChuyenKhoaService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KhamBenh_ChuyenKhoa_Id', 'PhongBan_Id', 'DichVu_Id', 'NgayChiDinh', 'ThoiGianChiDinh', 'BenhNhan_Id', 'TiepNhan_Id', 'KhamBenhChuyenDi_Id', 'KhamBenhDauTien_Id', 'LichHen_BenhNhan_Id', 'DuocPhepThucHien', 'YeuCauChiTiet_Id', 'GhiChu', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id'];

    List: KhamBenh_ChuyenKhoa[] | undefined;
    ListFilter: KhamBenh_ChuyenKhoa[] | undefined;
    FormData!: KhamBenh_ChuyenKhoa;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "KhamBenh_ChuyenKhoa";
    }
}

