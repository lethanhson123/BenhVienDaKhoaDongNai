import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ClsKetQuaTrungTamNghienCuu } from './ClsKetQuaTrungTamNghienCuu.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ClsKetQuaTrungTamNghienCuuService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ClsKetQua_XetNghiemTrungTamNgienCuu_Id', 'ClsKetQua_Id', 'MaSoPhieu', 'BenhNhan_Id', 'BacSyChiDinh_Id', 'NoiGuiMau_id', 'NgayNhanMau', 'LoaiMau_Id', 'ThucHienKyThuat', 'ThietBi_Id', 'NguoiThucHien_Id', 'CachThucSuDung_Id', 'ThongTinSuDung', 'KetLuan', 'KetQua', 'KetQua_Text', 'ThongTin', 'ThongTin_Text', 'ThoiGianThucHien', 'DonViThucHien_Id', 'GhiChu', 'MaXN'];

    List: ClsKetQuaTrungTamNghienCuu[] | undefined;
    ListFilter: ClsKetQuaTrungTamNghienCuu[] | undefined;
    FormData!: ClsKetQuaTrungTamNghienCuu;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ClsKetQuaTrungTamNghienCuu";
    }
}

