import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http'; 

//My components
import { HeaderComponent } from './components/header/header.component';
import { HomeComponent } from './components/home/home.component';
import { BookComponent } from './components/book/book.component';
import { AuthorComponent } from './components/author/author.component';
import { FooterComponent } from './components/footer/footer.component';

//My services
import { AuthorService } from './services/author.service';
import { BookService } from './services/book.service';
import { CrudmenuComponent } from './components/crudmenu/crudmenu.component';


@NgModule({
  declarations: [
    AppComponent,
    BookComponent,
    AuthorComponent,
    HomeComponent,
    HeaderComponent,
    FooterComponent,
    CrudmenuComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [BookService, AuthorService],
  bootstrap: [AppComponent]
})
export class AppModule { }
