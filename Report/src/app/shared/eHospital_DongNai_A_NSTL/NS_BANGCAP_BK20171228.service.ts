import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_BANGCAP_BK20171228 } from './NS_BANGCAP_BK20171228.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_BANGCAP_BK20171228Service extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'MaNhanVien', 'TenBangCap', 'ChuyenNganh', 'Noicapbang', 'Ngaycapbang', 'Xeploai', 'SoVanBang', 'NganhHoc', 'HinhThucDaoTao', 'DuaLenBaoCao'];

    List: NS_BANGCAP_BK20171228[] | undefined;
    ListFilter: NS_BANGCAP_BK20171228[] | undefined;
    FormData!: NS_BANGCAP_BK20171228;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_BANGCAP_BK20171228";
    }
}

