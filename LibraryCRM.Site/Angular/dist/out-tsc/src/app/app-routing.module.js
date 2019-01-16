import * as tslib_1 from "tslib";
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { BookComponent } from "./components/book/book.component";
import { AuthorComponent } from './components/author/author.component';
import { HomeComponent } from './components/home/home.component';
var routes = [
    { path: '', component: HomeComponent },
    { path: 'book', component: BookComponent },
    { path: 'author', component: AuthorComponent }
];
var AppRoutingModule = /** @class */ (function () {
    function AppRoutingModule() {
    }
    AppRoutingModule = tslib_1.__decorate([
        NgModule({
            imports: [RouterModule.forRoot(routes)],
            exports: [RouterModule]
        })
    ], AppRoutingModule);
    return AppRoutingModule;
}());
export { AppRoutingModule };
//# sourceMappingURL=app-routing.module.js.map