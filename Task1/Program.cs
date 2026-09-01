//order1.ChangePrice(....);
//Console.WriteLine(diff); // Yeni və köhnə qiymət arasındakı fərq
//Console.WriteLine(order1.Price); // Yeni qiymət
double diff;
Order order1 = new Order("243f4","Phone",43, 2);
Console.WriteLine(order1.ToString());
order1.ChangePrice(29, out diff);
Console.WriteLine(diff);
Console.WriteLine(order1.Price);
System.Console.WriteLine();