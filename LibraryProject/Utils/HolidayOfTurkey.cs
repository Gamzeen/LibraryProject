namespace LibraryProject.Utils;

public class HolidayOfTurkey
{
    List<DateTime> holidaDateTimes= new List<DateTime>
    {
        new DateTime(DateTime.Now.Year, 1, 1),  // Yılbaşı
        new DateTime(DateTime.Now.Year, 4, 23), // Ulusal Egemenlik ve Çocuk Bayramı
        new DateTime(DateTime.Now.Year, 5, 1),  // Emek ve Dayanışma Günü
        new DateTime(DateTime.Now.Year, 5, 19), // Atatürk'ü Anma, Gençlik ve Spor Bayramı
        new DateTime(DateTime.Now.Year, 7, 20), // Kurban Bayramı (Kurban Bayramı, tarihine göre değişebilir)
        new DateTime(DateTime.Now.Year, 8, 30), // Zafer Bayramı
        new DateTime(DateTime.Now.Year, 10, 29) // Cumhuriyet Bayramı
    };
}