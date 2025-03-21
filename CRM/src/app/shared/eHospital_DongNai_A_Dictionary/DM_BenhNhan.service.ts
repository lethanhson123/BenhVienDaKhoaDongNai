﻿import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DM_BenhNhan } from './DM_BenhNhan.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DM_BenhNhanService extends BaseService {
    DisplayColumns001: string[] = ['Save', 'STT', 'BenhNhan_Id', 'MaYTe', 'MaBenhVien', 'SoVaoVien', 'TenBenhNhan', 'Ho', 'Ten', 'GioiTinh', 'NgaySinh', 'NamSinh', 'SoNha', 'DiaChi', 'NhomMau_Id', 'YeuToRh_Id', 'TienSuDiUng', 'SoLuuTruNgoaiTru', 'SoLuuTruNoiTru', 'QuocTich_Id', 'TinhThanh_Id', 'QuanHuyen_Id', 'XaPhuong_Id', 'DanToc_Id', 'NgheNghiep_Id', 'VietKieu', 'NguoiNuocNgoai', 'CMND', 'HoChieu', 'TenKhongDau', 'GhiChu', 'NgayTao', 'NguoiTao_Id', 'NgayCapNhat', 'NguoiCapNhat_Id', 'NgayCapThe', 'NamCapThe', 'ThoiGianCapThe', 'NhanVien_Id', 'TienSuBenh', 'TienSuHutThuocLa', 'DonViCongTac_Id', 'SoDienThoai', 'DiaChiThuongTru', 'DiaChiLienLac', 'Email', 'DiaChiCoQuan', 'TuVong', 'NgayTuVong', 'ThoiGianTuVong', 'NguyenNhanTuVong_Id', 'NguoiGhiNhanTuVong_Id', 'ThoiGianGhiNhanTuVong', 'CountNotes', 'ngaytaobenhnhan', 'TinhTrangHonNhan_Id', 'MoiQuanHe_Id', 'DienThoaiBan', 'NguoiLienHe', 'DienThoai_NLH', 'SiteCode', 'Mapping_Public_Id', 'MaDinhDanh_PID', 'Status_PID', 'CMND_NgayCap', 'CMND_NoiCap', 'SoBHXH', 'SoBHXH_NgayCap', 'TenCha', 'TenMe', 'TenVoChong'];
    DisplayColumns002: string[] = ['STT', 'BenhNhan_Id', 'MaYTe', 'CMND', 'SoDienThoai', 'TenBenhNhan', 'GioiTinh', 'NamSinh', 'DiaChi'];

    List: DM_BenhNhan[] | undefined;
    ListFilter: DM_BenhNhan[] | undefined;
    FormData!: DM_BenhNhan;
    
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DM_BenhNhan";
    }
    GetByBenhNhan_IdAsync() {
        let url = this.APIURL + this.Controller + '/GetByBenhNhan_IdAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetBySearchStringAsync() {
        let url = this.APIURL + this.Controller + '/GetBySearchStringAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetByTinhThanh_Id_QuanHuyen_Id_XaPhuong_Id_SearchStringToListAsync() {
        let url = this.APIURL + this.Controller + '/GetByTinhThanh_Id_QuanHuyen_Id_XaPhuong_Id_SearchStringToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetByTinhThanh_Id_QuanHuyen_Id_XaPhuong_Id_SearchString_PageToListAsync() {
        let url = this.APIURL + this.Controller + '/GetByTinhThanh_Id_QuanHuyen_Id_XaPhuong_Id_SearchString_PageToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetByTinhThanh_Id_QuanHuyen_Id_XaPhuong_Id_SearchString_PageToCountAsync() {
        let url = this.APIURL + this.Controller + '/GetByTinhThanh_Id_QuanHuyen_Id_XaPhuong_Id_SearchString_PageToCountAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetByListIDToListAsync() {
        let url = this.APIURL + this.Controller + '/GetByListIDToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

