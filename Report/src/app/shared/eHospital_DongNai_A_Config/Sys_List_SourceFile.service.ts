import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Sys_List_SourceFile } from './Sys_List_SourceFile.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class Sys_List_SourceFileService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'FileName', 'PathName', 'Size', 'ModifyDate'];

    List: Sys_List_SourceFile[] | undefined;
    ListFilter: Sys_List_SourceFile[] | undefined;
    FormData!: Sys_List_SourceFile;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "Sys_List_SourceFile";
    }
}

