import { Base } from "./Base.model";
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';

export class BaseParameter extends Base{   
    SearchString?: string;
    BatDau?: Date;
    KetThuc?: Date;
    Year?: number;
    Month?: number;
    Day?: number;
    PhongBanID?: number;    
}
