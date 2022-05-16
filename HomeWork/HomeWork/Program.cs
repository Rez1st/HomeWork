using System;
using HomeWork.WineHomeWork;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WineHomeWorkInit.ProgramInfo();
            var wineArray = WineHomeWorkInit.Init();

            var wineList = new WineStorage(wineArray);
            var resultByYear = wineList.GetByYear(new DateTime(2019, 1, 1));
            var resultByWineType = wineList.GetByWineType(WineType.Dry);
            var resultByWineColor = wineList.GetByWineColor(WineColor.Red);
        }
    }
}