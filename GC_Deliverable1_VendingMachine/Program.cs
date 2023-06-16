using System;


namespace vendingMachine
{

    class Shop
    {

        static void Main(string[] args)
        {

            Console.WriteLine("===========================================\n\n");
            Console.WriteLine("=====    SODA     CANDY     CHIPS      ====");
            Console.WriteLine("===========================================\n\n");
            {
                static void Stock()
                { //soda full stock 100, candy full stock 60, chip full stock 40.

                    //soda restock at 40, candy restock at 40, chip restock at 20.

                    int sodaStockLeft = 0;
                    int candyStockLeft = 0;
                    int chipsStockLeft = 0;

                    int SodaStock = 100;
                    int sodaOrder = 0;
                    int sodaNeedsRestock = SodaStock - sodaOrder;

                    int CandyStock = 60;
                    int candyOrder = 0;
                    int candyNeedsRestock = CandyStock - candyOrder;

                    int ChipStock = 40;
                    int chipOrder = 0;
                    int chipNeedsRestock = ChipStock - chipOrder;

                    var sodaResult = 0;
                    
                    {
                        Console.WriteLine("How much soda have we sold today? \n");


                        Console.WriteLine(" Enter Soda Amount : ");
                        int sodaInput = Convert.ToInt32 (Console.ReadLine());                        
                        Console.ReadLine();
                        sodaResult = sodaInput - SodaStock;
                        Console.WriteLine($"soda left {sodaResult}: ");

                        //========================= Soda order and restock =====================
                        if (sodaStockLeft >= 1 && sodaStockLeft <= 59)
                        {
                            Console.WriteLine("=  Not enough soda. We need to restock.  =");
                            Console.WriteLine("===========================================\n\n");
                        }

                        else if (sodaStockLeft >= 60 && sodaStockLeft <= 100)
                        {
                            Console.WriteLine("=   Enough soda.No need to restock yet.   =");
                            Console.WriteLine("===========================================");
                        }
                        else if (sodaOrder > 100) ;
                        {
                            Console.WriteLine("\nToo High. Sorry we don't have that much soda in stock.\n");
                            Console.WriteLine("===========================================");
                        }
                       
                        
                            //========================= Candy order and restock =====================
                            Console.WriteLine($"\n Candy in stock:{CandyStock}");
                            Console.Write(" Enter candy amt : ");
                            sodaOrder = int.Parse(Console.ReadLine());
                            int CandyStockLeft = CandyStock - candyOrder;
                            Console.ReadLine();
                            Console.WriteLine($"soda left {candyStockLeft}: ");

                            Console.WriteLine("\n\nHow much candy have we sold today?");
                            Console.Write(" Enter candy amt: ");

                            candyOrder = int.Parse(Console.ReadLine());

                            if (candyOrder >= 1 && candyOrder <= 39)
                            {
                                Console.WriteLine("=  Enough candy. No need to restock yet.  =");
                                Console.WriteLine("===========================================");
                            }

                            if (candyOrder >= 40)
                            {
                                Console.WriteLine("\n We need to restock candy.");
                            }

                            if (candyOrder > 60)
                            {
                                Console.WriteLine("\n Too High. Sorry we don't have that much candy in stock.");
                                Console.WriteLine("===============================================");
                            }

                            
                            
                            //========================= Chip order and restock =====================
                            Console.WriteLine($"\n Soda in stock:{ChipStock}");
                            Console.Write(" Enter soda amt : ");
                            chipOrder = int.Parse(Console.ReadLine());
                            int ChipStockLeft = ChipStock - chipOrder;
                            Console.ReadLine();
                            Console.WriteLine($"soda left {ChipStockLeft}: ");
                            Console.WriteLine("\n How many chips have sold today?");
                            Console.Write(" Enter Chip amt: ");

                            chipOrder = int.Parse(Console.ReadLine());
                            if (chipOrder >= 1 && chipOrder <= 19) ;
                            {
                                Console.WriteLine("Enough chips, no need to restock yet.");
                            }

                            if (chipOrder >= 20)
                            {
                                Console.WriteLine("=            We need to restock.          =");
                                Console.WriteLine("===========================================");
                            }

                            if (chipOrder > 60) ;
                            {
                                Console.WriteLine("\n Too High. Sorry we don't have that many chips in stock.");
                                Console.WriteLine("===============================================");

                            }

                            if (sodaNeedsRestock == sodaResult
                                Console.WriteLine("INVENTORY NEEDED TO BE RESTOCKED.\n\n ");

                                Console.WriteLine($"Soda: {sodaNeedsRestock}");

                                Console.WriteLine($"Candy: {candyNeedsRestock}");

                                Console.WriteLine($"Chips: {chipNeedsRestock}");



                                Console.ReadLine();


                                Console.WriteLine("===========================================");

                                Console.WriteLine("========== press any key to exit ==========");
                                Console.ReadKey();

                            


                            

                        
                    }
                }
            }
        }
    }
}