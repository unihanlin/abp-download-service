import { NgModule } from '@angular/core';
import { NgFileInputDirectiveModule } from '@unihanlin/ng-file-input-directive';
import { SharedModule } from '../shared/shared.module';
import { HomeRoutingModule } from './home-routing.module';
import { HomeComponent } from './home.component';

@NgModule({
  declarations: [HomeComponent],
  imports: [SharedModule, HomeRoutingModule, NgFileInputDirectiveModule],
})
export class HomeModule {}
