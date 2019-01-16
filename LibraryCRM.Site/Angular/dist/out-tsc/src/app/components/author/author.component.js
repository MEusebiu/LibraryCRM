import * as tslib_1 from "tslib";
import { Component } from '@angular/core';
import { AuthorService } from '../../services/author.service';
var AuthorComponent = /** @class */ (function () {
    function AuthorComponent(authorService) {
        this.authorService = authorService;
    }
    AuthorComponent.prototype.ngOnInit = function () {
        var _this = this;
        console.log("Authors Log");
        this.authorService.getAuthors().subscribe(function (val) { return console.log(val); });
        this.authorService.getAuthors().subscribe(function (val) { return _this.authors = val; });
    };
    AuthorComponent = tslib_1.__decorate([
        Component({
            selector: 'app-author',
            templateUrl: './author.component.html',
            styleUrls: ['./author.component.scss']
        }),
        tslib_1.__metadata("design:paramtypes", [AuthorService])
    ], AuthorComponent);
    return AuthorComponent;
}());
export { AuthorComponent };
//# sourceMappingURL=author.component.js.map