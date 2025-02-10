import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DanhMucQuayDichVu } from 'src/app/shared/DanhMucQuayDichVu.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DanhMucQuayDichVuService extends BaseService {
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'ParentID', 'ParentName', 'CreatedDate', 'CreatedMembershipID', 'LastUpdatedDate', 'LastUpdatedMembershipID', 'RowVersion', 'SortOrder', 'Active', 'TypeName', 'Name', 'Code', 'Note', 'Display', 'FileName', 'Description', 'HTMLContent', 'DanhMucNgonNguID', 'DanhMucUngDungID', 'DanhMucNgonNguName', 'DanhMucUngDungName'];

    DisplayColumns02: string[] = ['STT', 'ID', 'ParentID', 'Name', 'Code', 'Note', 'SortOrder', 'Active', 'Save'];
    DisplayColumns03: string[] = ['STT', 'ID', 'ParentID', 'Name', 'Code', 'Note', 'SortOrder', 'IsTiepNhan', 'IsNhaThuoc', 'Active', 'Save'];
    DisplayColumns04: string[] = ['STT', 'ID', 'ParentID', 'Name', 'Code', 'Display', 'Note', 'SortOrder', 'IsTiepNhan', 'IsNhaThuoc', 'Active', 'Save'];
    DisplayColumns05: string[] = ['STT', 'ID', 'ParentID', 'DanhMucDichVuID', 'Name', 'Code', 'Display', 'SortOrder', 'IsTiepNhan', 'IsNhaThuoc', 'Active', 'Save'];
    DisplayColumns06: string[] = ['STT', 'ID', 'ParentID', 'DanhMucDichVuID', 'Name', 'Code', 'Display', 'Note', 'TypeName', 'SortOrder', 'IsTiepNhan', 'IsNhaThuoc', 'Active', 'Save'];
    DisplayColumns07: string[] = ['STT', 'ID', 'ParentID', 'DanhMucDichVuID', 'Name', 'Code', 'Display', 'Note', 'TypeName', 'SortOrder', 'IsTiepNhan', 'IsNhaThuoc', 'IsBannerShow', 'Active', 'Save'];
    DisplayColumns08: string[] = ['STT', 'ID', 'LastUpdatedMembershipID', 'LastUpdatedDate', 'ParentID', 'DanhMucDichVuID', 'Name', 'Code', 'Display', 'Note', 'TypeName', 'SortOrder', 'IsTiepNhan', 'IsNhaThuoc', 'IsBannerShow', 'Active', 'Save'];

    List: DanhMucQuayDichVu[] | undefined;
    ListFilter: DanhMucQuayDichVu[] | undefined;
    FormData!: DanhMucQuayDichVu;

    ListFull: DanhMucQuayDichVu[] | undefined;
    List01: DanhMucQuayDichVu[] | undefined;
    List02: DanhMucQuayDichVu[] | undefined;
    List03: DanhMucQuayDichVu[] | undefined;

    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DanhMucQuayDichVu";
        this.ListFull = [];
        this.List01 = [];
        this.List02 = [];        
        this.List03 = [];  
    }
    KhoiPhucAsync() {
        let url = this.APIURL + this.Controller + '/KhoiPhucAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

