
            double priceChrysanthemum = 0.0;
            double priceRose = 0.0;
            double priceTulip = 0.0;
            double priceBouquet = 0.0;

            if (season == "Spring" || season == "Summer")
            {
                if(holidayOrNot == "N")
                {
                    priceChrysanthemum = 2.0;
                    priceRose = 4.10;
                    priceTulip = 2.50;
                }
                else
                {
                    priceChrysanthemum = 2.0 + 2.0 * 0.15;
                    priceRose = 4.10 + 4.10 * 0.15;
                    priceTulip = 2.50 + 2.50 * 0.15;
                }
            }
            else
            {
                if (holidayOrNot == "N")
                {
                    priceChrysanthemum = 3.75;
                    priceRose = 4.50;
                    priceTulip = 4.15;
                }
                else
                {
                    priceChrysanthemum = 3.75 + 3.75 * 0.15;
                    priceRose = 4.50 + 4.50 * 0.15;
                    priceTulip = 4.15 + 4.15 * 0.15;
                }
            }
            priceBouquet = bougthChrysanthemums * priceChrysanthemum + bougthRoses * priceRose + bougthTulips * priceTulip;
            if(season == "Spring" && bougthTulips > 7)
            {
                priceBouquet = priceBouquet -  priceBouquet * 0.05;
            }
            if(season == "Winter" && bougthRoses >= 10)
            {
                priceBouquet = priceBouquet - priceBouquet * 0.10;
            }
            if(bougthRoses + bougthTulips + bougthChrysanthemums > 20)
            {
                priceBouquet = priceBouquet - priceBouquet * 0.20;
            }
            double totalPriceBouquet = priceBouquet + 2.0;
            Console.WriteLine("{0:F2}",totalPriceBouquet);
        }
    }
}
