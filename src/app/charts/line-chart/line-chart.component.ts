import { Component, OnInit } from '@angular/core';
import { LINE_CHART_COLORS } from '../../shared/chart.color';

const LINE_CHART_SOME_DATA: any[] = [
  { data: [33, 59, 80, 81, 56, 55, 40], label: 'Emotions Analysis' },
  { data: [18, 22, 40, 19, 86, 27, 90], label: 'Image Recognition' },
  { data: [68, 48, 15, 52, 23, 5, 30], label: 'Cutomers Predictions' }
];
const LINE_CHART_LABELS: string[] = ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul'];
@Component({
  selector: 'app-line-chart',
  templateUrl: './line-chart.component.html',
  styleUrls: ['./line-chart.component.css']
})
export class LineChartComponent implements OnInit {

  constructor() { }
  lineChartData = LINE_CHART_SOME_DATA;
  lineChartLabels = LINE_CHART_LABELS;
  lineChartOptions: any = {
    responsive: true
  };
  lineChartLegend: true;
  lineChartColors = LINE_CHART_COLORS
  lineChartType = 'line';
  
  ngOnInit(): void {
  }

}
