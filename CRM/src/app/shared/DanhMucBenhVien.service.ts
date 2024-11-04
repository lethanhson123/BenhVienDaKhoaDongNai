import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DanhMucBenhVien } from 'src/app/shared/DanhMucBenhVien.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DanhMucBenhVienService extends BaseService{

    DisplayColumns001: string[] = ['STT', 'ID', 'Name', 'DienThoai', 'DienThoai001', 'Website', 'Website001', 'DiaChi', 'DiaChi001', 'SortOrder', 'Active', 'Save'];

    List: DanhMucBenhVien[] | undefined;
    ListFilter: DanhMucBenhVien[] | undefined;
    FormData!: DanhMucBenhVien;

    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DanhMucBenhVien";
    }
}

