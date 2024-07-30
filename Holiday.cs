//Kullanıcının tekrar tatil planlayıp planlamadığını kontrol etmek için tanımlandı
bool planAgain = true;

do
{
    Console.WriteLine("Hangi lokasyona gitmek istiyorsunuz?\nBodrum (Paket başlangıç fiyatı 4000 TL)\nMarmaris (Paket başlangıç fiyatı 3000 TL)\nÇeşme (Paket başlangıç fiyatı 5000 TL)");

    bool trueLocation = false; // Doğru lokasyon kontrol
    string selectedLocation = ""; // Seçilen lokasyonun tutulduğu yer
    int locationPrice = 0; // Seçilan lokasyona göre ödenecek miktar bu değişkene atanıyor
    int bodrumPrice = 4000, marmarisPrice = 3000, cesmePrice = 5000;
    int highway = 1500, airline = 4000;

    do
    {
        string location = Console.ReadLine();
        if (location.ToLower() == "bodrum" || location.ToLower() == "marmaris" || location.ToLower() == "çeşme") // Kullanıcının lokasyonu doğru girip girmediğinin kontrolü
        {
            trueLocation = true;
            selectedLocation = location;
            switch (location.ToLower()) // Seçilen lokasyonun ücretinin atanması
            {
                case "bodrum":
                    locationPrice = bodrumPrice;
                    break;
                case "marmaris":
                    locationPrice = marmarisPrice;
                    break;
                case "cesme":
                    locationPrice = cesmePrice;
                    break;
            }
        }
        else
        {
            Console.WriteLine("Lütfen doğru bir lokasyon giriniz");
        }
    } while (trueLocation == false);

    Console.WriteLine("Kaç kişiyle tatil yapmayı planlıyorsunuz?");
    int passengerCount = Convert.ToInt32(Console.ReadLine());

    if (selectedLocation.ToLower() == "bodrum")
        Console.WriteLine("Bodrum'da antik kalıntıları keşfederken berrak sularda yüzebilir, ünlü gece hayatının tadını çıkarabilirsiniz.");
    else if (selectedLocation.ToLower() == "marmaris")
        Console.WriteLine("Marmaris'te doğa yürüyüşleri ve tekne turları ile eşsiz koyları keşfederken, plajda dinlenip güneşin keyfini çıkarabilirsiniz");
    else
        Console.WriteLine("Çeşme'de rüzgar sörfü yapabilir, termal suların rahatlatıcı etkisini hissedebilir ve hareketli Alaçatı sokaklarında dolaşabilirsiniz");

    string transportSelect = "", transportMode = ""; // Hangi ulaşım aracının seçildiğinin ataması
    int transportPrice = 0; // Seçilen ulaşım aracına göre ücret ataması yapılacak değişken
    bool transportApproval = false; // Belirtilen ulaşım araçlarından birinin seçilip seçilmediği kontrolü
    do
    {
        Console.WriteLine("Tatilinize ne şekilde gitmek istiyorsunuz?\n1 - Kara Yolu (Kişi başı ulaşım tuarı gidiş-dönüş 1500TL)\n2 - Hava Yolu (Kişi başı ulaşım tutarı gidiş-dönüş 4000TL)");
        transportSelect = Console.ReadLine();
        if (transportSelect == "1" || transportSelect == "2")
        {
            if (transportSelect == "1")
            {
                transportMode = "Kara Yolu";
                transportPrice = highway;
            }
            else
            {
                transportMode = "Hava Yolu";
                transportPrice = airline;
            }
            transportApproval = true;
        }
        else
            Console.WriteLine("Lütfen doğru bir ulaşım türü seçiniz, Kara Yolu için 1 Hava Yolu için 2 yazmanız gerekmektedir.");
    } while (transportApproval == false);

    Console.WriteLine($"Gideceğiniz Lokasyon: {selectedLocation} Kişi Sayısı: {passengerCount} Ulaşım Aracı: {transportMode} Tatilin Toplam Fiyati: {(transportPrice + locationPrice) * passengerCount}");

    // Kullanıcının farklı bir tatil planı daha yapıp yapmak istemediğini kontrol ediliyor, yapmak istemiyorsa planAgain değişkeni false oluyor ve do-while sonlanıyor
    Console.WriteLine("Başka bir tatil planlamak istiyor musunuz? Eğer planlamak istiyorsanız 'Evet' planlamak istemiyorsanız 'Hayır' yazabilirsiniz");
    string planAnswer = Console.ReadLine();
    if (planAnswer.ToLower() == "hayır")
        planAgain = false;
} while (planAgain == true);

Console.WriteLine("İyi günler dileriz");

