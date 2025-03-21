import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { GoiSoChiTiet } from 'src/app/shared/GoiSoChiTiet.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class GoiSoChiTietService extends BaseService{

    DisplayColumns001: string[] = ['STT', 'ID', 'Name', 'Active'];   
    DisplayColumns002: string[] = ['DanhMucThanhVienID', 'Save'];   
    DisplayColumns003: string[] = ['STT', 'NgayCapSo', 'NgayCapSoSoThuTu', 'NgayDangKy', 'NgayDangKySoThuTu', 'NgayThanhToan', 'NgayThanhToanSoThuTu', 'NgayLinhThuoc', 'NgayLinhThuocSoThuTu', 'KhachHangID', 'Code', 'BHYT', 'CCCD', 'DienThoai', 'HoTen', 'NamSinh', 'GioiTinh'];   
    DisplayColumns004: string[] = ['STT', 'NgayCapSo', 'NgayCapSoSoThuTu', 'NgayDangKy', 'NgayDangKySoThuTu', 'NgayThanhToan', 'NgayThanhToanSoThuTu', 'NgayLinhThuoc', 'NgayLinhThuocSoThuTu', 'KhachHangID', 'Code', 'DienThoai', 'HoTen', 'NamSinh', 'GioiTinh', 'DanhMucTinhThanhName', 'DanhMucQuanHuyenName', 'DanhMucXaPhuongName'];   
    DisplayColumns005: string[] = ['STT', 'NgayCapSo', 'NgayCapSoSoThuTu', 'NgayTiepNhan', 'NgayTiepNhanSoThuTu', 'NgayThanhToan', 'NgayThanhToanSoThuTu', 'NgayLinhThuoc', 'NgayLinhThuocSoThuTu', 'KhachHangID', 'Code', 'DienThoai', 'HoTen', 'NamSinh', 'GioiTinh', 'DanhMucTinhThanhName', 'DanhMucQuanHuyenName', 'DanhMucXaPhuongName'];   
    DisplayColumns006: string[] = ['STT', 'NgayCapSo', 'NgayCapSoSoThuTu', 'NgayTiepNhan', 'NgayTiepNhanSoThuTu', 'NgayThanhToan', 'NgayThanhToanSoThuTu', 'NgayLinhThuoc', 'NgayLinhThuocSoThuTu', 'DanhMucNgonNguID', 'KhachHangID', 'Code', 'HoTen', 'NamSinh'];   
    DisplayColumns007: string[] = ['STT', 'NgayCapSo', 'NgayCapSoSoThuTu', 'NgayTiepNhan', 'NgayTiepNhanSoThuTu', 'NgayThanhToan', 'NgayThanhToanSoThuTu', 'NgayLinhThuoc', 'NgayLinhThuocSoThuTu', 'DanhMucNgonNguID', 'KhachHangID', 'Code', 'Description', 'HoTen', 'NamSinh', 'IsUuTien'];   
    DisplayColumns008: string[] = ['STT', 'DanhMucNgonNguID', 'KhachHangID', 'Code', 'Description', 'HoTen', 'NamSinh', 'IsUuTien', 'NgayCapSo', 'NgayCapSoSoThuTu', 'NgayTiepNhan', 'NgayTiepNhanSoThuTu', 'NgayThanhToan', 'NgayThanhToanSoThuTu', 'NgayLinhThuoc', 'NgayLinhThuocSoThuTu',];   
        
    List: GoiSoChiTiet[] | undefined;
    ListFilter: GoiSoChiTiet[] | undefined;
    FormData!: GoiSoChiTiet;

    ListFull: GoiSoChiTiet[] | undefined;
    List01: GoiSoChiTiet[] | undefined;
    List02: GoiSoChiTiet[] | undefined;    

    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "GoiSoChiTiet";
    }

    GetByDanhMucDichVuID_NgayCapSoSoThuTuAsync() {
        let url = this.APIURL + this.Controller + '/GetByDanhMucDichVuID_NgayCapSoSoThuTuAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetGoiSoChiTietDangKy01ToListAsync() {
        let url = this.APIURL + this.Controller + '/GetGoiSoChiTietDangKy01ToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetGoiSoChiTietDangKy02ToListAsync() {
        let url = this.APIURL + this.Controller + '/GetGoiSoChiTietDangKy02ToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetGoiSoChiTietDangKy03ToListAsync() {
        let url = this.APIURL + this.Controller + '/GetGoiSoChiTietDangKy03ToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }  
    GetByKhachHangIDToListAsync() {
        let url = this.APIURL + this.Controller + '/GetByKhachHangIDToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }  
}

