import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminuiComponent } from './adminui.component';

describe('AdminuiComponent', () => {
  let component: AdminuiComponent;
  let fixture: ComponentFixture<AdminuiComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AdminuiComponent]
    });
    fixture = TestBed.createComponent(AdminuiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
