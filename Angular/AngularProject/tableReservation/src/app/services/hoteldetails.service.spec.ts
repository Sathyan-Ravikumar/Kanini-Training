import { TestBed } from '@angular/core/testing';

import { HoteldetailsService } from './hoteldetails.service';

describe('HoteldetailsService', () => {
  let service: HoteldetailsService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(HoteldetailsService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
