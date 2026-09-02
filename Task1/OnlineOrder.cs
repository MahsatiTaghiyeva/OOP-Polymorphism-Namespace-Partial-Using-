//*Order class-ından miras alan, OnlineOrder class-ı yaratmalıFieldlar:
    //Id
    //Məhsulun adı
    //Məhsulun sayı
    //Məhsulun qiyməti
    //Sifarişin məsafəsi
using System.Text;

public class OnlineOrder : Order
{
    public double Distance {get; set;}
    //Dəyərlər constructor vasitəsilə verilməlidir
    public OnlineOrder(string id, string name, double price, int count,double distance) : base(id, name,  price, count)
    {
        Distance = distance;
    }
    //Yaradılmalı olan metodlar:Hər 5km məsafə üçün 2 manat çatdırılma ödənişi alınmalıdır. Çatdırılma üçün olan ümumi ödənişi geri qaytaran metod.
    public double PriceDelivery()
    {
        return Distance/5*2;
    }
    //Çatıdırılma məbləği ilə birlikdə ümumi məbləği detallı şəkildə göstərən metod. StringBuilder ilə. Çıxış nümunəsi:
    //Sifariş ID: 1
    //Məhsul: Kitab
    //Sayı: 2
    //Qiymət: 15 AZN
    //Ümumi Məbləğ: 30 AZN
    //Məsafə: 12 Km
    //Çatıdırlma: 3 AZN
    //Ümumi Məbləğ Çatdırılma ilə: 33 AZN
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine($"Sifariş ID: {Id}");
        sb.AppendLine($"Məhsul: {Name}");
        sb.AppendLine($"Sayı: {Count}");
        sb.AppendLine($"Qiymət: {Price} AZN");
        sb.AppendLine($"Ümumi Məbləğ: {TotalPrice()} AZN");
        sb.AppendLine($"Məsafə: {Distance} Km");
        sb.AppendLine($"Çatdırılma: {PriceDelivery()} AZN");
        sb.AppendLine($"Ümumi Məbləğ Çatdırılma ilə: {TotalPrice() + PriceDelivery()} AZN");

        return sb.ToString();
    }
}
