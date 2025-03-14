import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CSKH_DM_GoiDichVu } from './CSKH_DM_GoiDichVu.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CSKH_DM_GoiDichVuService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'GoiDichVu_Id', 'MaGoiDichVu', 'TenGoiDicVu', 'TenGoiDicVu_EN', 'TenGoiDicVu_RU', 'SoTienThucThu', 'SoTienGoiKham', 'TienTe_Id', 'TyGia', 'NgayHieuLuc', 'NgayHetHan', 'Idx', 'GhiChu', 'TamNgung', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'Attribute1', 'Attribute2', 'Attribute3', 'Attribute4', 'Attribute5', 'GoiKhamSucKhoe', 'ChuyenKhoa_Id', 'Nam', 'Thang', 'Ngay', 'CostCenter_Id', 'SoNgayFU', 'KiemTraDieuKienKhoaGoi', 'CheckList'];

    List: CSKH_DM_GoiDichVu[] | undefined;
    ListFilter: CSKH_DM_GoiDichVu[] | undefined;
    FormData!: CSKH_DM_GoiDichVu;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CSKH_DM_GoiDichVu";
    }
}

