import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Report } from './Report.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ReportService extends BaseService {

    DisplayColumns0001: string[] = ['STT', 'TinhThanhName', 'QuanHuyenName', 'XaPhuongName', 'ThongKe001', 'ThongKe002', 'ThongKe003', 'ThongKe004', 'ThongKe005', 'ThongKe006', 'ThongKe007', 'ThongKe008', 'ThongKe009', 'ThongKe010', 'ThongKe011', 'ThongKe012', 'ThongKe013', 'ThongKe014', 'ThongKe015'];

    List: Report[] | undefined;
    ListFilter: Report[] | undefined;
    FormData!: Report;

    ListTemporary: Report[] | undefined;
    FormTemporary!: Report;

    ListReportA: Report[] | undefined;
    ListReportDictionary: Report[] | undefined;

    List10: Report[] | undefined;
    List20: Report[] | undefined;
    List30: Report[] | undefined;
    List40: Report[] | undefined;
    List50: Report[] | undefined;    
    List100: Report[] | undefined;
    List200: Report[] | undefined;
    List1000: Report[] | undefined;
    List10000: Report[] | undefined;

    ListNSTL: Report[] | undefined;
    ListNSTLFilter: Report[] | undefined;

    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Report";

        this.List10 = [];
        this.List20 = [];
        this.List30 = [];
        this.List40 = [];
        this.List50 = [];
        this.List100 = [];
        this.List200 = [];
        this.List1000 = [];
        this.List10000 = [];
        this.ListNSTL = [];
        this.ListNSTLFilter = [];
    }

    ReportDictionary0001ToListAsync() {
        let url = this.APIURL + this.Controller + '/ReportDictionary0001ToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    ReportDictionary0002ToListAsync() {
        let url = this.APIURL + this.Controller + '/ReportDictionary0002ToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    ReportDictionary0003ToListAsync() {
        let url = this.APIURL + this.Controller + '/ReportDictionary0003ToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }

    ReportA0001ToListAsync() {
        if (this.BaseParameter.BatDau == null) {
            this.BaseParameter.BatDau = new Date();
        }
        this.BaseParameter.Year = this.BaseParameter.BatDau.getFullYear();
        this.BaseParameter.Month = this.BaseParameter.BatDau.getMonth() + 1;
        this.BaseParameter.Day = this.BaseParameter.BatDau.getDate();
        let url = this.APIURL + this.Controller + '/ReportA0001ToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    ReportNSTLA0001ToListAsync() {
        let url = this.APIURL + this.Controller + '/ReportNSTLA0001ToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    ReportNSTLA0002ToListAsync() {
        let url = this.APIURL + this.Controller + '/ReportNSTLA0002ToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
}

