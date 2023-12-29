import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CustvalidComponent } from './custvalid.component';

describe('CustvalidComponent', () => {
  let component: CustvalidComponent;
  let fixture: ComponentFixture<CustvalidComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [CustvalidComponent]
    });
    fixture = TestBed.createComponent(CustvalidComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
