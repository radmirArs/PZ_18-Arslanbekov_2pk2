namespace PZ_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan currentTime = DateTime.Now.TimeOfDay;
            Transport.PublicTransport transport1 = new Transport.PublicTransport("AB 123 CD", "Гоша", Transport.TransportType.Bus, currentTime.Subtract(new TimeSpan(3, 0, 0)), currentTime.Add(new TimeSpan(4, 0, 0)));
            Transport.PublicTransport transport2 = new Transport.PublicTransport("CD 456 EF", "Паша", Transport.TransportType.Trolleybus, new TimeSpan(9, 0, 0), new TimeSpan(18, 0, 0));
            Transport.PublicTransport transport3 = new Transport.PublicTransport("EF 789 GH", "Рита", Transport.TransportType.ElectricTrain, new TimeSpan(10, 0, 0), new TimeSpan(19, 0, 0));
            Transport.PublicTransport transport4 = new Transport.PublicTransport("GH 012 IJ", "Рим", Transport.TransportType.Bus, new TimeSpan(11, 0, 0), new TimeSpan(20, 0, 0));
            Transport.PublicTransport transport5 = new Transport.PublicTransport("IJ345KL", "Ислам", Transport.TransportType.Trolleybus, new TimeSpan(12, 0, 0), new TimeSpan(21, 0, 0));
            Transport.PublicTransport transport6 = new Transport.PublicTransport("KL 678 MN", "Артем", Transport.TransportType.ElectricTrain, new TimeSpan(13, 0, 0), new TimeSpan(22, 0, 0));
            Transport.PublicTransport transport7 = new Transport.PublicTransport("MN 901 OP", "Игорь", Transport.TransportType.Bus, new TimeSpan(14, 0, 0), new TimeSpan(23, 0, 0));
            Transport.PublicTransport transport8 = new Transport.PublicTransport("OP 234 QR", "Айнур", Transport.TransportType.Trolleybus, new TimeSpan(15, 0, 0), new TimeSpan(0, 0, 0));
            Transport.PublicTransport transport9 = new Transport.PublicTransport("QR567ST", "", Transport.TransportType.ElectricTrain, new TimeSpan(16, 0, 0), new TimeSpan(1, 0, 0));
            Transport.PublicTransport transport10 = new Transport.PublicTransport("ST 890 UV", "Арман", Transport.TransportType.Bus, new TimeSpan(17, 0, 0), new TimeSpan(2, 0, 0));
            
            // Вызов методов класса для демонстрации логики работы
            transport1.PrintInfo();
            transport2.PrintInfo();
            transport3.PrintInfo();
            transport4.PrintInfo();
            transport5.PrintInfo();
            transport6.PrintInfo();
            transport7.PrintInfo();
            transport8.PrintInfo();
            transport9.PrintInfo();
            transport10.PrintInfo();
            
            Transport.PublicTransport.PrintTotalTransportCount();
        }
    }
}
