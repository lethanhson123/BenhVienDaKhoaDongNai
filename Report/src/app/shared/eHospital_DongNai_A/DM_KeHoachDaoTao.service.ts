import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_KeHoachDaoTao } from './DM_KeHoachDaoTao.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_KeHoachDaoTaoService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KhoaHoc_Id', 'MaKhoaHoc', 'TenKhoaHoc', 'NgayBatDau', 'NgayKetThuc', 'DiaDiem', 'LoaiKhoaHoc_Id', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'GoiKT', 'ThoiGianDT', 'SCApDung', 'SCCoKQTot', 'SCTaiBien', 'SCChuyenTuyen', 'SCTuVong', 'GhiChu'];

    List: DM_KeHoachDaoTao[] | undefined;
    ListFilter: DM_KeHoachDaoTao[] | undefined;
    FormData!: DM_KeHoachDaoTao;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_KeHoachDaoTao";
    }
}

