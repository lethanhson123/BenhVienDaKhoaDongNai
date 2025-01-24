import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_TAIKHOAN_MAP } from './DM_TAIKHOAN_MAP.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_TAIKHOAN_MAPService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MaDoiTuong', 'Module', 'TaiKhoanCo', 'TaiKhoanNo', 'DangSuDung', 'DienGiai', 'TKThueNo', 'TKThueCo', 'Nguon', 'UserID', 'GhiChu', 'LoaiCT'];

    List: DM_TAIKHOAN_MAP[] | undefined;
    ListFilter: DM_TAIKHOAN_MAP[] | undefined;
    FormData!: DM_TAIKHOAN_MAP;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_TAIKHOAN_MAP";
    }
}

