
class Program
{
    
    static void Main()
    {
        int currentDay = 1;

        Day day = () =>
        {
            string[] daysOfWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
            string nextDay = daysOfWeek[currentDay];

            currentDay = (currentDay + 1) % 7;

            return nextDay;
        };

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(day());
        }
    }
}
delegate string Day();