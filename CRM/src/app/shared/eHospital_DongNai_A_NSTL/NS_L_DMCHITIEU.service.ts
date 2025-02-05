import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_L_DMCHITIEU } from './NS_L_DMCHITIEU.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_L_DMCHITIEUService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MaChiTieu', 'TenChiTieu', 'CongThuc', 'GiaTri', 'ThuTuTinhToan', 'ThuTuTrenBaoCaoLuong', 'HienThiHayKhong', 'ThuTuSapXep', 'LoaiChiTieu', 'ThuTuTrenPhieuLuong', 'TinhChat', 'ChuyenThangSau'];

    List: NS_L_DMCHITIEU[] | undefined;
    ListFilter: NS_L_DMCHITIEU[] | undefined;
    FormData!: NS_L_DMCHITIEU;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_L_DMCHITIEU";
    }
}

