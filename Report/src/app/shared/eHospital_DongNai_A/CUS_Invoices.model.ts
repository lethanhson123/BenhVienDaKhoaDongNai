import { Base } from "./Base.model";

export class CUS_Invoices extends Base{
Fkey?: number;
Serial?: string;
Pattern?: string;
No?: string;
CusCode?: string;
CusName?: string;
CusAddress?: string;
CusPhone?: string;
CusTaxCode?: string;
CusBankNo?: string;
Buyer?: string;
PaymentMethod?: string;
Total?: string;
VATRate?: string;
VATAmount?: string;
Amount?: string;
AmountInWords?: string;
Extra?: string;
ArisingDate?: string;
CreatedDate?: Date;
IsPayed?: boolean;
IsAdjusted?: boolean;
IsReplaced?: boolean;
IsCanceled?: boolean;
Status?: number;
Error?: string;
TransID?: string;
FileID?: string;
BranchCode?: string;

}


