namespace BlazorChartJsDemo.Models;

public class ChartModel
{
    public required string Type { get; init; }

    public required Data Data { get; init; }
}

public class Data
{
    public required string[] Labels { get; init; }

    public required Dataset[] Datasets { get; init; }
}

public class Dataset
{
    public required string Label { get; init; }

    public required int[] Data { get; init; }
}
