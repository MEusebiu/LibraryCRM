import * as tslib_1 from "tslib";
import { Component } from '@angular/core';
import { Router, NavigationEnd } from '@angular/router';
var AppComponent = /** @class */ (function () {
    function AppComponent(router) {
        var _this = this;
        this.router = router;
        this.router.events.subscribe(function (event) {
            if (event instanceof NavigationEnd) {
                _this.currentUrl = event.url;
            }
        });
    }
    AppComponent = tslib_1.__decorate([
        Component({
            selector: 'app-root',
            templateUrl: './app.component.html',
            styleUrls: ['./app.component.scss']
        }),
        tslib_1.__metadata("design:paramtypes", [Router])
    ], AppComponent);
    return AppComponent;
}());
export { AppComponent };
//# sourceMappingURL=app.component.js.map