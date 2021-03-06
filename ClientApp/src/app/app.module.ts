import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ModelModule } from "./models/model.module";
import { FormsModule } from '@angular/forms';
import { StoreModule } from "./store/store.module";
import { ExternalService } from './external.service';
import { ErrorHandlerService } from './errorHandler.service';
import { HTTP_INTERCEPTORS } from '@angular/common/http';

@NgModule({
    declarations: [AppComponent],
    imports: [BrowserModule, AppRoutingModule, ModelModule,FormsModule, StoreModule],
    providers: [ExternalService, ErrorHandlerService,
        {provide: HTTP_INTERCEPTORS,
            useExisting: ErrorHandlerService, multi: true}],
    bootstrap: [AppComponent]
})
export class AppModule {
    constructor (external: ExternalService){}
 }
