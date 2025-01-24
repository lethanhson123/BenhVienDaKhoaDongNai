import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CanNang } from './CanNang.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CanNangService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'CanNang'];

    List: CanNang[] | undefined;
    ListFilter: CanNang[] | undefined;
    FormData!: CanNang;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CanNang";
    }
}

