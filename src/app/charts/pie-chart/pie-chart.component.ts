import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-pie-chart',
  templateUrl: './pie-chart.component.html',
  styleUrls: ['./pie-chart.component.css']
})
export class PieChartComponent implements OnInit {

  constructor() { }

  pieChartData: number[] = [350, 450, 180];
  pieChartlabel: string[] = ['Logistics','Cost Of Goods Sold', 'Profit'];
  colors: any[] = [
    {
      backgroundColor: ['#26547c', '#ff6b6b', '#ffd166'],
      borderColor: '#111111'
    }
  ];
  pieChartType = 'doughnut';
  
  ngOnInit(): void {
  }

}
