// See https://aka.ms/new-console-template for more information

var input = System.IO.File.ReadAllLines("data.txt");
int total_area = 0;
int total_ribbon = 0;
foreach (var line in input)
{
    var values = Array.ConvertAll(line.Split("x"), s => int.Parse(s));
    int[] sides_area = new[] { values[0] * values[1], values[1] * values[2], values[0] * values[2] };
    int[] sides_perimeter = new[]
        { 2 * (values[0] + values[1]), 2 * (values[1] + values[2]), 2 * (values[0] + values[2]) };

    total_area += 2 * sides_area.Sum();
    total_area += sides_area.Min();
    
    total_ribbon += sides_perimeter.Min();
    total_ribbon += values[0] * values[1] * values[2];

}

Console.WriteLine("Part 1: {0}", total_area);
Console.WriteLine("Part 2: {0}", total_ribbon);
