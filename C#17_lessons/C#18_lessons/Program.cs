using System.Linq.Expressions;
using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace C_18_lessons
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First lesson 
            ///Defining values step 
            //string firstPersonName = "Yusif";
            //int firstPersonAge = 25;
            //bool firstPersonIsMarried = true;


            //string secondPersonName = "Ali";
            //int secondPersonAge = 20;
            //bool secondPersonIsMarried = false;

            /////Calculation step 
            //int count = 4;
            //int price = 20;
            //int discountPercentage = 4;
            //float total = count * price;
            //total = total - total * discountPercentage / 100;
            //Console.WriteLine(total);



            //Console.WriteLine("Name is:" + firstPersonName);
            //Console.WriteLine("Age is:" + firstPersonAge);
            //Console.WriteLine("Evlidirmi? :" + "" + firstPersonIsMarried);
            //Console.WriteLine();
            //Console.WriteLine("Name is:" + secondPersonName);
            //Console.WriteLine("Age is:" + secondPersonAge);
            //Console.WriteLine("Evlidirmi? : " + secondPersonIsMarried);

            //int reminder = 123 % 8;
            //Console.WriteLine(reminder);
            //float currencyRates = 1.8f;
            //Console.WriteLine(currencyRates);
            #endregion

            #region Second lesson
            //string PersonName = "Eshqin";
            //string PersonLastName = "Huseynzade";
            //string PersonFullName = PersonName + " " + PersonLastName; //string Concantenation


            //int age = 25;
            //bool IsMarried = false;
            //bool hasChild = false;

            //Console.Write("Full Name of : ");
            //Console.WriteLine(PersonFullName);

            //Console.WriteLine("Age :" + age);
            ////Console.WriteLine(age);

            //if (PersonName == "Eshqin")
            //{
            //    Console.WriteLine("I am Mentor");
            //}


            //Console.Write("Is married :");

            //if (!IsMarried)
            //{
            //    Console.WriteLine("Beli evlidir. ");
            //    if (hasChild)
            //    {
            //        Console.WriteLine("Ovladi var .");
            //    }
            //}
            //else { Console.WriteLine("Xeyr evli deyildir."); }

            //Console.WriteLine(IsMarried);

            //if (age <= 30)
            //{
            //    Console.WriteLine("Yasli deyil. ");
            //}
            //else if (age > 35 && age < 60)
            //{
            //    Console.WriteLine("Orta yasli");
            //}
            //else { Console.WriteLine("Yasli Dede ."); }

            //if (age <= 25) {
            //    Console.WriteLine("Cavan yaslidir");
            //}
            //else if (hasChild && age > 25 && age <= 60)
            //{
            //    Console.WriteLine("Orta yasli");
            //}
            //else Console.WriteLine("Yasli qoca");

            //if (age == 18 || age == 25 || age == 50)
            //{
            //    Console.WriteLine("Bu sexs kecid dovrunndedir");
            //}
            #endregion

            #region Third lesson 
            // true && false => false 
            // true && true => true //(Shortcut Cirtcuit deyilir)
            // false && false => false 

            // if`in icinde if yazanda nesitive statements deyilir.

            //bool isMarried = false;
            //int number = 20;

            //if (number >= 20 && number <= 35) 
            //{
            //    Console.WriteLine("Hello World");
            //}


            /// 1.Mezenne hesablama proqrami:
            //decimal amountInazn = 10_000;
            //decimal usdRate = 1.7M;
            //decimal euroRate = 1.8092M;
            //decimal rubRate = 0.0225M;

            //Console.WriteLine("Mebleg (AZN) : "+ amountInazn);
            //Console.WriteLine();
            //Console.WriteLine("Abs dollari (USD) :"+ amountInazn / usdRate);
            //Console.WriteLine("Euro (EURO) :"+ amountInazn / euroRate );
            //Console.WriteLine("Rubl  (RUBL) :"+ amountInazn / rubRate);
            //Console.WriteLine();


            ///2. Olke budcesini hesablanmasina aid proqram: 

            //string azrepub = "Azerbaycan dovletinin illik budcesi :";
            //string ministry = "Ministry of Defence :";
            //string aztech = "High Technology Ministry :";

            //decimal yearBudget = 20_000_000_000;
            //decimal percentAge1 = 20;
            //decimal percentAge2 = 10;
            //decimal remainingBudget = 0;

            //Console.WriteLine(azrepub + " " + yearBudget + " Manat");
            //Console.WriteLine(ministry + " " + yearBudget * percentAge1 / 100 + " Manat");
            //Console.WriteLine(aztech + " " + yearBudget * percentAge2 / 100 + " Manat");
            //Console.WriteLine("Yerde qalan Budce :" +  yearBudget * 30 / 150 + "  Manat");

            ///3.Kargo sifarislerinin hesablanmasi ucun proqram: (1.növ metodu) 

            //string firstbrendName = " Adidas ";
            //int firstbrendShoescount = 4;
            //decimal firstbrendShoesPrice = 200;
            //decimal totalFirstbrendPrice = firstbrendShoesPrice * firstbrendShoes;

            //string secondbrendName = " Gucci ";
            //int secondbrendShoes = 2;
            //decimal secondbrendShoesPrice = 1000;
            //decimal totalSecondbrendPrice = secondbrendShoes * secondbrendShoesPrice;

            //string thirdbrendName = " Nike ";
            //int thirdbrendShoes = 1;
            //decimal thirdbrendShoesPrice = 100;
            //decimal totalThirdbrendPrice = thirdbrendShoes * thirdbrendShoesPrice;

            //decimal total = totalFirstbrendPrice + totalSecondbrendPrice + totalThirdbrendPrice;

            //Console.WriteLine("Firma adi : " + firstbrendName);
            //Console.WriteLine("Ayaqqabi sayi : " + firstbrendShoes);
            //Console.WriteLine("Birinin qiymeti : " +firstbrendShoesPrice);
            //Console.WriteLine("Hamisinin birlikde qiymeti :" +totalFirstbrendPrice);

            //Console.WriteLine("Firma adi : " + secondbrendName);
            //Console.WriteLine("Ayaqqabi sayi : " + secondbrendShoes);
            //Console.WriteLine("Birinin qiymeti : " + secondbrendShoesPrice);
            //Console.WriteLine("Hamisinin birlikde qiymeti :" + totalSecondbrendPrice);

            //Console.WriteLine("Firma adi : " + thirdbrendName);
            //Console.WriteLine("Ayaqqabi sayi : " + thirdbrendShoes);
            //Console.WriteLine("Birinin qiymeti : " + thirdbrendShoesPrice);
            //Console.WriteLine("Hamisinin birlikde qiymeti :" + totalThirdbrendPrice);
            //Console.WriteLine("######################################################################3");
            //Console.WriteLine("Toplam birlikde qiymetleri  : " + total);
            #endregion

            #region Fourth lesson ~~~~

            /// kecen seferki taskin yeni versiyasi qeyd ele !!!

            //Console.Write("Brand name :");
            //string firstBrandName = Console.ReadLine();
            //Console.Write("Count of Shoes Name : ");
            //int countofShoesFromFirstBrand = int.Parse(Console.ReadLine());
            //Console.Write("Price of Shoes : ");
            //decimal priceofShoesFromFirstBrand = decimal.Parse(Console.ReadLine()); 
            //decimal totalPriceFromFirstBrand = countofShoesFromFirstBrand * priceofShoesFromFirstBrand;

            //Console.Write("Brand name :");
            //string secondBrandName = Console.ReadLine();
            //Console.Write("Count of Shoes Name : ");
            //int countofShoesFromSecondBrand = int.Parse(Console.ReadLine());
            //Console.Write("Price of Shoes : ");
            //decimal priceofShoesFromSecondBrand = decimal.Parse(Console.ReadLine());
            //decimal totalPriceFromSecondBrand = countofShoesFromSecondBrand * priceofShoesFromSecondBrand;

            //Console.Write("Brand name :");
            //string thirdBrandName = Console.ReadLine();
            //Console.Write("Count of Shoes Name : ");
            //int countofShoesFromThirdBrand = int.Parse(Console.ReadLine());
            //Console.Write("Price of Shoes : ");
            //decimal priceofShoesFromThirdBrand = decimal.Parse(Console.ReadLine());
            //decimal totalPriceFromThirdBrand = countofShoesFromThirdBrand * priceofShoesFromThirdBrand;

            //decimal totalPrice = totalPriceFromFirstBrand + totalPriceFromSecondBrand + totalPriceFromThirdBrand;

            //Console.WriteLine("####################################################################################");

            //Console.WriteLine("Firma adi : " + firstBrandName);
            //Console.WriteLine("Ayaqqabi sayi :" + countofShoesFromFirstBrand);
            //Console.WriteLine("Birinin qiymeti  )$(:" + priceofShoesFromFirstBrand);
            //Console.WriteLine("Hamisinin birlikde qiymeti  )$(:" + totalPriceFromFirstBrand );

            //Console.WriteLine("Firma adi : " + secondBrandName);
            //Console.WriteLine("Ayaqqabi sayi :" + countofShoesFromSecondBrand);
            //Console.WriteLine("Birinin qiymeti  )$(:" + priceofShoesFromSecondBrand);
            //Console.WriteLine("Hamisinin birlikde qiymeti  )$(:" + totalPriceFromSecondBrand);

            //Console.WriteLine("Firma adi : " + thirdBrandName);
            //Console.WriteLine("Ayaqqabi sayi :" + countofShoesFromThirdBrand);
            //Console.WriteLine("Birinin qiymeti  )$(:" + priceofShoesFromThirdBrand);
            //Console.WriteLine("Hamisinin birlikde qiymeti  )$(:" + totalPriceFromThirdBrand);

            //Console.WriteLine();
            //Console.WriteLine("Hamisinin birlikde cemi : " + totalPrice);

            /// yeni task isle 
            ///string name = Console.ReadLine();
            #endregion

            #region Five lesson ~~~~~~
            //int counter = 5;
            //while (counter > 0)
            //{
            //    Console.WriteLine("Hello Bro :");
            //    counter = counter - 1;
            //}
            /// ilave 

            //Console.Write("Pls enter brand count :");
            //int brandcount = int.Parse(Console.ReadLine());
            //decimal total = 0;
            //decimal totalwithDiscount = 0;
            //decimal discountPercentage = 20;
            //decimal discountStartNumber = 5;
            //while (brandcount >= 1)
            //{
            //    string brandName = "";

            //    while (true)
            //    {
            //        Console.Write("BRand Name :");
            //        brandName = Console.ReadLine();

            //        if (brandName.Length > 5 && brandName.Length < 10)
            //        {
            //            break;
            //        }
            //    }
            //    Console.Write("Count of shoes :");
            //    int countofShoesFromBrand = int.Parse(Console.ReadLine());

            //    Console.Write("Price of shoes :");
            //    decimal priceofShoesFromBrand = decimal.Parse(Console.ReadLine());
            //    decimal totalPriceFromBrand = countofShoesFromBrand * priceofShoesFromBrand;
            //    total = total + totalPriceFromBrand;
            //    Console.WriteLine();
            //    Console.WriteLine($"Firma adi :  {brandName}"); // string interpolation 
            //    Console.WriteLine($"Ayaqqabi sayi :  {countofShoesFromBrand}");
            //    Console.WriteLine($"Birinin qiymeti  )$( : {priceofShoesFromBrand}");
            //    Console.WriteLine($"Hamisinin birlikde qiymeti )$( : {totalPriceFromBrand}");
            //    Console.WriteLine("#################################################################");
            //    // brandcount = brandcount -1;
            //    brandcount -= 1;
            //}
            //Console.WriteLine();
            //Console.WriteLine($"Yekun qiymet : " { total});

            /// misal 
            /// ucun ise qiymetin uzerine elave etmek ucun 
            /// total += 10; //total = total + 10 yeni eyn deyeri verir;
            #endregion

            #region SIXth lesson 
            //string[] name = new string[3];
            //string[] name = new string[3] {"MAhmood","Nijat","Eldar"};
            //string[] name = new string[]  {"MAhmood","Nijat","Eldar"};
            //string[] name = { "MAhmood", "Nijat", "Eldar" ,"Yusif","Heyder","Knyaz"  };

            ////string Name = Console.ReadLine();
            ////Console.WriteLine($"{names[0]} {names[1]}  {names[2]}");
            ////names[2] = "Hasan abi ";
            //Console.WriteLine($"{names[0]} {names[1]}  {names[2]}");

            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //int idx = 0;
            //while ( idx < names.Length )
            //{
            //    Console.WriteLine(names[idx]);


            //    //idx = idx + 1;  ///3-de eslinde herbiri eyni seydir 
            //    //idx += 1;
            //    idx++;
            //}

            //int namescount = int.Parse(Console.ReadLine());
            //string[] names = new string[namescount];
            //int fillIndex = 0;
            //while (fillIndex < namescount)
            //{
            //    name[fillIndex] = Console.ReadLine();
            //    fillIndex++;
            //}

            //int i = 10;
            //int total = 0;
            //while (i > 0) 
            //{
            //    Console.WriteLine("Hello World");
            //    total += 10; //total = total + 10;
            //    if (total == 20)
            //    {
            //        break;
            //    }
            //    i--;
            //}
            #endregion

            #region Seventh lesson ~~~~~~~ 
            //Console.Write("Pls enter brand count :");
            //int brandcount = int.Parse(Console.ReadLine());
            //decimal total = 0;
            //decimal totalwithDiscount = 0;
            //decimal discountPercentage = 20;
            //decimal discountStartNumber = 5;

            //while (brandcount >= 1)
            //{
            //    string brandName = "";

            //    while (true)
            //    {
            //        Console.Write("BRand Name :");
            //        brandName = Console.ReadLine();

            //        if (brandName.Length > 5 && brandName.Length < 10)
            //        {
            //            break;
            //        }
            //    }
            //    Console.Write("Count of shoes :");
            //    int countofShoesFromBrand = int.Parse(Console.ReadLine());

            //    Console.Write("Price of shoes :");
            //    decimal priceofShoesFromBrand = decimal.Parse(Console.ReadLine());
            //    decimal totalPriceFromBrand = countofShoesFromBrand * priceofShoesFromBrand;
            //    decimal totalPriceFromBrandwithDiscount = totalPriceFromBrand;

            //    Console.WriteLine();
            //    Console.WriteLine($"Firma adi :  {brandName}"); // string interpolation 
            //    Console.WriteLine($"Ayaqqabi sayi :  {countofShoesFromBrand}");
            //    Console.WriteLine($"Birinin qiymeti  )$( : {priceofShoesFromBrand}");
            //    Console.WriteLine($"Hamisinin birlikde qiymeti )$( : {totalPriceFromBrand}");
            //    Console.WriteLine("#################################################################");

            //    if (countofShoesFromBrand > discountStartNumber)
            //    {
            //        totalPriceFromBrand = totalwithDiscount - totalwithDiscount * discountPercentage / 100;
            //        Console.WriteLine($"Hamisinin birlikde qiymeti ($) : {totalwithDiscount}");
            //    }
            //    Console.WriteLine("###################################################################");

            //    total = total + totalPriceFromBrand;
            //    totalwithDiscount = totalwithDiscount + totalPriceFromBrandwithDiscount;
            //    // brandcount = brandcount -1;
            //    brandcount -= 1;
            //}
            //Console.WriteLine();
            //Console.WriteLine($"Yekun qiymet :   {total} ");
            //if (total != totalwithDiscount) Console.WriteLine($"(Tam Yekun) ENdirimli : {totalwithDiscount}");

            /// STRING ARRAYIN DAXILINDE INDEXLE VERMEK
            /// 
            //Console.Write("Pls enter brand count :");
            //int brandcount = int.Parse(Console.ReadLine());

            //decimal discountPercentage = 20;
            //decimal discountStartNumber = 5;

            //string[] brandNames = new string[brandcount];
            //decimal[] shoesPrices = new decimal[brandcount];
            //int[] shoesCounts = new int[brandcount];
            //decimal[] shoesTotalPrices = new decimal[brandcount];
            //decimal[] shoesTotalPricewithDiscount = new decimal[brandcount];

            //int index = 0;

            //while (index < brandcount)
            //{
            //    Console.Write("BRand Name :");
            //    brandNames[index] = Console.ReadLine();

            //    Console.Write("Count of shoes :");
            //    shoesCounts[index] = int.Parse(Console.ReadLine());

            //    Console.Write("Price of shoes :");
            //    shoesPrices[index] = decimal.Parse(Console.ReadLine());
            //    shoesTotalPrices[index] = shoesCounts[index] * shoesPrices[index];
            //    shoesTotalPricewithDiscount[index] = shoesTotalPrices[index];


            //    if (shoesCounts[index] > discountStartNumber)
            //    {
            //        shoesTotalPricewithDiscount[index] =
            //            shoesTotalPricewithDiscount[index] - shoesTotalPricewithDiscount[index] * discountPercentage / 100;
            //    }
            //    index++;
            //}
            //index = 0;
            //while (index < brandcount)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine($"Firma adi :  {brandNames[index]}"); /// string interpolation 
            //    Console.WriteLine($"Ayaqqabi sayi :  {shoesCounts[index]}");
            //    Console.WriteLine($"Birinin qiymeti  )$( : {shoesPrices[index]}");
            //    Console.WriteLine($"Hamisinin birlikde qiymeti )$( : {shoesTotalPricewithDiscount[index]}");
            //    Console.WriteLine("#################################################################");
            //    index++;
            //}
            #endregion

            #region 2.Task :Homework Explenation:_Terminalda məzənnə idarəetmə sistemi_
            //string[] currencies = { "USD", "EUR", "RUB" };
            //decimal[] rates = { 1.70M, 1.82M, 0.02M };
            //Console.WriteLine("Available commands : ");
            //Console.WriteLine("/show-recent-currency-rates");
            //Console.WriteLine("/find-currency-rate-by-code");
            //Console.WriteLine("/calculate-amount-by-currecy-code");
            //Console.WriteLine("/exit");
            //Console.WriteLine();
            //while (true)
            //{
            //    Console.WriteLine("Pls enter the command :");
            //    string command = Console.ReadLine();
            //    Console.WriteLine();
            //    if (command == "/show-recent-currency-rates")
            //    {
            //        //Console.WriteLine("CURRENCY RATES");
            //        int idx = 0;
            //        while (idx < currencies.Length)
            //        {
            //            Console.WriteLine($"Currency : {currencies[idx]}, Rate : {rates[idx]}");
            //            idx++;
            //        }
            //    }
            //    else if (command == "/find-currency-rate-by-code")
            //    {
            //        //Console.WriteLine("CURRENCY RATES BY CODE");
            //        Console.Write("Pls enter code : ");
            //        string specifiedCode = Console.ReadLine();
            //        bool isCurrencyExists = false;
            //        int idx = 0;
            //        while (idx < currencies.Length)
            //        {
            //            string currentCode = currencies[idx];
            //            decimal currentCodeRate = rates[idx];
            //            if (currentCode == specifiedCode)
            //            {
            //                Console.WriteLine($"Code : {currentCode},Rate : {currentCodeRate} ");
            //                isCurrencyExists = true;
            //                break;
            //            }
            //            idx++;
            //        }
            //        if (!isCurrencyExists)
            //            Console.WriteLine("Specified code not found ");


            //    }
            //    else if (command == "/calculate-amount-by-currecy-code")
            //    {
            //        //Console.WriteLine("CALCULATION");
            //        Console.Write("Pls enter amount in AZN : ");
            //        decimal amount = Convert.ToDecimal(Console.ReadLine());

            //        Console.Write("Pls enter code : ");
            //        string specifiedCode = Console.ReadLine();
            //        bool isCurrencyExists = false;
            //        int idx = 0;
            //        while (idx < currencies.Length)
            //        {
            //            string currentCode = currencies[idx];
            //            decimal currentCodeRate = rates[idx];
            //            if (currentCode == specifiedCode)
            //            {
            //                Console.WriteLine($"Amount in {currentCode} : {amount / currentCodeRate}");
            //                isCurrencyExists = true;
            //                break;
            //            }
            //            idx++;
            //        }
            //        if (!isCurrencyExists)
            //            Console.WriteLine("Specified code not found ");


            //    }
            //    else if (command == "/exit")
            //    {
            //        Console.WriteLine("Thanks for using,bye-bye");
            //        break;
            //    }
            //    else { Console.WriteLine("Specified Command not found "); }
            //}
            /// Taskin basqa versiyasi 
            /// 
            //string[] currencies = { "USD", "EUR", "RUB" };
            //decimal[] Currencyrates = { 1.70M, 1.82M, 0.02M };
            //string SHOW_CURRENCY_RATES_COMMAND = "/show-recent-currency-rates";
            //string FIND_CURRENCY_RATE_BY_CODE = "/find-currency-rate-by-code";
            //string CALCULATE_AMOUNT_BY_CURRENCY_RATE_BY_CODE = "/calculate-amount-by-currecy-code";
            //string EXIT_COMMAND = "/exit";
            //Console.WriteLine("Available commands : ");
            //Console.WriteLine(SHOW_CURRENCY_RATES_COMMAND);
            //Console.WriteLine(FIND_CURRENCY_RATE_BY_CODE);
            //Console.WriteLine(CALCULATE_AMOUNT_BY_CURRENCY_RATE_BY_CODE);
            //Console.WriteLine(EXIT_COMMAND);
            //Console.WriteLine();
            //while (true)
            //{
            //    Console.WriteLine("Pls enter the command :");
            //    string command = Console.ReadLine();
            //    Console.WriteLine();
            //    if (command == SHOW_CURRENCY_RATES_COMMAND)
            //    {
            //        for (int idx = 0; idx < Currencyrates.Length; idx++)
            //        { Console.WriteLine($"Currency : {currencies[idx]}, Rate : {Currencyrates[idx]}");}
            //    }
            //    else if (command == FIND_CURRENCY_RATE_BY_CODE)
            //    {
            //        //Console.WriteLine("CURRENCY RATES BY CODE");
            //        Console.Write("Pls enter code : ");
            //        string specifiedCode = Console.ReadLine();
            //        bool isCurrencyExists = false; //flag 

            //        for (int i = 0; i < currencies.Length; i++)
            //        {
            //            string currentCode = currencies[i];
            //            decimal currentCodeRate = Currencyrates[i];
            //            if (currentCode == specifiedCode)
            //            {
            //                Console.WriteLine($"Code : {currentCode},Rate : {currentCodeRate} ");
            //                isCurrencyExists = true; //update flag 
            //                break;
            //            }

            //        }
            //        if (!isCurrencyExists) //check flag value 
            //            Console.WriteLine("Specified code not found ");


            //    }
            //    else if (command == CALCULATE_AMOUNT_BY_CURRENCY_RATE_BY_CODE)
            //    {
            //        Console.Write("Pls enter amount in AZN : ");
            //        decimal amount = Convert.ToDecimal(Console.ReadLine());

            //        Console.Write("Pls enter code : ");
            //        string specifiedCode = Console.ReadLine();
            //        bool isCurrencyExists = false;
            //        for (int i = 0; i < currencies.Length; i++)
            //        {
            //            string currentCode = currencies[i];
            //            decimal currentCodeRate = Currencyrates[i];
            //            Console.WriteLine($"Amount in {currentCode} : {amount / currentCodeRate}");
            //            isCurrencyExists = true;
            //            break;
            //        }
            //        if (!isCurrencyExists)
            //            Console.WriteLine("Specified code not found ");
            //    }
            //    else if (command == EXIT_COMMAND)
            //    {
            //        Console.WriteLine("Thanks for using,bye-bye");
            //        break;
            //    }
            //    else { Console.WriteLine("Specified Command not found "); }
            //}
            #endregion

            #region Eighth lesson ~~~~~~~~~_ARRAYLER_(9-10) # Operations_on_Array # Operations_on_String  

            ///Ancaq Array ve loopa aid tapsiriqlar
            /// ve yalniz for-a aid




            //1. while loop to for loop
            //2.Array daxilinde elementlerin ceminin tapilmasi
            //3.Array elementlerini sondan arxaya cixarmaq
            //4.Array daxilinde, cut ededlerin cemi
            //5.Array daxilinde, tek elementlerin cemi
            //6.Array daxilinde, 5 - e tam bolunen ededlerin cemi
            //7.Daxil edilen 2 elementin yerlerinin deyisdirilmesi.
            //8.Array daxilinde, Max ededin tapilmasi
            //9.Array daxilinden, Min dedin tapilmasi
            //10.Max ve min ededin yerinin deyisdirilmesi

            /// 1.while loop to for loop 
            //string name = "Yusif Huseynzade";
            //int age = 25;
            //while (true)
            //{
            //    Console.WriteLine(name + " " +  age);
            //}
            /// 2. Array daxilinde elementlerin ceminin tapilmasi 


            /// 3. Array elementlerini sondan arxaya cixarmaq 

            ///4. Array daxilinde cut ededlerin cemi 

            ///5. Array daxilinde 5-e tam bolunen ededlerin cemi 

            ///6.Daxil edilen 2 elementin yerlerinin deyisdirilmesi 

            ///7.Array daxilinde MAx ededin tapilmasi 

            ///8.Array daxilinde Min ededin tapilmasi 

            ///9.Array daxilinden max ve min ededin yerinin deyisildirilmesi 


            //int[] numbers = new int[3];

            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    Console.WriteLine(numbers[i]);
            //    break;
            //}

            //string name = "Mahmood";
            //char[] letterA = { 'A', 'B', 'c', 'd' };
            //for (int i = 0; i < name.Length; i++)
            //{
            //    char letter = name[i];
            //    Console.WriteLine(name[i]);
            //}
            ///Operation_on_string
            ///
            //string name = "Yusif123";
            //char[] uppercaseLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            //char[] lowerLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            //char[] numbers = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            //bool isFound = false;

            //for (int i = 0; i < name.Length; i++)
            //{
            //    for (int k = 0; k < numbers.Length; k++)
            //    {
            //        if (name[i] == numbers[k])
            //        {
            //            Console.WriteLine("Daxilinde reqem var");
            //            isFound = true;
            //            break;
            //        }
            //    }
            //    if (isFound)  break;
            //}
            #endregion

            #region NINth lesson "11. .NET, CLR, Introduction to memory management,…"

            //CLR : 
            // Memory Management 
            //Exception Handling 
            //Translation
            #endregion

            #region Tenth lesson "XII_Introduction to methods DRY,SRP,KISS principles_
            //string[] currencies = { "USD", "EUR", "RUB" };
            //decimal[] Currencyrates = { 1.70M, 1.82M, 0.02M };

            //string SHOW_CURRENCY_RATES_COMMAND = "/show-recent-currency-rates";
            //string FIND_CURRENCY_RATE_BY_CODE = "/find-currency-rate-by-code";
            //string CALCULATE_AMOUNT_BY_CURRENCY_RATE_BY_CODE = "/calculate-amount-by-currecy-code";
            //string EXIT_COMMAND = "/exit";

            //Console.WriteLine("Available commands : ");
            //Console.WriteLine(SHOW_CURRENCY_RATES_COMMAND);
            //Console.WriteLine(FIND_CURRENCY_RATE_BY_CODE);
            //Console.WriteLine(CALCULATE_AMOUNT_BY_CURRENCY_RATE_BY_CODE);
            //Console.WriteLine(EXIT_COMMAND);
            //Console.WriteLine();

            //while (true)
            //{
            //    Console.WriteLine("Pls enter the command :");
            //    string command = Console.ReadLine();
            //    Console.WriteLine();
            //    if (command == SHOW_CURRENCY_RATES_COMMAND)
            //    {
            //        ExecuteShowCurrencyRatesCommand(Currencyrates, currencies); // --> METHOD CALL 
            //    }
            //    else if (command == FIND_CURRENCY_RATE_BY_CODE)
            //    {
            //        ExecuteFindCurrencyRateByCodeCommand(Currencyrates, currencies);
            //    }
            //    else if (command == CALCULATE_AMOUNT_BY_CURRENCY_RATE_BY_CODE)
            //    {
            //        ExecuteCalculateAmountByCurrencyRateByCode(Currencyrates, currencies);
            //    }
            //    else if (command == EXIT_COMMAND)
            //    {
            //        ExecuteExitCommand(command);
            //        break;
            //    }
            //    else { Console.WriteLine("Specified Command not found "); }
            //}


            ///// <summary>
            ///// Executes show currency rates functionality 
            ///// </summary>
            ///// <param name="Currencyrates"></param>
            ///// <param name="currencies"></param>  ---> Oz metinlerini elave ede bilersen.
            ///// Add to commit note

            ////static decimal[] GetCurrencyRates()
            ////{
            ////    return new[] { 1.70M, 1.82M, 0.02M };
            ////}
            //static void ExecuteShowCurrencyRatesCommand(decimal[] Currencyrates, string[] currencies)  // --> METHOD`S PARAMETERS
            //{
            //    for (int idx = 0; idx < Currencyrates.Length; idx++)
            //    { Console.WriteLine($"Currency : {currencies[idx]}, Rate : {Currencyrates[idx]}"); }

            //    //int idx = 0;
            //    //while (idx < currencyRates.Length)
            //    //{
            //    //  Console.WriteLine($"Currency : {currencies[idx]}, Rate : {currencyRates[idx]}");
            //    //  idx++;
            //    //}
            //}

            //static void ExecuteFindCurrencyRateByCodeCommand(decimal[] Currencyrates, string[] currencies)
            //{
            //    //Console.WriteLine("CURRENCY RATES BY CODE");
            //    //Console.Write("Pls enter code : ");
            //    //string specifiedCode = Console.ReadLine();
            //    //bool isCurrencyExists = false; //flag 

            //    Console.Write("Pls enter code : ");
            //    //string specifiedCode = Console.ReadLine();
            //    string currencyCode = Console.ReadLine();
            //    decimal CurrencyRate = FindCurrencyRateByCode(Currencyrates, currencies, currencyCode);
            //    if (CurrencyRate == -1)
            //    {
            //        Console.WriteLine("Alpha3 code not found ");
            //    }
            //    else { Console.WriteLine($"Currency code : {currencyCode} , Rate : {CurrencyRate}"); }




            //    //for (int i = 0; i < currencies.Length; i++)
            //    //{
            //    //    string currentCode = currencies[i];
            //    //    decimal currentCodeRate = Currencyrates[i];

            //    //    if (currencies[i] == specifiedCode)
            //    //    {
            //    //        Console.WriteLine($"Code : {currentCode},Rate : {currentCodeRate} ");
            //    //        isCurrencyExists = true; //update flag 
            //    //        break;
            //    //    }
            //    //}
            //    //if (!isCurrencyExists) //check flag value 
            //    //    Console.WriteLine("Specified code not found ");
            //}

            //static void ExecuteCalculateAmountByCurrencyRateByCode(decimal[] Currencyrates, string[] currencies)
            //{
            //    Console.Write("Pls enter amount in AZN : ");
            //    decimal amount = Convert.ToDecimal(Console.ReadLine());

            //    Console.Write("Pls enter code : ");
            //    string specifiedCode = Console.ReadLine();
            //    bool isCurrencyExists = false;
            //    for (int i = 0; i < currencies.Length; i++)
            //    {
            //        string currentCode = currencies[i];
            //        decimal currentCodeRate = Currencyrates[i];
            //        Console.WriteLine($"Amount in {currentCode} : {amount / currentCodeRate}");
            //        isCurrencyExists = true;
            //        break;
            //    }
            //    if (!isCurrencyExists)
            //        Console.WriteLine("Specified code not found ");
            //}

            //static void ExecuteExitCommand(string command)
            //{
            //    Console.WriteLine("Thanks for using,bye-bye");
            //}

            //static decimal FindCurrencyRateByCode(decimal[] argCurrencyrates, string[] argcurrencies, string argcode)
            //{
            //    decimal DEFAULT_CURRENCY_RATE = -1;

            //    for (int i = 0; i < argcurrencies.Length; i++)
            //    {
            //        if (argcurrencies[i] == argcode)
            //        {
            //            //decimal rate = Currencyrates[i];
            //            //return rate; 
            //            /*> 0 ? rate : 0;*/
            //            return argCurrencyrates[i];
            //        }
            //    }
            //    return DEFAULT_CURRENCY_RATE;
            //    Console.WriteLine();
            //}
            #endregion

            #region "XIII_Eleventh lesson More_on_ARRAYS_"

            //static void Multiply(int yusif)
            //{
            //    yusif = yusif * 2;

            //    Console.WriteLine(yusif);
            //}
            //static void Added(string[] arry)
            //{
            //    int number = 4;
            //    Multiply(number);

            //    Console.WriteLine(number);
            //}



            //int temp = 3;

            //Console.WriteLine(temp);

            //UpdateArray(temp);

            //Console.WriteLine(temp);
            //static void UpdateArray(int number)
            //{
            //    number = 98;
            //}

            #endregion

            #region "14. LEsson Pass by value and pass by reference"
            ///DRY
            ///SRP
            ///KISS
            ///principles

            string[] currencies = { "USD", "EUR", "RUB" };
            decimal[] Currencyrates = { 1.70M, 1.82M, 0.02M };

            string SHOW_CURRENCY_RATES_COMMAND = "/show-recent-currency-rates";
            string FIND_CURRENCY_RATE_BY_CODE = "/find-currency-rate-by-code";
            string CALCULATE_AMOUNT_BY_CURRENCY_RATE_BY_CODE = "/calculate-amount-by-currecy-code";
            string EXIT_COMMAND = "/exit";

            Console.WriteLine("Available commands : ");
            Console.WriteLine(SHOW_CURRENCY_RATES_COMMAND);
            Console.WriteLine(FIND_CURRENCY_RATE_BY_CODE);
            Console.WriteLine(CALCULATE_AMOUNT_BY_CURRENCY_RATE_BY_CODE);
            Console.WriteLine(EXIT_COMMAND);
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("Pls enter the command :");
                string command = Console.ReadLine();
                Console.WriteLine();
                if (command == SHOW_CURRENCY_RATES_COMMAND)
                {
                    ExecuteShowCurrencyRatesCommand(Currencyrates, currencies); // --> METHOD CALL 
                }
                else if (command == FIND_CURRENCY_RATE_BY_CODE)
                {
                    ExecuteFindCurrencyRateByCodeCommand(Currencyrates, currencies);
                }
                else if (command == CALCULATE_AMOUNT_BY_CURRENCY_RATE_BY_CODE)
                {
                    ExecuteCalculateAmountByCurrencyRateByCode(Currencyrates, currencies);
                }
                else if (command == EXIT_COMMAND)
                {
                    ExecuteExitCommand(command);
                    break;
                }
                else { Console.WriteLine("Specified Command not found "); }
            }


            /// <summary>
            /// Executes show currency rates functionality 
            /// </summary>
            /// <param name="Currencyrates"></param>
            /// <param name="currencies"></param>  ---> Oz metinlerini elave ede bilersen.
            /// Add to commit note

            //static decimal[] GetCurrencyRates()
            //{
            //    return new[] { 1.70M, 1.82M, 0.02M };
            //}
            static void ExecuteShowCurrencyRatesCommand(decimal[] Currencyrates, string[] currencies)  // --> METHOD`S PARAMETERS
            {
                for (int idx = 0; idx < Currencyrates.Length; idx++)
                { Console.WriteLine($"Currency : {currencies[idx]}, Rate : {Currencyrates[idx]}"); }

                //int idx = 0;
                //while (idx < currencyRates.Length)
                //{
                //  Console.WriteLine($"Currency : {currencies[idx]}, Rate : {currencyRates[idx]}");
                //  idx++;
                //}
            }

            static void ExecuteFindCurrencyRateByCodeCommand(decimal[] Currencyrates, string[] currencies)
            {
                //Console.WriteLine("CURRENCY RATES BY CODE");
                //Console.Write("Pls enter code : ");
                //string specifiedCode = Console.ReadLine();
                //bool isCurrencyExists = false; //flag 

                Console.Write("Pls enter code : ");
                //string specifiedCode = Console.ReadLine();
                string currencyCode = Console.ReadLine();
                decimal CurrencyRate = FindCurrencyRateByCode(Currencyrates, currencies, currencyCode);
                if (CurrencyRate == -1)
                {
                    Console.WriteLine("Alpha3 code not found ");
                }
                else { Console.WriteLine($"Currency code : {currencyCode} , Rate : {CurrencyRate}"); }




                //for (int i = 0; i < currencies.Length; i++)
                //{
                //    string currentCode = currencies[i];
                //    decimal currentCodeRate = Currencyrates[i];

                //    if (currencies[i] == specifiedCode)
                //    {
                //        Console.WriteLine($"Code : {currentCode},Rate : {currentCodeRate} ");
                //        isCurrencyExists = true; //update flag 
                //        break;
                //    }
                //}
                //if (!isCurrencyExists) //check flag value 
                //    Console.WriteLine("Specified code not found ");
            }

            static void ExecuteCalculateAmountByCurrencyRateByCode(decimal[] Currencyrates, string[] currencies)
            {
                decimal amount = 0;
                string amountInput;
                do
                {
                    Console.Write("Pls enter amount : ");
                    //amount = Convert.ToDecimal(Console.ReadLine());
                    amountInput = Console.ReadLine();

                } while (!TryConvert(amountInput,amount));

                string currencyCode = Console.ReadLine();

                decimal currencyRate = FindCurrencyRateByCode(Currencyrates.ToArray(), currencies, currencyCode);
                if (currencyRate == -1)
                {
                    Console.WriteLine("Alpha3 code not found");
                }
                else { Console.WriteLine($"Amount int target currency rate : {amount / currencyRate}"); }
            }

            static void ExecuteExitCommand(string command)
            {
                Console.WriteLine("Thanks for using,bye-bye");
            }

            static decimal FindCurrencyRateByCode(decimal[] argCurrencyrates, string[] argcurrencies, string argcode)
            {
                decimal DEFAULT_CURRENCY_RATE = -1;

                for (int i = 0; i < argcurrencies.Length; i++)
                {
                    if (argcurrencies[i] == argcode)
                    {
                        //decimal rate = Currencyrates[i];
                        //return rate; 
                        /*> 0 ? rate : 0;*/
                        return argCurrencyrates[i];
                    }
                }
                return DEFAULT_CURRENCY_RATE;
                Console.WriteLine();
            }

            static bool TryConvert(string input, decimal amount)
            {
                try
                {
                    amount = int.Parse(input);
                    //Console.WriteLine("Shhhh New added amount");
                    return true;
                }
                catch (Exception)
                {
                    return false;
                    ///Yeniden loopa girmesi ucun verilibdir throw
                    //throw;
                }
            }
            #endregion

            #region 15 <=> 16 HOMEWORK EXERCISES


            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };






            #endregion

            #region  "17. Intro to OOP"

            #endregion
        }
    }
}

