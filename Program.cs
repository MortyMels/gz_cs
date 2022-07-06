// See https://aka.ms/new-console-template for more information
int? max = null;
int num;
Random rnd = new Random();
bool r = true;
while(r){
    Console.Write("Введите число или rnd");

    if (max is not null){
        Console.Write(" или max: ");
    }else{
        Console.Write(": ");
    }

    string str = Console.ReadLine();

    if (int.TryParse(str, out num)){
        if(max == null){
            max=num;
        }
        max=Math.Max(Convert.ToInt32(max),num);
    }else if(str=="max"){
        if(max == null){
            Console.Write("Ни одно число не введено - ");
        }else{
            r=false;
        }
    }else if (str=="rnd"){
        num = rnd.Next();
        Console.WriteLine($"Сгенерировано число: {num}");
        
        if(max is null){
            max=num;
        }
        max=Math.Max(Convert.ToInt32(max),num);
    }else{
        Console.WriteLine("Введено неверное значение, попробуйте еще раз");
    }
}
Console.WriteLine($"Максимальное число: {max}");

