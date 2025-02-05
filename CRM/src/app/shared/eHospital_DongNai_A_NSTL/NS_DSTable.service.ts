import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_DSTable } from './NS_DSTable.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_DSTableService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Ma', 'Vietnamese'];

    List: NS_DSTable[] | undefined;
    ListFilter: NS_DSTable[] | undefined;
    FormData!: NS_DSTable;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_DSTable";
    }
}

