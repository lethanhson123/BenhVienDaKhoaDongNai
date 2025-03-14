import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CDT_KeHoachDaoTao } from './CDT_KeHoachDaoTao.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CDT_KeHoachDaoTaoService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'CDT_KeHoachDaoTao_Id', 'KhoaHoc_Id', 'HocVien_Id', 'NhanVien_Id', 'NoiCongTac', 'KetQua_Id', 'TenBangCap', 'XepLoai_Id', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'MaNhanVien_Id', 'LoaiNhanVien', 'NoiCapBang', 'GhiChu'];

    List: CDT_KeHoachDaoTao[] | undefined;
    ListFilter: CDT_KeHoachDaoTao[] | undefined;
    FormData!: CDT_KeHoachDaoTao;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CDT_KeHoachDaoTao";
    }
}

