namespace LibraryProject.Utils;

public class HolidaysOfEngland
{
    List<DateTime> holidaDateTimes = new List<DateTime>
    {
        new DateTime(DateTime.Now.Year, 1, 1),   // Yılbaşı
        new DateTime(DateTime.Now.Year, 4, 2),   // Paskalya Pazartesi (Değişken bir tarih)
        new DateTime(DateTime.Now.Year, 12, 25), // Noel
        new DateTime(DateTime.Now.Year, 12, 26), // İkinci Noel (Boxing Day)
        // İhtiyaca göre diğer özel tatil tarihlerini burada ekleyebilirsiniz
    };
}