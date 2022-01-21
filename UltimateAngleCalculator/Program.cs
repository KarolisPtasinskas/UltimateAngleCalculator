using UltimateAngleCalculator;

Console.WriteLine(UI.Greeting);
Console.WriteLine(UI.Help);

while (true)
{
    var hours = UserInputHandler.GetHours();
    var minutes = UserInputHandler.GetMinutes();

    var result = AngleCalculator.LesserAngleBetweenArrows(hours, minutes);

    Console.WriteLine($"\nLesser angle between arrows at {hours}h {minutes}m is {result}°");
    Console.WriteLine(UI.Help);
}
