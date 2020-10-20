import { Component, OnInit } from '@angular/core';
import { ChartOptions, ChartType } from 'chart.js';



const SALES_DATA: any[] = [
  { data: [65, 59, 80, 81, 56, 55, 40], label: 'Sales Q2' },
  { data: [28, 48, 40, 19, 86, 27, 90], label: 'Sales Q3' }
];

const SALES_LABELS: string[] = ['W1', 'W2', 'W3', 'W4', 'W5', 'W6', 'W7'];
@Component({
  selector: 'app-bar-chart',
  templateUrl: './bar-chart.component.html',
  styleUrls: ['./bar-chart.component.css']
})
export class BarChartComponent implements OnInit {

  constructor() { }
  public barChartData: any[] = SALES_DATA; 
  public barChartLabels: string[] = SALES_LABELS;
  public barChartType: ChartType = 'bar';
  public barChartLegend = true;
  public barChartOptions: ChartOptions = {
    responsive: true,
    // scaleShowVerticalLines: false
  };

  ngOnInit(): void {
  }

}
