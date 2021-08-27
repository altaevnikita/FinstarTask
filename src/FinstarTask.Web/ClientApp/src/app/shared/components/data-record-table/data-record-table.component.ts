import { AfterViewInit, Component, OnInit, ViewChild, Input, OnChanges } from '@angular/core';
import { MatPaginator } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { MatTableDataSource } from '@angular/material/table';

import { DataRecordService } from "../../services/data-record-service.service";
import { DataRecord } from "../../interfaces/DataRecord";

@Component({
  selector: 'app-data-record-table',
  templateUrl: './data-record-table.component.html',
  styleUrls: ['./data-record-table.component.css']
})
export class DataRecordTableComponent implements AfterViewInit, OnChanges {
  displayedColumns: string[] = ['code', 'value'];

  dataSource: MatTableDataSource<DataRecord>;

  @Input()
  dataRecords: DataRecord[] = []

  @ViewChild(MatPaginator) paginator: MatPaginator;
  @ViewChild(MatSort) sort: MatSort;

  ngOnChanges(changes) {
    if (changes.dataRecords) {
      this.dataSource = new MatTableDataSource(changes.dataRecords.currentValue);
    }
  }

  ngAfterViewInit() {
    this.dataSource.paginator = this.paginator;
    this.dataSource.sort = this.sort;
  }

  constructor(
    private dataRecordService: DataRecordService
  ) {
  }
}
