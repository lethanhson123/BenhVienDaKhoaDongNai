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

    ListFull: DanhMucQuayDichVu[] | undefined;
    List01: DanhMucQuayDichVu[] | undefined;
    List02: DanhMucQuayDichVu[] | undefined;
    List03: DanhMucQuayDichVu[] | undefined;

    FormData!: DanhMucQuayDichVu;
    FormData01!: DanhMucQuayDichVu;
    FormData02!: DanhMucQuayDichVu;
    FormData03!: DanhMucQuayDichVu;
    FormData04!: DanhMucQuayDichVu;
    FormData05!: DanhMucQuayDichVu;
    FormData06!: DanhMucQuayDichVu;
    FormData07!: DanhMucQuayDichVu;
    FormData08!: DanhMucQuayDichVu;
    FormData09!: DanhMucQuayDichVu;
    FormData10!: DanhMucQuayDichVu;
    FormData11!: DanhMucQuayDichVu;
    FormData12!: DanhMucQuayDichVu;

    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DanhMucQuayDichVu";
        this.ListFull = [];
        this.List01 = [];
        this.List02 = [];        
        this.List03 = [];         
        this.FormData01 = {
            ID: environment.InitializationNumber,
        };
        this.FormData02 = {
            ID: environment.InitializationNumber,
        };
        this.FormData03 = {
            ID: environment.InitializationNumber,
        };
        this.FormData04 = {
            ID: environment.InitializationNumber,
        };
        this.FormData05 = {
            ID: environment.InitializationNumber,
        };
        this.FormData06 = {
            ID: environment.InitializationNumber,
        };       
        this.FormData07 = {
            ID: environment.InitializationNumber,
        };
        this.FormData08 = {
            ID: environment.InitializationNumber,
        };
        this.FormData09 = {
            ID: environment.InitializationNumber,
        };
        this.FormData10 = {
            ID: environment.InitializationNumber,
        };
        this.FormData11 = {
            ID: environment.InitializationNumber,
        };
        this.FormData12 = {
            ID: environment.InitializationNumber,
        };            
    }

    GetAllToListAsync() {
        let url = this.APIURL + this.Controller + '/GetAllToListAsync';
        const formUpload: FormData = new FormData();
        formUpload.append('data', JSON.stringify(this.BaseParameter));
        return this.httpClient.post(url, formUpload, { headers: this.Headers });
    }   
}

