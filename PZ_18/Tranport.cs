using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_18
{
    internal class Transport
    {
        public enum TransportType { Trolleybus, Bus, ElectricTrain }

        public class PublicTransport
        {
            private static int totalTransportCount = 0;

            public string StateNumber { get; set; }
            public string Driver { get; set; }
            public TransportType Type { get; set; }
            public TimeSpan DepartureTime { get; set; }
            public TimeSpan EndWorkTime { get; set; }

            public PublicTransport(string stateNumber, string driver, TransportType type, TimeSpan departureTime, TimeSpan endWorkTime)
            {
                if (!CheckStateNumber(stateNumber))
                {
                    StateNumber = "Неверный формат ГосНомера";
                }
                else
                {
                    StateNumber = stateNumber;
                   
                }
                Driver = string.IsNullOrWhiteSpace(driver) ? "не назначен" : driver;
                Type = type;
                DepartureTime = departureTime;
                EndWorkTime = endWorkTime;
  
                totalTransportCount++;
            }

            public static int GetTotalTransportCount()
            {
                return totalTransportCount;
            }

            public bool IsOnRoute()
            {
                TimeSpan currentTime = DateTime.Now.TimeOfDay;
                if (currentTime >= DepartureTime && currentTime <= EndWorkTime)
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
                Console.WriteLine($"Общее количество транспорта: {totalTransportCount}");
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
