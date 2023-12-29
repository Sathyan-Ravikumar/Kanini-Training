import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminmenuComponent } from './adminmenu.component';

describe('AdminmenuComponent', () => {
  let component: AdminmenuComponent;
  let fixture: ComponentFixture<AdminmenuComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [AdminmenuComponent]
    });
    fixture = TestBed.createComponent(AdminmenuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
