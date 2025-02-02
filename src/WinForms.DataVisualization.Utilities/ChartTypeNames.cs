﻿namespace System.Windows.Forms.DataVisualization.Charting
{

    /// <summary>
    /// ChartTypeName class contains constant strings defining
    /// names of all ChartTypes used in the Chart.
    /// </summary>
    internal static class ChartTypeNames
    {
        #region Chart type names

        internal const string Area = "Area";
        internal const string RangeBar = "RangeBar";
        internal const string Bar = "Bar";
        internal const string SplineArea = "SplineArea";
        internal const string BoxPlot = "BoxPlot";
        internal const string Bubble = "Bubble";
        internal const string Column = "Column";
        internal const string RangeColumn = "RangeColumn";
        internal const string Doughnut = "Doughnut";
        internal const string ErrorBar = "ErrorBar";
        internal const string FastLine = "FastLine";
        internal const string FastPoint = "FastPoint";
        internal const string Funnel = "Funnel";
        internal const string Pyramid = "Pyramid";
        internal const string Kagi = "Kagi";
        internal const string Spline = "Spline";
        internal const string Line = "Line";
        internal const string PointAndFigure = "PointAndFigure";
        internal const string Pie = "Pie";
        internal const string Point = "Point";
        internal const string Polar = "Polar";
        internal const string Radar = "Radar";
        internal const string SplineRange = "SplineRange";
        internal const string Range = "Range";
        internal const string Renko = "Renko";
        internal const string OneHundredPercentStackedArea = "100%StackedArea";
        internal const string StackedArea = "StackedArea";
        internal const string OneHundredPercentStackedBar = "100%StackedBar";
        internal const string StackedBar = "StackedBar";
        internal const string OneHundredPercentStackedColumn = "100%StackedColumn";
        internal const string StackedColumn = "StackedColumn";
        internal const string StepLine = "StepLine";
        internal const string Candlestick = "Candlestick";
        internal const string Stock = "Stock";
        internal const string ThreeLineBreak = "ThreeLineBreak";

        #endregion // Keyword Names

        /// <summary>
        /// Get chart type name by it's type
        /// </summary>
        /// <param name="type">Chart type.</param>
        /// <returns>Chart type name.</returns>
        static internal string GetChartTypeName(SeriesChartType type)
        {
            if (type == SeriesChartType.StackedArea100)
                return OneHundredPercentStackedArea;

            if (type == SeriesChartType.StackedBar100)
                return OneHundredPercentStackedBar;

            if (type == SeriesChartType.StackedColumn100)
                return OneHundredPercentStackedColumn;

            return Enum.GetName(typeof(SeriesChartType), type);
        }
    }
}