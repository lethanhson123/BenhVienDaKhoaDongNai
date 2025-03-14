import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { KhamSucKhoe } from 'src/app/shared/KhamSucKhoe.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class KhamSucKhoeService extends BaseService {
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'ParentID', 'ParentName', 'CreatedDate', 'CreatedMembershipID', 'LastUpdatedDate', 'LastUpdatedMembershipID', 'RowVersion', 'SortOrder', 'Active', 'TypeName', 'Name', 'Code', 'Note', 'Display', 'FileName', 'Description', 'HTMLContent', 'DanhMucNgonNguID', 'DanhMucUngDungID', 'DanhMucNgonNguName', 'DanhMucUngDungName', 'NgayBatDau', 'NgayKetThuc'];

    DisplayColumns002: string[] = ['STT', 'ID', 'NgayBatDau', 'NgayKetThuc', 'Name', 'Description', 'Note', 'Save'];

    List: KhamSucKhoe[] | undefined;
    ListFilter: KhamSucKhoe[] | undefined;
    FormData!: KhamSucKhoe;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "KhamSucKhoe";
    }
}

