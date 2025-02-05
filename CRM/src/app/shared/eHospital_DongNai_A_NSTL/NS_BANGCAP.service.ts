import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_BANGCAP } from './NS_BANGCAP.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_BANGCAPService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'MaNhanVien', 'TenBangCap', 'ChuyenNganh', 'Noicapbang', 'Ngaycapbang', 'Xeploai', 'SoVanBang', 'NganhHoc', 'HinhThucDaoTao', 'DuaLenBaoCao'];

    List: NS_BANGCAP[] | undefined;
    ListFilter: NS_BANGCAP[] | undefined;
    FormData!: NS_BANGCAP;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_BANGCAP";
    }
}

