namespace BlazingCountdown.Client;

public static class NumberExtensions
{
    public static string PadLeft(this int number) =>
        number.ToString().PadLeft(2, '0');
}
