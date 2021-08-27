import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DataRecordsFormComponent } from './data-records-form.component';

describe('DataRecordsFormComponent', () => {
  let component: DataRecordsFormComponent;
  let fixture: ComponentFixture<DataRecordsFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DataRecordsFormComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DataRecordsFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
