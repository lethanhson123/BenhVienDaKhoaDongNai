import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { KSK_HopDong_BenhNhan_DichVu } from './KSK_HopDong_BenhNhan_DichVu.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class KSK_HopDong_BenhNhan_DichVuService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'HopDong_DichVu_BenhNhan_id', 'HopDong_id', 'HopDong_DichVu_Id', 'HopDong_BenhNhan_Id', 'Phongban_id', 'TrangThai', 'DaThuTien', 'KetQua', 'Selected', 'Sophieuyeucau', 'clsyeucau_id', 'clsyeucauchitiet_id', 'Dataophieu', 'Benhnhan_ehos_id', 'Tiepnhan_id', 'BatThuong', 'MucBinhThuongMin', 'MucBinhThuongMax', 'Dathuchien', 'Inbc', 'PhanLoai'];

    List: KSK_HopDong_BenhNhan_DichVu[] | undefined;
    ListFilter: KSK_HopDong_BenhNhan_DichVu[] | undefined;
    FormData!: KSK_HopDong_BenhNhan_DichVu;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "KSK_HopDong_BenhNhan_DichVu";
    }
}

