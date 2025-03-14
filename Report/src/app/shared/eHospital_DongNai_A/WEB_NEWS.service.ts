import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { WEB_NEWS } from './WEB_NEWS.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class WEB_NEWSService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'News_ID', 'Title', 'TitleE', 'Image', 'Summarize', 'Body', 'BodyE', 'Source', 'SourceE', 'Hotnews', 'PublishDate', 'Show', 'ModifiedOn', 'ModifiedBy', 'Category_ID', 'WorkFlow_ID', 'State_ID', 'ImageSave', 'VerHor', 'Enable'];

    List: WEB_NEWS[] | undefined;
    ListFilter: WEB_NEWS[] | undefined;
    FormData!: WEB_NEWS;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "WEB_NEWS";
    }
}

