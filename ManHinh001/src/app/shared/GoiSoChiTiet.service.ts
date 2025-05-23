﻿import { Injectable } from '@angular/core';
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
    ListFullFilter: GoiSoChiTiet[] | undefined;
    List01: GoiSoChiTiet[] | undefined;
    List02: GoiSoChiTiet[] | undefined;    
    List03: GoiSoChiTiet[] | undefined;    
    List04: GoiSoChiTiet[] | undefined;    
    List11: GoiSoChiTiet[] | undefined;
    List12: GoiSoChiTiet[] | undefined;    
    List13: GoiSoChiTiet[] | undefined;    
    List14: GoiSoChiTiet[] | undefined;    
    List21: GoiSoChiTiet[] | undefined;
    List22: GoiSoChiTiet[] | undefined;    
    List23: GoiSoChiTiet[] | undefined;    
    List24: GoiSoChiTiet[] | undefined;    
    List31: GoiSoChiTiet[] | undefined;
    List32: GoiSoChiTiet[] | undefined;    
    List33: GoiSoChiTiet[] | undefined;    
    List34: GoiSoChiTiet[] | undefined;    
    List41: GoiSoChiTiet[] | undefined;
    List42: GoiSoChiTiet[] | undefined;    
    List43: GoiSoChiTiet[] | undefined;    
    List44: GoiSoChiTiet[] | undefined; 
    List51: GoiSoChiTiet[] | undefined;
    List52: GoiSoChiTiet[] | undefined;    
    List53: GoiSoChiTiet[] | undefined;    
    List54: GoiSoChiTiet[] | undefined; 
    List61: GoiSoChiTiet[] | undefined;
    List62: GoiSoChiTiet[] | undefined;    
    List63: GoiSoChiTiet[] | undefined;    
    List64: GoiSoChiTiet[] | undefined; 
    List71: GoiSoChiTiet[] | undefined;
    List72: GoiSoChiTiet[] | undefined;    
    List73: GoiSoChiTiet[] | undefined;    
    List74: GoiSoChiTiet[] | undefined; 
    List81: GoiSoChiTiet[] | undefined;
    List82: GoiSoChiTiet[] | undefined;    
    List83: GoiSoChiTiet[] | undefined;    
    List84: GoiSoChiTiet[] | undefined; 
    List91: GoiSoChiTiet[] | undefined;
    List92: GoiSoChiTiet[] | undefined;    
    List93: GoiSoChiTiet[] | undefined;    
    List94: GoiSoChiTiet[] | undefined; 
    List101: GoiSoChiTiet[] | undefined;
    List102: GoiSoChiTiet[] | undefined;    
    List103: GoiSoChiTiet[] | undefined;    
    List104: GoiSoChiTiet[] | undefined; 
    List111: GoiSoChiTiet[] | undefined;
    List112: GoiSoChiTiet[] | undefined;    
    List113: GoiSoChiTiet[] | undefined;    
    List114: GoiSoChiTiet[] | undefined; 
    FormData01!: GoiSoChiTiet;
    FormData02!: GoiSoChiTiet;
    FormData03!: GoiSoChiTiet;
    FormData04!: GoiSoChiTiet;
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
    UpdateByDanhMucDichVuID_NgayDangKySoThuTuTu_CodeAsync() {
        let url = this.APIURL + this.Controller + '/UpdateByDanhMucDichVuID_NgayDangKySoThuTuTu_CodeAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
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
    GetGoiSoChiTietTiepNhan04_001ToListAsync() {
        let url = this.APIURL + this.Controller + '/GetGoiSoChiTietTiepNhan04_001ToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }  
    GetGoiSoChiTietTiepNhan05ToListAsync() {
        let url = this.APIURL + this.Controller + '/GetGoiSoChiTietTiepNhan05ToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }  
    GetGoiSoChiTietTiepNhan06ToListAsync() {
        let url = this.APIURL + this.Controller + '/GetGoiSoChiTietTiepNhan06ToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }  
    GetGoiSoChiTietTiepNhan07ToListAsync() {
        let url = this.APIURL + this.Controller + '/GetGoiSoChiTietTiepNhan07ToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }  
    GetGoiSoChiTietTiepNhan08ToListAsync() {
        let url = this.APIURL + this.Controller + '/GetGoiSoChiTietTiepNhan08ToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }  
    GetGoiSoChiTietTiepNhan09ToListAsync() {
        let url = this.APIURL + this.Controller + '/GetGoiSoChiTietTiepNhan09ToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }  
}

