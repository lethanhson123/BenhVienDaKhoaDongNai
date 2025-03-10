﻿import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ThongKeChiTiet } from './ThongKeChiTiet.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ThongKeChiTietService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'ParentID', 'ParentName', 'CreatedDate', 'CreatedMembershipID', 'LastUpdatedDate', 'LastUpdatedMembershipID', 'RowVersion', 'SortOrder', 'Active', 'TypeName', 'Name', 'Code', 'Note', 'Display', 'FileName', 'Description', 'HTMLContent', 'DanhMucNgonNguID', 'DanhMucUngDungID', 'DanhMucNgonNguName', 'DanhMucUngDungName', 'Name001', 'Name002', 'Name003', 'Name004', 'Name005', 'Name006', 'Name007', 'Name008', 'Name009', 'Name010', 'Name011', 'Name012', 'Year', 'Month', 'Day', 'Hour', 'ThongKe001', 'ThongKe002', 'ThongKe003', 'ThongKe004', 'ThongKe005', 'ThongKe006', 'ThongKe007', 'ThongKe008', 'ThongKe009', 'ThongKe010', 'ThongKe011', 'ThongKe012', 'ThongKe013', 'ThongKe014', 'ThongKe015', 'ThongKe016', 'ThongKe017', 'ThongKe018', 'ThongKe019', 'ThongKe020', 'ThongKe021', 'ThongKe022', 'ThongKe023', 'ThongKe024', 'ThongKe025', 'ThongKe026', 'ThongKe027', 'ThongKe028', 'ThongKe029', 'ThongKe030', 'ThongKe031'];
    DisplayColumns002: string[] = ['Save', 'STT', 'ID', 'Year', 'Month', 'Day', 'Hour', 'Name001', 'Name002', 'Name003', 'Name004', 'Name005', 'Name006', 'Name007', 'Name008', 'Name009', 'Name010', 'Name011', 'Name012', 'ThongKe001', 'ThongKe002', 'ThongKe003', 'ThongKe004', 'ThongKe005', 'ThongKe006', 'ThongKe007', 'ThongKe008', 'ThongKe009', 'ThongKe010', 'ThongKe011', 'ThongKe012', 'ThongKe013', 'ThongKe014', 'ThongKe015', 'ThongKe016', 'ThongKe017', 'ThongKe018', 'ThongKe019', 'ThongKe020', 'ThongKe021', 'ThongKe022', 'ThongKe023', 'ThongKe024', 'ThongKe025', 'ThongKe026', 'ThongKe027', 'ThongKe028', 'ThongKe029', 'ThongKe030', 'ThongKe031'];

    List: ThongKeChiTiet[] | undefined;
    ListFilter: ThongKeChiTiet[] | undefined;
    FormData!: ThongKeChiTiet;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ThongKeChiTiet";
    }
}

