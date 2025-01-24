import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DuocTonKho_Booking } from './DuocTonKho_Booking.model';
import { BaseService } from './Base.service';
@Injectable({
    providedIn: 'root'
})
export class DuocTonKho_BookingService extends BaseService{
    DisplayColumns001: string[] = ['Save', 'STT', 'Booking_Id', 'KhoDuoc_Id', 'NguonHang_Id', 'Duoc_Id', 'SoLuong', 'NgayHieuLuc'];

    List: DuocTonKho_Booking[] | undefined;
    ListFilter: DuocTonKho_Booking[] | undefined;
    FormData!: DuocTonKho_Booking;
    constructor(public httpClient: HttpClient) {
        super(httpClient);
        this.Controller = "DuocTonKho_Booking";
    }
}

