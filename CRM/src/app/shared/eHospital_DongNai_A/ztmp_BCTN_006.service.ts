import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ztmp_BCTN_006 } from './ztmp_BCTN_006.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ztmp_BCTN_006Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MaPhongBan', 'mpb', 'Gai', 'New', 'Ratoa', 'VaoVien', 'NgoaiTru', 'ChuyenVien', 'ChuyenVienBHYT', 'ChuyenVienTE', 'HenTaiKham', 'Khac', 'VP', 'BHYT', 'DoiTuongKhac', 'Tre6t', 'DTKhac', 'Sang', 'Chieu', 'SoNgayDT', 'Tre15t'];

    List: ztmp_BCTN_006[] | undefined;
    ListFilter: ztmp_BCTN_006[] | undefined;
    FormData!: ztmp_BCTN_006;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ztmp_BCTN_006";
    }
}

