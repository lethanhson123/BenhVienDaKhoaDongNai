import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { c } from './c.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class cService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'KeyType', 'KeyYear', 'KeyMonth', 'KeyDay', 'Segment_1', 'Segment_2', 'Segment_3', 'KeyValue'];

    List: c[] | undefined;
    ListFilter: c[] | undefined;
    FormData!: c;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "c";
    }
}

