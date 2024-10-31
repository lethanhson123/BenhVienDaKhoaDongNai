import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { ToChuc } from 'src/app/shared/ToChuc.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class ToChucService extends BaseService{

     DisplayColumns001: string[] = ['STT', 'Name', 'Display', 'SortOrder', 'Active', 'Save'];
    List: ToChuc[] | undefined;
    ListFilter: ToChuc[] | undefined;    
    FormData!: ToChuc;

    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "ToChuc";
    }
}

