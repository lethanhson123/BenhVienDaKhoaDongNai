import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_NGACHBACLUONG } from './NS_NGACHBACLUONG.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_NGACHBACLUONGService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'MaNhanVien', 'Ngayxep', 'MaNgach', 'Ngach', 'Bac', 'HeSo', 'PhuCap', 'MucHuong', 'LoaiHeSo', 'id', 'NgayNangLuong', 'SoQuyetDinh', 'NgayQuyetDinh', 'PhuCapTNVK', 'PhuCapTNVK_Moi', 'HeSoQD276', 'HeSoDocHai', 'UuDaiNghe', 'TGNangLuongSom', 'TGKeoDai', 'SoThangTapSu', 'HeSoLuongChinh', 'HeSoKhuyenKhich', 'HeSoKiemNhiem', 'HeSoUuDaiTTUT', 'HeSoK', 'NgayHuongBV', 'HienVatMuc', 'MaMucHuongDocHai', 'HeSoTTND', 'HeSoThamNien'];

    List: NS_NGACHBACLUONG[] | undefined;
    ListFilter: NS_NGACHBACLUONG[] | undefined;
    FormData!: NS_NGACHBACLUONG;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_NGACHBACLUONG";
    }
}

