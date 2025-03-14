import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { NS_KHENTHUONGKYLUAT } from './NS_KHENTHUONGKYLUAT.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class NS_KHENTHUONGKYLUATService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'ID', 'MaNhanVien', 'KTKL', 'NgayKTKL', 'NoiDungKTKL', 'LoaiKTKL', 'QuyetdinhKTKL'];

    List: NS_KHENTHUONGKYLUAT[] | undefined;
    ListFilter: NS_KHENTHUONGKYLUAT[] | undefined;
    FormData!: NS_KHENTHUONGKYLUAT;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "NS_KHENTHUONGKYLUAT";
    }
}

