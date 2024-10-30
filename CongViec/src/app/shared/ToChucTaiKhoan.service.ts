import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ToChucTaiKhoan } from 'src/app/shared/ToChucTaiKhoan.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ToChucTaiKhoanService extends BaseService {

    DisplayColumns001: string[] = ['STT', 'Name', 'Display', 'Description', 'Save'];
    
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ToChucTaiKhoan";
    }
}

