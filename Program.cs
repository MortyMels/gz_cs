// See https://aka.ms/new-console-template for more information
int? max = default(int);
int num;
//max = 0;
bool r = true;
while(r){
    Console.Write("Введите число или max для определения максимального числа: ");
    string str = Console.ReadLine();

    if (int.TryParse(str, out num)){
        if(max == null){
            max=;
        }else{
            max=Math.Max(Convert.ToInt32(max),num);
        }
    }else if(str=="max"){
         r=false;
    }else if(){
    
    }else{
        Console.WriteLine("Введено неверное значение, попробуйте еще раз");
    }
}
Console.WriteLine($"Максимальное число{max}");

