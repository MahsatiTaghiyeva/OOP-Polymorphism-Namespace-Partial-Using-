// Class:Order adında class yaratmalı Fieldlar:

    //Id
    //Məhsulun adı
    //Məhsulun sayı
    //Məhsulun qiyməti
using System;
public class Order
{
    public string Id {get; set;}
    public string Name {get; set;}
    public int Count {get; set;}
    public double Price {get; set;}

//Dəyərlər Construcor ilə verilməlidir. 2 ədəd constructor olmalıdır:
//Əgər Obyekt yaradılarkən Məhsulun sayı göndərilərsə, Məhsul sayı field-ı həmin dəyərə bərabər olmalıdır.
//Əgər göndərilməzsə 1-ə
    public Order(string id, string name, double price, int count)
{
    Id = id;
    Name = name;
    Count = count;
    Price = price;
}
public Order(string id, string name, double price)
{
    Id = id;
    Name = name;
    Count = 1;
    Price = price;
}
//Yaradılmalı olan metodlar:
//Sifarişin ümumi məbləğini geri qaytaran metod
public double TotalPrice()
    {
        return Count*Price;
    }
//Metoda n dəyəri göndəriləcək. Sifarişdə olan məhsulun sayını n qədər artıran metod. Əgər n göndərilməsə 1 vahid artırılacaq.
public int IncreaseCount(int n = 1)
    {
        return Count +=n;
    }

    //ToString override ederek  edərək Sifariş məlumatlarını ekrana yazdıram metod: Çıxış nümunəsi:
    //Sifariş ID: 1
    //Məhsul: Kitab
    //Sayı: 2
    //Qiymət: 15 AZN
    //Ümumi Məbləğ: 30 AZN    
    public override string ToString()
    {
        return $"Sifariş ID: {Id}, Məhsul: {Name}, Sayı: {Count}, Qiymət: {Price}, Ümumi Məbləğ: {TotalPrice()}";
    }
//diff adında dəyəri olmayan bir dəyişən təyin edəcəm. Məhsulun qiymətini dəyişmək üçün elə bir metod yaradın ki, metod-a məhsulun yeni qiymətini göndərim və o metod həm məhsulun qiymətini dəyişsin, həm də məhsulun köhnə qiyməti ilə yeni qiyməti arasındakı fərqi mənə diff dəyişəni vasitəsilə qaytarsın.
//int diff;
     public double ChangePrice(double newPrice, out double diff)
    {
        double oldPrice = Price;
        Price = newPrice;
        diff = newPrice- oldPrice;
        if (diff < 0)
        {
            diff = -diff;
        }
        return Price;
    }
}


