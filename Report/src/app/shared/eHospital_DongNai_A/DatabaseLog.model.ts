import { Base } from "./Base.model";

export class DatabaseLog extends Base{
DatabaseLogID?: number;
PostTime?: Date;
DatabaseUser?: string;
Event?: string;
Schema?: string;
Object?: string;
TSQL?: string;
XmlEvent?: string;

}


