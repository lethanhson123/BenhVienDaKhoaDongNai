import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DanhMucQuanHuyen } from 'src/app/shared/DanhMucQuanHuyen.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DanhMucQuanHuyenService extends BaseService {
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'ParentID', 'ParentName', 'CreatedDate', 'CreatedMembershipID', 'LastUpdatedDate', 'LastUpdatedMembershipID', 'RowVersion', 'SortOrder', 'Active', 'TypeName', 'Name', 'Code', 'Note', 'Display', 'FileName', 'Description', 'HTMLContent', 'DanhMucNgonNguID', 'DanhMucUngDungID', 'DanhMucNgonNguName', 'DanhMucUngDungName', 'KinhDo', 'ViDo'];
    DisplayColumns002: string[] = ['STT', 'ID', 'ParentID', 'ParentName', 'Name', 'KinhDo', 'ViDo', 'Note', 'SortOrder', 'Active', 'Save'];
    DisplayColumns003: string[] = ['STT', 'ID', 'ParentID', 'Name', 'KinhDo', 'ViDo', 'Note', 'SortOrder', 'Active', 'Save'];
    DisplayColumns004: string[] = ['STT', 'ID', 'ParentID', 'Code', 'Name', 'KinhDo', 'ViDo', 'DanhMucUngDungID', 'SortOrder', 'Active', 'Save'];

    List: DanhMucQuanHuyen[] | undefined;
    ListFilter: DanhMucQuanHuyen[] | undefined;
    FormData!: DanhMucQuanHuyen;

    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DanhMucQuanHuyen";
    }
}

