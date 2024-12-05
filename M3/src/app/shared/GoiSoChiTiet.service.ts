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
        
    List: GoiSoChiTiet[] | undefined;
    ListFilter: GoiSoChiTiet[] | undefined;
    FormData!: GoiSoChiTiet;

    ListFull: GoiSoChiTiet[] | undefined;
    List01: GoiSoChiTiet[] | undefined;
    List02: GoiSoChiTiet[] | undefined;    
    List03: GoiSoChiTiet[] | undefined;    
    List04: GoiSoChiTiet[] | undefined;    

    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "GoiSoChiTiet";
    }

    SaveAsync() {        
        let url = this.APIURL + this.Controller + '/SaveAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.FormData));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }

    GetByDanhMucDichVuID_NgayCapSoSoThuTuAsync() {
        let url = this.APIURL + this.Controller + '/GetByDanhMucDichVuID_NgayCapSoSoThuTuAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetNgayCapSoSoThuTuStringToAsync() {
        let url = this.APIURL + this.Controller + '/GetNgayCapSoSoThuTuStringToAsync';
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
    GetGoiSoChiTietDangKy02_001ToListAsync() {
        let url = this.APIURL + this.Controller + '/GetGoiSoChiTietDangKy02_001ToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }
    GetGoiSoChiTietDangKy02_002ToListAsync() {
        let url = this.APIURL + this.Controller + '/GetGoiSoChiTietDangKy02_002ToListAsync';
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
    GetGoiSoChiTietDangKy04ToListAsync() {
        let url = this.APIURL + this.Controller + '/GetGoiSoChiTietDangKy04ToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }  
    GetGoiSoChiTietDangKy04_001ToListAsync() {
        let url = this.APIURL + this.Controller + '/GetGoiSoChiTietDangKy04_001ToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }  
    GetGoiSoChiTietDangKy05ToListAsync() {
        let url = this.APIURL + this.Controller + '/GetGoiSoChiTietDangKy05ToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }  
}

