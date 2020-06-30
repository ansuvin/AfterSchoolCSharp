using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_Class_AccessModifier
{
    class WaterHeater
    {
        private int temperature;
        
        public String SetTemperature(int temp)
        {
            if(temp>10|| 50 > temp)
            {
                temperature = temp;
                return $"온도가 {temp}도로 설정됨";
            }
            else
            {
                return $"에러: 온도가 {temp}도로 정상 범위를 벗어남";
            }
            
        }
        public int GetTemperature()
        {
            return temperature;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            WaterHeater heater = new WaterHeater();
            Console.WriteLine($"현재 온도는 {heater.GetTemperature()}도 입니다.");
            Console.WriteLine(heater.SetTemperature(20));
            Console.WriteLine(heater.SetTemperature(200));
            Console.WriteLine($"현재 온도는 {heater.GetTemperature()}도 입니다.");

            
        }
    }
}
