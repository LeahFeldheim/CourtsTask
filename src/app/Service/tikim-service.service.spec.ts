import { TestBed } from '@angular/core/testing';

import { TikimServiceService } from './tikim-service.service';

describe('TikimServiceService', () => {
  let service: TikimServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TikimServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
