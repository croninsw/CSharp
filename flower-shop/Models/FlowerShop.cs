using System;
using System.Collections.Generic;

namespace FlowerShop
{
    public class FlowerShop
    {
        public string ShopName { get; set; }
        public List<Rose> RoseCount = new List<Rose>();
        public List<Chrysanthemum> ChrysanthemumCount = new List<Chrysanthemum>();
        public List<Hydrangea> HydrangeaCount = new List<Hydrangea>();
        public List<Tulip> TulipCount = new List<Tulip>();

        public List<IMothersDay> MakeMothersDayArrangement()
        {
            List<IMothersDay> arrangement = new List<IMothersDay>(){
                new Tulip(),
                new Tulip(),
                new Tulip(),
                new Hydrangea(),
                new Hydrangea(),
            };

            return arrangement;
        }

    }
}