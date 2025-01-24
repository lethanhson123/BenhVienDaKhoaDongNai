import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NoiTru_DichVu } from './NoiTru_DichVu.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NoiTru_DichVuService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'NoiTru_DichVu_Id', 'SoPhieu', 'BenhAn_Id', 'LuuTru_Id', 'NgayYeuCau', 'ThoiGianYeuCau', 'BacSi_Id', 'NhomDichVu_Id', 'DichVu_Id', 'SoLuong', 'DonGiaPhaiThu', 'DonGia', 'TyLeVAT', 'GiaTriVAT', 'TienTe_Id', 'TyGia', 'LoaiGia_Id', 'MoTim', 'ThucHienTaiPhongMo', 'NoiThucHien_Id', 'NguonMau_Id', 'GhiChu', 'CoKetQua', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'KetQua', 'NgayThucHien', 'ThoiGianThucHien', 'MienPhi'];

    List: NoiTru_DichVu[] | undefined;
    ListFilter: NoiTru_DichVu[] | undefined;
    FormData!: NoiTru_DichVu;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NoiTru_DichVu";
    }
}

