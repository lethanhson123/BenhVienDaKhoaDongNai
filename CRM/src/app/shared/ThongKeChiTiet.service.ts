import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { MatTableDataSource } from '@angular/material/table';
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';
import { environment } from 'src/environments/environment';
import { ThongKeChiTiet } from './ThongKeChiTiet.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ThongKeChiTietService extends BaseService {
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'ParentID', 'ParentName', 'CreatedDate', 'CreatedMembershipID', 'LastUpdatedDate', 'LastUpdatedMembershipID', 'RowVersion', 'SortOrder', 'Active', 'TypeName', 'Name', 'Code', 'Note', 'Display', 'FileName', 'Description', 'HTMLContent', 'DanhMucNgonNguID', 'DanhMucUngDungID', 'DanhMucNgonNguName', 'DanhMucUngDungName', 'Name001', 'Name002', 'Name003', 'Name004', 'Name005', 'Name006', 'Name007', 'Name008', 'Name009', 'Name010', 'Name011', 'Name012', 'Year', 'Month', 'Day', 'Hour', 'ThongKe001', 'ThongKe002', 'ThongKe003', 'ThongKe004', 'ThongKe005', 'ThongKe006', 'ThongKe007', 'ThongKe008', 'ThongKe009', 'ThongKe010', 'ThongKe011', 'ThongKe012', 'ThongKe013', 'ThongKe014', 'ThongKe015', 'ThongKe016', 'ThongKe017', 'ThongKe018', 'ThongKe019', 'ThongKe020', 'ThongKe021', 'ThongKe022', 'ThongKe023', 'ThongKe024', 'ThongKe025', 'ThongKe026', 'ThongKe027', 'ThongKe028', 'ThongKe029', 'ThongKe030', 'ThongKe031', 'ThongKe032'];
    DisplayColumns002: string[] = ['Save', 'STT', 'ID', 'SortOrder', 'RowVersion', 'Year', 'Month', 'Day', 'Hour', 'Week', 'Name001', 'Name002', 'Name003', 'Name004', 'Name005', 'Name006', 'Name007', 'Name008', 'Name009', 'Name010', 'Name011', 'Name012', 'ThongKe000', 'ThongKe001', 'ThongKe002', 'ThongKe003', 'ThongKe004', 'ThongKe005', 'ThongKe006', 'ThongKe007', 'ThongKe008', 'ThongKe009', 'ThongKe010', 'ThongKe011', 'ThongKe012', 'ThongKe013', 'ThongKe014', 'ThongKe015', 'ThongKe016', 'ThongKe017', 'ThongKe018', 'ThongKe019', 'ThongKe020', 'ThongKe021', 'ThongKe022', 'ThongKe023', 'ThongKe024', 'ThongKe025', 'ThongKe026', 'ThongKe027', 'ThongKe028', 'ThongKe029', 'ThongKe030', 'ThongKe031'];
    DisplayColumns003: string[] = ['STT', 'Name004', 'ThongKe000', 'ThongKe008'];
    DisplayColumns004: string[] = ['STT', 'Name004', 'ThongKe000', 'ThongKe008', 'ThongKe001', 'ThongKe002', 'ThongKe003', 'ThongKe004', 'ThongKe005', 'ThongKe006', 'ThongKe007'];
    DisplayColumns005: string[] = ['STT', 'Name003', 'Name004', 'Name001', 'Name002', 'ThongKe001'];
    DisplayColumns006: string[] = ['STT', 'Name003', 'Name004', 'ThongKe001', 'ThongKe002'];

    DataSource07: MatTableDataSource<any>;
    DataSource700: MatTableDataSource<any>;

    List: ThongKeChiTiet[] | undefined;
    ListFilter: ThongKeChiTiet[] | undefined;
    FormData!: ThongKeChiTiet;

    List01: ThongKeChiTiet[] | undefined;
    List02: ThongKeChiTiet[] | undefined;
    List03: ThongKeChiTiet[] | undefined;
    List04: ThongKeChiTiet[] | undefined;
    List05: ThongKeChiTiet[] | undefined;
    List06: ThongKeChiTiet[] | undefined;
    List07: ThongKeChiTiet[] | undefined;
    List08: ThongKeChiTiet[] | undefined;
    List09: ThongKeChiTiet[] | undefined;
    List10: ThongKeChiTiet[] | undefined;
    List20: ThongKeChiTiet[] | undefined;
    List30: ThongKeChiTiet[] | undefined;
    List40: ThongKeChiTiet[] | undefined;
    List50: ThongKeChiTiet[] | undefined;
    List60: ThongKeChiTiet[] | undefined;
    List70: ThongKeChiTiet[] | undefined;
    List80: ThongKeChiTiet[] | undefined;
    List90: ThongKeChiTiet[] | undefined;
    List100: ThongKeChiTiet[] | undefined;
    List200: ThongKeChiTiet[] | undefined;
    List300: ThongKeChiTiet[] | undefined;
    List400: ThongKeChiTiet[] | undefined;
    List500: ThongKeChiTiet[] | undefined;
    List600: ThongKeChiTiet[] | undefined;
    List700: ThongKeChiTiet[] | undefined;
    List800: ThongKeChiTiet[] | undefined;
    List900: ThongKeChiTiet[] | undefined;
    List1000: ThongKeChiTiet[] | undefined;
    List2000: ThongKeChiTiet[] | undefined;
    List3000: ThongKeChiTiet[] | undefined;
    List4000: ThongKeChiTiet[] | undefined;
    List10000: ThongKeChiTiet[] | undefined;

    FormData001!: ThongKeChiTiet;
    FormData002!: ThongKeChiTiet;
    FormData003!: ThongKeChiTiet;
    FormData004!: ThongKeChiTiet;
    FormData005!: ThongKeChiTiet;
    FormData006!: ThongKeChiTiet;
    FormData1000!: ThongKeChiTiet;
    FormData2000!: ThongKeChiTiet;
    FormData3000!: ThongKeChiTiet;

    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ThongKeChiTiet";
        this.FormData001 = {
        };
        this.FormData002 = {
        };
        this.FormData003 = {
        };
        this.FormData004 = {
        };
        this.FormData005 = {
        };
        this.FormData006 = {
        };

        this.FormData1000 = {
        };
        this.FormData2000 = {
        };
        this.FormData3000 = {
        };
        this.List10 = [];
        this.List20 = [];
        this.List30 = [];
        this.List40 = [];
        this.List50 = [];
        this.List100 = [];
        this.List200 = [];
        this.List1000 = [];
        this.List2000 = [];
        this.List3000 = [];
        this.List4000 = [];
        this.List10000 = [];
    }
    ReportAToaThuoc_MinhToListAsync() {
        if (this.BaseParameter.SearchString) {
            this.BaseParameter.SearchString = this.BaseParameter.SearchString.trim();
        }
        let url = this.APIURL + this.Controller + '/ReportAToaThuoc_MinhToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    ReportAToaThuoc_MinhToExcelAsync() {
        if (this.BaseParameter.SearchString) {
            this.BaseParameter.SearchString = this.BaseParameter.SearchString.trim();
        }
        let url = this.APIURL + this.Controller + '/ReportAToaThuoc_MinhToExcelAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

