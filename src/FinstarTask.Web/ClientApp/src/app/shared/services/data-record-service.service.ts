import { Injectable } from '@angular/core';
import { HttpClient } from "@angular/common/http";
import { Observable } from "rxjs";
import { map } from "rxjs/operators";

import { DataRecord } from "../interfaces/DataRecord";

@Injectable({
	providedIn: 'root'
})
export class DataRecordService {
  endPoint = "/";

	constructor(private http: HttpClient) { }

	getAll(): Observable<DataRecord[]> {
		return this.http.get<DataRecord[]>(`${this.endPoint}api/DataRecords`)
      .pipe(
      	map((response: DataRecord[])=> {
					return response;
        })
      );
	}

	create(dataRecords: DataRecord[]) {
		return this.http.post(`${this.endPoint}api/DataRecords`, {'DataRecords': dataRecords});
	}
}
