import * as tslib_1 from "tslib";
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { AlertModule } from 'ngx-bootstrap';
//My components
import { BookComponent } from './components/book/book.component';
import { AuthorComponent } from './components/author/author.component';
import { HomeComponent } from './components/home/home.component';
//My services
import { AuthorService } from './services/author.service';
import { BookService } from './services/book.service';
var AppModule = /** @class */ (function () {
    function AppModule() {
    }
    AppModule = tslib_1.__decorate([
        NgModule({
            declarations: [
                AppComponent,
                BookComponent,
                AuthorComponent,
                HomeComponent
            ],
            imports: [
                BrowserModule,
                AppRoutingModule,
                FormsModule,
                HttpClientModule,
                AlertModule.forRoot()
            ],
            providers: [BookService, AuthorService],
            bootstrap: [AppComponent]
        })
    ], AppModule);
    return AppModule;
}());
export { AppModule };
//# sourceMappingURL=app.module.js.map