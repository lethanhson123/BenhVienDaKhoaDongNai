import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ChiPhiChiTiet_DoiTuong } from './ChiPhiChiTiet_DoiTuong.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ChiPhiChiTiet_DoiTuongService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ChiPhiChiTiet_DoiTuong_Id', 'IDRef', 'Loai_IDRef', 'TiepNhan_DoiTuongThayDoi_Id', 'DoiTuong_Id', 'YeuCauChiTiet_Id', 'ToaThuoc_Id', 'ToaThuocTra_Id', 'BenhAnPhauThuat_VTYT_ID', 'ChungTuXuatBN_Id', 'NguoiTao_Id', 'NgayTao'];

    List: ChiPhiChiTiet_DoiTuong[] | undefined;
    ListFilter: ChiPhiChiTiet_DoiTuong[] | undefined;
    FormData!: ChiPhiChiTiet_DoiTuong;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ChiPhiChiTiet_DoiTuong";
    }
}

