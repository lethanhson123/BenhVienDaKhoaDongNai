import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { WEB_NEWS_CATEGORIES } from './WEB_NEWS_CATEGORIES.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class WEB_NEWS_CATEGORIESService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Category_ID', 'Category_Name', 'Category_NameE', 'Index', 'Enable'];

    List: WEB_NEWS_CATEGORIES[] | undefined;
    ListFilter: WEB_NEWS_CATEGORIES[] | undefined;
    FormData!: WEB_NEWS_CATEGORIES;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "WEB_NEWS_CATEGORIES";
    }
}

