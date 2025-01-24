import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CDT_LichCongTac_KetQua } from './CDT_LichCongTac_KetQua.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CDT_LichCongTac_KetQuaService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'CDT_LichCongTac_KetQua_Id', 'CDT_LichCongTac_Id', 'KetQua', 'SoNguoiThamGia', 'SoNgayThucHien', 'ThanhPhanThamGia', 'CDT_PhanLoaiKetQua_Id', 'KinhPhiThucHien'];

    List: CDT_LichCongTac_KetQua[] | undefined;
    ListFilter: CDT_LichCongTac_KetQua[] | undefined;
    FormData!: CDT_LichCongTac_KetQua;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CDT_LichCongTac_KetQua";
    }
}

