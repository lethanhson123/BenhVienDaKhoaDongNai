import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Report } from './Report.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ReportService extends BaseService{
    
    DisplayColumns0001: string[] = ['STT', 'TinhThanhName', 'QuanHuyenName', 'XaPhuongName', 'ThongKe001', 'ThongKe002', 'ThongKe003', 'ThongKe004', 'ThongKe005', 'ThongKe006', 'ThongKe007', 'ThongKe008', 'ThongKe009', 'ThongKe010', 'ThongKe011', 'ThongKe012', 'ThongKe013', 'ThongKe014', 'ThongKe015'];
   
    List: Report[] | undefined;
    ListFilter: Report[] | undefined;    
    FormData!: Report;

    
    
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Report";
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
}

