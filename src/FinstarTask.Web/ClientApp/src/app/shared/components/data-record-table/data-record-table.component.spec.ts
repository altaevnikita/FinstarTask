import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DataRecordTableComponent } from './data-record-table.component';

describe('DataRecordTableComponent', () => {
  let component: DataRecordTableComponent;
  let fixture: ComponentFixture<DataRecordTableComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DataRecordTableComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DataRecordTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
