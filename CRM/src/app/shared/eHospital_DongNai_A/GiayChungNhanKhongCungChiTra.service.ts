import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { GiayChungNhanKhongCungChiTra } from './GiayChungNhanKhongCungChiTra.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class GiayChungNhanKhongCungChiTraService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'GiayChungNhan_ID', 'SoGiayChungNhan', 'TiepNhan_ID', 'BenhAn_ID', 'BenhNhan_ID', 'GiaTri_TuNgay', 'GiaTri_DenNgay', 'NoiDangKyKham_ID', 'Du5Nam_TuNgay', 'ThoiDiemCungChiTra', 'DoiTuong_ID', 'SoTheBHYT', 'BHYT_TuNgay', 'BHYT_DenNgay', 'HieuLuc_TuNgay', 'HieuLuc_DenNgay', 'NguoiTao_ID', 'NgayTao', 'NguoiCapNhat_ID', 'NgayCapNhat'];

    List: GiayChungNhanKhongCungChiTra[] | undefined;
    ListFilter: GiayChungNhanKhongCungChiTra[] | undefined;
    FormData!: GiayChungNhanKhongCungChiTra;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "GiayChungNhanKhongCungChiTra";
    }
}

