import * as tslib_1 from "tslib";
import { Component } from '@angular/core';
import { BookService } from '../../services/book.service';
var BookComponent = /** @class */ (function () {
    function BookComponent(bookService) {
        this.bookService = bookService;
    }
    BookComponent.prototype.ngOnInit = function () {
        var _this = this;
        console.log("Books Console Log");
        this.bookService.getBooks().subscribe(function (val) { return console.log(val); });
        this.bookService.getBooks().subscribe(function (val) { return _this.books = val; });
    };
    BookComponent = tslib_1.__decorate([
        Component({
            selector: 'app-book',
            templateUrl: './book.component.html',
            styleUrls: ['./book.component.scss']
        }),
        tslib_1.__metadata("design:paramtypes", [BookService])
    ], BookComponent);
    return BookComponent;
}());
export { BookComponent };
//# sourceMappingURL=book.component.js.map