using BlazorChartJsDemo.Models;

namespace BlazorChartJsDemo.Components.Pages;

public partial class Home
{
    private static ChartModel CreateChartModel(IEnumerable<int> values)
    {
        int[] valueArray = values.ToArray();

        return new ChartModel
        {
            Type = "line",
            Data = new Data
            {
                Datasets =
                [
                    new Dataset
                    {
                        Data = valueArray,
                        Label = "Value"
                    }
                ],
                Labels = Enumerable.Range(1, valueArray.Length).Select(x => $"Value {x}").ToArray()
            }
        };
    }
}
