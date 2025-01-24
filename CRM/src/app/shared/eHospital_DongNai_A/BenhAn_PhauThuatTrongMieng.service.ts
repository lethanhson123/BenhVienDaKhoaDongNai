import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BenhAn_PhauThuatTrongMieng } from './BenhAn_PhauThuatTrongMieng.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class BenhAn_PhauThuatTrongMiengService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhAn_PhauThuatTrongMieng_Id', 'BenhAnNgoaiTru_Id', 'TSB_Mau', 'TSB_TimMach', 'TSB_TieuDuong', 'TSB_BenhKhac', 'TienLuong_Id', 'CKM_TenNguoiThan', 'CKM_DiaChi', 'CKM_DienThoai', 'CKM_NgayCamKet'];

    List: BenhAn_PhauThuatTrongMieng[] | undefined;
    ListFilter: BenhAn_PhauThuatTrongMieng[] | undefined;
    FormData!: BenhAn_PhauThuatTrongMieng;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "BenhAn_PhauThuatTrongMieng";
    }
}

