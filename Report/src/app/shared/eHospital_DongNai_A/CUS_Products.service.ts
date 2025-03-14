import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { CUS_Products } from './CUS_Products.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class CUS_ProductsService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Code', 'Name', 'Unit', 'Quantity', 'Price', 'Total', 'Action', 'Fkey', 'Extra1', 'Extra2', 'Remark'];

    List: CUS_Products[] | undefined;
    ListFilter: CUS_Products[] | undefined;
    FormData!: CUS_Products;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "CUS_Products";
    }
}

