using System;
using System.Collections.Generic;
using System.Text;

namespace InterFaceDemo
{
   public interface ITVprovider
    {
        int ChanelCount { get; set; }
    }

    public interface INETProvider
    {
        double InternetSpeed { get; set; }
    }

    public interface ITV_NETProvider: ITVprovider, INETProvider
    {
        double PriceForService { get; set; }
    }

    class PromotionService : ITV_NETProvider
    {
        public double PriceForService { get; set; }
        public int ChanelCount { get; set; }
        public double InternetSpeed { get; set; }
    }
}
