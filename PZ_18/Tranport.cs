using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_18
{
    internal class Tranport
    {
        public enum TransportType { Trolleybus, Bus, electricTrain }

        public class PublicTransport
        {
            private static int totalTransportCount = 0;

            public string StateNumber { get; }
            public string Driver { get; }
            public TransportType Type { get; }
            public TimeSpan DepartureTime { get; }
            public TimeSpan EndWorkTime { get; }

            public PublicTransport(string StateNumber, string Driver, TransportType type, TimeSpan departureTime, TimeSpan EndWorkTime)
            {
                if (!CheckStateNumber(StateNumber))
                {
                    Console.WriteLine("Неверный формат ГосНомера");
                }

                else
                {
                    StateNumber = StateNumber;
                    Driver = string.IsNullOrWhiteSpace(Driver) ? "не назначен" : Driver;
                    Type = type;
                    DepartureTime = departureTime;
                    EndWorkTime = EndWorkTime;
                    totalTransportCount++;
                }
            }

            public static int TotalTransportCount
            {
                get { return totalTransportCount; }
            }

            public bool IsOnRoute()
            {
                TimeSpan currentTime = DateTime.Now.TimeOfDay;
                if(currentTime>= DepartureTime && currentTime <= EndWorkTime)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void PrintInfo()
            {
                string status;
                if (IsOnRoute())
                    status = "в рейсе";
                else
                    status = "в парке";
                Console.WriteLine($"ГосНомер: {StateNumber}, Водитель: {Driver}, Тип: {Type}, Состояние: {status}");
            }

            public static void PrintTotalTransportCount()
            {
                Console.WriteLine($"Общее количество транспорта: {TotalTransportCount}");
            }

            private bool CheckStateNumber(string StateNumber)
            {
                if (StateNumber.Length != 9)
                {
                    return false;
                }

                for (int i = 0; i < 2; i++)
                {
                    if (!char.IsLetter(StateNumber[i]))
                    {
                        return false;
                    }
                }

                for (int i = 3; i < 6; i++)
                {
                    if (!char.IsDigit(StateNumber[i]))
                    {
                        return false;
                    }
                }

                for (int i = 7; i < 8; i++)
                {
                    if (!char.IsLetter(StateNumber[i]))
                    {
                        return false;
                    }
                }

                return true;
            }
        }
    }
}
