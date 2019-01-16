import { TestBed } from '@angular/core/testing';
import { BookService } from './book.service';
describe('BookService', function () {
    beforeEach(function () { return TestBed.configureTestingModule({}); });
    it('should be created', function () {
        var service = TestBed.get(BookService);
        expect(service).toBeTruthy();
    });
});
//# sourceMappingURL=book.service.spec.js.map