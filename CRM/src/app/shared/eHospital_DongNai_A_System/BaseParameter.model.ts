import { Base } from "./Base.model";
import { MatSort } from '@angular/material/sort';
import { MatPaginator } from '@angular/material/paginator';

export class BaseParameter extends Base{      
    SearchString?: string;    
    Page?: number;
    PageSize?: number;     
    Menu_Level?: number;     
    Parent_Id?: number;     
    Group_Id?: number;     
    Menu_Id?: number;     
    User_Id?: number;     
}
