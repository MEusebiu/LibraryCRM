import * as tslib_1 from "tslib";
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
var AuthorService = /** @class */ (function () {
    function AuthorService(http) {
        this.http = http;
    }
    AuthorService.prototype.getAuthors = function () {
        return this.http.get('http://localhost:8080/api/author');
    };
    AuthorService = tslib_1.__decorate([
        Injectable({
            providedIn: 'root'
        }),
        tslib_1.__metadata("design:paramtypes", [HttpClient])
    ], AuthorService);
    return AuthorService;
}());
export { AuthorService };
//# sourceMappingURL=author.service.js.map