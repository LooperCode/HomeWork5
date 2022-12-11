Console.WriteLine("Введите размер массива");
int n = Convert.ToInt32(Console.ReadLine());
double [] a = new double[n];
int count = 0;
double sum = 0;
double diff = 0;


Random rand = new Random();
for (int i = 0; i < n; i++ ){
    a[i] = rand.Next(100, 1000); 
        if (a[i]%2 == 0){
            count ++;
}
        else if (a[i]%2 != 0)  {
            sum = sum + a[i];
}
       
}
Console.WriteLine($"Result: [{String.Join(", ", a)}]");
Console.WriteLine($"Result: Количество четных чисел: [{count}]");
Console.WriteLine($"Result: Сумма чисел стоящих на нечетных позициях: [{sum}]");
int index = 0;
double min = a[0];
double max = a[0];
while (index < n){
        if (a[index] < min){
            min = a[index];
            index ++;
        }
        else if (a[index] > max){
            max = a[index];
            index ++;
        }
         else {
            index ++;
        }
       }
diff = max - min; 
Console.Write($"Result: Сумма разницы между max и min: [{diff}]");


   
