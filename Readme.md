<!-- default file list -->
*Files to look at*:

* [Window1.xaml](./CS/Window1.xaml) (VB: [Window1.xaml](./VB/Window1.xaml))
<!-- default file list end -->
# How to create a 2D Pie (Donut) chart


<p>The following example demonstrates how to create a 2D Pie chart. </p><p>For this, it's necessary to create a <a href="http://documentation.devexpress.com/#WPF/clsDevExpressXpfChartsChartControltopic"><u>ChartControl</u></a>, choose a <a href="http://documentation.devexpress.com/#WPF/clsDevExpressXpfChartsSimpleDiagram2Dtopic"><u>SimpleDiagram2D</u></a> object as its diagram and put <a href="http://documentation.devexpress.com/#WPF/clsDevExpressXpfChartsPieSeries2Dtopic"><u>PieSeries2D</u></a><strong> </strong>into its <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfChartsDiagram_Seriestopic"><u>Series</u></a><strong> </strong>collection. Each point of a pie series should contain an argument and value, and their data type is automatically determined by the chart. </p><p>Pie appearance is defined by its <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfChartsPieSeries2D_Modeltopic"><u>Model</u></a><strong> </strong>property and in this sample it's set to the built-in <a href="http://documentation.devexpress.com/#WPF/clsDevExpressXpfChartsGlarePie2DModeltopic"><u>GlarePie2DModel</u></a><strong> </strong>model. To specify the appearance and format of data point labels, adjust settings of the <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfChartsSeries_PointOptionstopic"><u>PointOptions</u></a><strong> </strong>object. In addition, it's possible to provide a custom appearance for legend items via the <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfChartsSeries_LegendPointOptionstopic"><u>LegendPointOptions</u></a> property.</p><p>Note that in this sample the label's <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfChartsPointOptions_Patterntopic"><u>Pattern</u></a> is set to "{}{A}: {V}", which allows showing a point's argument and value separated by a colon. The available placeholders are detailed below.<br />
<strong>{A}</strong>     Use it to display a series point's arguments.</p><p><strong>{V}</strong>     Use it to display a series point's values.</p><p><strong>{S}</strong>     Use it to display the series name.</p><br />



<h3>Description</h3>

<p>For this, it is necessary to assign the <strong>ChartControl.Diagram</strong> property to <strong>XYDiagram2D</strong>, and then add two <strong>PieSeries2D</strong> with points to the diagram&#39;s <strong>Series</strong> collection.</p><p>Also, this example shows how to add a legend (showing series names) to a chart.</p>

<br/>


