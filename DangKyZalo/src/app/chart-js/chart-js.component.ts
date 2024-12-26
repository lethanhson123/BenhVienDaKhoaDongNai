import { Component, OnInit } from '@angular/core';
import { ChartOptions, ChartType, ChartDataSets, Chart, ChartConfiguration, ChartData } from 'chart.js';
import { Color, Label, SingleDataSet, monkeyPatchChartJsLegend, monkeyPatchChartJsTooltip } from 'ng2-charts';

@Component({
  selector: 'app-chart-js',
  templateUrl: './chart-js.component.html',
  styleUrls: ['./chart-js.component.css']
})
export class ChartJSComponent implements OnInit {

  constructor() {
    this.image.src = '/image/logo001.png'    
  }

  ngOnInit(): void {
  }
  public image = new Image();


  public Report0001_Option: ChartOptions = {
    responsive: true,
    legend: {
      display: true,
      position: 'bottom'
    },
    plugins: {
    },    
    tooltips: {
      callbacks: {
        label: function (tooltipItem, data) {
          var label = data.labels[tooltipItem.index];
          var value = data.datasets[tooltipItem.datasetIndex].data[tooltipItem.index];
          return label + '';
        }
      }
    }
  };
  public Report0001_Color: Color[] = [];
  public Report0001_Label: Label[] = ['Red', 'Blue', 'Yellow'];
  public Report0001_Type: ChartType = 'bar';
  public Report0001_Legend = true;
  public Report0001_Plugin = {
    beforeDraw: (chart, args, options) => {
      const ctx = chart.ctx;
      ctx.save();
      ctx.globalCompositeOperation = 'destination-over';
      ctx.fillStyle = options.color || '#ffffff';
      ctx.fillRect(0, 0, chart.width, chart.height);
      ctx.restore();

      if (this.image.complete) {
        const top = chart.chartArea.top;        
        const left = chart.chartArea.left;        
        const width = chart.width;        
        const height = chart.height;   
        const x = 0;
        const y = 0;      
        ctx.drawImage(this.image, x, y);
      } else {
        this.image.onload = () => chart.draw();
      };
    }
  };

  public Report0001_Data: ChartDataSets[] = [{
    label: 'My First Dataset',
    data: [90, 59, 80, 81, 56, 55, 40],
    backgroundColor: [
      'rgba(255, 99, 132, 0.1)',
      'rgba(255, 159, 64, 0.1)',
      'rgba(255, 205, 86, 0.1)',
      'rgba(75, 192, 192, 0.1)',
      'rgba(54, 162, 235, 0.1)',
      'rgba(153, 102, 255, 0.1)',
      'rgba(201, 203, 207, 0.1)'
    ],
    borderColor: [
      'rgb(255, 99, 132)',
      'rgb(255, 159, 64)',
      'rgb(255, 205, 86)',
      'rgb(75, 192, 192)',
      'rgb(54, 162, 235)',
      'rgb(153, 102, 255)',
      'rgb(201, 203, 207)'
    ],
    borderWidth: 1
  }];

}
