import { Component } from '@angular/core';
import { Observable } from 'rxjs';

import { DataRecord } from '../shared/interfaces/DataRecord';
import { DataRecordService } from '../shared/services/data-record-service.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent  {
  dataRecords$: Observable<DataRecord[]>
  // dataRecords: DataRecord[] = []

  constructor(
    private dataRecordService: DataRecordService
  ) {
    this.dataRecords$ = this.dataRecordService.getAll();
    // this.dataRecords$.subscribe(dataRecords => {
      // this.dataRecords = dataRecords;
    // });
  }

  refresh() {
    this.dataRecords$ = this.dataRecordService.getAll();
    // this.dataRecords$.subscribe(dataRecords => {
    //   this.dataRecords = dataRecords;
    // });
  }
}
