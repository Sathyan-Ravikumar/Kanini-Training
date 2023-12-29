import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TemperaturechangeComponent } from './temperaturechange.component';

describe('TemperaturechangeComponent', () => {
  let component: TemperaturechangeComponent;
  let fixture: ComponentFixture<TemperaturechangeComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [TemperaturechangeComponent]
    });
    fixture = TestBed.createComponent(TemperaturechangeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
