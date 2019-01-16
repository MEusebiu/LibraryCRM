import * as tslib_1 from "tslib";
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
var BookService = /** @class */ (function () {
    function BookService(http) {
        this.http = http;
    }
    BookService.prototype.getBooks = function () {
        return this.http.get('http://localhost:8080/api/book');
    };
    BookService = tslib_1.__decorate([
        Injectable({
            providedIn: 'root'
        }),
        tslib_1.__metadata("design:paramtypes", [HttpClient])
    ], BookService);
    return BookService;
}());
export { BookService };
//# sourceMappingURL=book.service.js.map