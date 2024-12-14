import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { KhachHang } from 'src/app/shared/KhachHang.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class KhachHangService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'ParentID', 'ParentName', 'CreatedDate', 'CreatedMembershipID', 'LastUpdatedDate', 'LastUpdatedMembershipID', 'RowVersion', 'SortOrder', 'Active', 'TypeName', 'Name', 'Code', 'Note', 'Display', 'FileName', 'Description', 'HTMLContent', 'DanhMucNgonNguID', 'DanhMucUngDungID', 'DanhMucNgonNguName', 'DanhMucUngDungName', 'DanhMucTinhThanhID', 'DanhMucTinhThanhName', 'DanhMucQuanHuyenID', 'DanhMucQuanHuyenName', 'DanhMucXaPhuongID', 'DanhMucXaPhuongName', 'DiaChi', 'HoTen', 'NamSinh', 'NgaySinh', 'GioiTinh', 'CCCD', 'DienThoai', 'Email', 'Zalo', 'BHYT'];

    List: KhachHang[] | undefined;
    ListFilter: KhachHang[] | undefined;
    FormData!: KhachHang;

    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "KhachHang";
    }
    GetBySearchStringToAsync() {
        let url = this.APIURL + this.Controller + '/GetBySearchStringToAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetByCodeToAsync() {
        let url = this.APIURL + this.Controller + '/GetByCodeToAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetByBHYTToAsync() {
        let url = this.APIURL + this.Controller + '/GetByBHYTToAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetByCCCDToAsync() {
        let url = this.APIURL + this.Controller + '/GetByCCCDToAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetByDienThoaiToAsync() {
        let url = this.APIURL + this.Controller + '/GetByDienThoaiToAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

