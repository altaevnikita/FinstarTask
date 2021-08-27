import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { of, Subject } from 'rxjs';
import { catchError, takeUntil, tap } from 'rxjs/operators';

import { DataRecord } from '../../interfaces/DataRecord';
import { DataRecordService } from '../../services/data-record-service.service';

@Component({
  selector: 'app-data-records-form',
  templateUrl: './data-records-form.component.html',
  styleUrls: ['./data-records-form.component.css']
})
export class DataRecordsFormComponent implements OnInit {
  dataRecords: DataRecord[] = [];
  error$: Subject<string> = new Subject<string>();

  constructor(
    private dataRecordService: DataRecordService
  ) {
  }

  ngOnInit(): void {
    this.addNewDataRecord();
  }

  @Output()
  onSubmit = new EventEmitter();

  addNewDataRecord() {
    this.dataRecords.push({
      code: 0,
      value: ''
    });
  }

  deleteDataRecord(index) {
    this.dataRecords.splice(index, 1);
  }

  submit() {
    this.dataRecordService.create(this.dataRecords).pipe(
      catchError(err => {
        var msg = 'Ошибка!\n';

        Object.keys(err.error.errors).forEach(prop => {
          msg += prop + ":\n";
          err.error.errors[prop].forEach(error => {
            msg += error + "\n";
          });
        });
        msg = msg.trim();

        this.error$.next(msg);
        return of(err);
      }),
      takeUntil(this.error$),
      tap(resp => {
        this.error$.next(null);
        this.dataRecords = [];
        this.addNewDataRecord();
        this.onSubmit.emit();
      })
    ).subscribe();
  }
}
