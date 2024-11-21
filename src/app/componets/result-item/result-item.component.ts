import { Component, Input } from '@angular/core';
import { TikModel } from '../../model/tik.model';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-result-item',
  standalone: true,
  imports: [DatePipe],
  templateUrl: './result-item.component.html',
  styleUrl: './result-item.component.scss'
})
export class ResultItemComponent {
@Input()
itemTik:TikModel = new TikModel();

}
